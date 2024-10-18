using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kullanicigirislimesai
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }


            string connectionString = "Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Kullanici (KullaniciAdi, Sifre) VALUES (@kullaniciAdi, @sifre)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre); // Gerçek uygulamalarda şifreyi hash'leyin

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarılı!");
                            this.Close(); // Formu kapat
                        }
                        else
                        {
                            MessageBox.Show("Kayıt sırasında bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }
        private bool IsUsernameTaken(string kullaniciAdi)
        {
            string connectionString = "Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @kullaniciAdi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}