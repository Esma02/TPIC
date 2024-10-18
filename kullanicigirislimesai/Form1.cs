using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kullanicigirislimesai
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand cmd;
        public static int KullaniciId; // Kullanýcý ID'yi diðer formlara taþýmak için static 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;
            string connectionString = "Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT KullaniciId FROM Kullanici WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                KullaniciId = dr.GetInt32(0);
                                // MessageBox.Show("Tebrikler, giriþ baþarýlý!");

                                this.Hide();
                                Form2 hesaplamaForm = new Form2(KullaniciId);
                                hesaplamaForm.Show();
                                //MessageBox.Show("Kullanýcý Id=" + KullaniciId);
                            }
                            else
                            {
                                MessageBox.Show("Hatalý kullanýcý adý veya þifre.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý sýrasýnda bir hata oluþtu: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Kaydol kaydol = new Kaydol();
            kaydol.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
