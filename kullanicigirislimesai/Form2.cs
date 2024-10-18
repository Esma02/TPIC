using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kullanicigirislimesai
{
    public partial class Form2 : Form
    {
        private int KullaniciId;
        private int secimHesaplamaId;

        public Form2(int KullaniciId)
        {
            InitializeComponent();
            this.KullaniciId = KullaniciId; // KullaniciId'yi burada sakla
            LoadData();
            //MessageBox.Show("Kullanıcı Id=" + KullaniciId);

        }
        // Fazla mesai hesaplama metodu
        private double HesaplaFazlaMesai(DateTime baslangic, DateTime bitis)
        {
            double toplamFazlaMesai = 0;
            DateTime currentDayStart = baslangic;
            DateTime currentDayEnd = bitis;

            // Gün gün fazla mesaiyi hesaplamak için döngü
            while (currentDayStart.Date <= bitis.Date)
            {
                if (currentDayStart.Date == bitis.Date)
                {
                    currentDayEnd = bitis;
                }
                else
                {
                    // O günün gece yarısına kadar mesaiyi hesapla
                    currentDayEnd = currentDayStart.Date.AddDays(1).AddSeconds(-1);
                }

                toplamFazlaMesai += HesaplaGunlukFazlaMesai(currentDayStart, currentDayEnd);
                currentDayStart = currentDayStart.Date.AddDays(1).AddHours(0);

            }

            return toplamFazlaMesai;

        }

        // Her gün için fazla mesai hesaplama
        private double HesaplaGunlukFazlaMesai(DateTime baslangic, DateTime bitis)
        {
            double gunlukFazlaMesai = 0;

            DateTime gunBasi = baslangic.Date.AddHours(0);    // 00:00
            DateTime gunSonu = baslangic.Date.AddHours(23).AddMinutes(59);  // 23:59

            // Hafta içi
            if (baslangic.DayOfWeek >= DayOfWeek.Monday && baslangic.DayOfWeek <= DayOfWeek.Friday)
            {
                DateTime calismaBaslangici = baslangic.Date.AddHours(8);
                DateTime calismaBitisi = baslangic.Date.AddHours(17);

                if (baslangic < calismaBaslangici)
                {
                    if (bitis < calismaBaslangici)
                    {
                        gunlukFazlaMesai += (bitis - baslangic).TotalHours;
                    }
                    else if (bitis > calismaBitisi)
                    {
                        gunlukFazlaMesai += ((calismaBaslangici - baslangic) + (bitis - calismaBitisi)).TotalHours;
                    }
                    else
                    {
                        gunlukFazlaMesai += (calismaBaslangici - baslangic).TotalHours;
                    }
                }
                else
                {
                    if (baslangic > calismaBitisi)
                    {
                        gunlukFazlaMesai += (bitis - baslangic).TotalHours;
                    }
                    else if (bitis > calismaBitisi)
                    {
                        gunlukFazlaMesai += (bitis - calismaBitisi).TotalHours;
                    }
                }
                if (baslangic.TimeOfDay < new TimeSpan(13, 0, 0) && bitis.TimeOfDay > new TimeSpan(12, 0, 0))
                {
                    if (bitis.TimeOfDay < new TimeSpan(12, 30, 0)/*&& baslangic.TimeOfDay<new TimeSpan(12,0,0)*/)
                    {
                        gunlukFazlaMesai += 0.5;
                    }
                    else
                    {
                        gunlukFazlaMesai++;

                    }
                }

                if (gunlukFazlaMesai >= 6)
                {
                    gunlukFazlaMesai = 6;
                }

            }
            //Cumartesi
            else if (baslangic.DayOfWeek == DayOfWeek.Saturday)
            {
                DateTime calismaBaslangici = baslangic.Date.AddHours(8);
                DateTime calismaBitisi = baslangic.Date.AddHours(12);

                if (baslangic < calismaBaslangici)
                {
                    if (bitis < calismaBaslangici)
                    {
                        gunlukFazlaMesai += (bitis - baslangic).TotalHours;
                    }
                    else if (bitis > calismaBitisi)
                    {
                        gunlukFazlaMesai += ((calismaBaslangici - baslangic) + (bitis - calismaBitisi)).TotalHours;
                    }

                    else
                    {
                        gunlukFazlaMesai += (calismaBaslangici - baslangic).TotalHours;
                    }
                }
                else
                {
                    if (baslangic > calismaBitisi)
                    {
                        gunlukFazlaMesai += (bitis - baslangic).TotalHours;
                    }
                    else if (bitis > calismaBitisi)
                    {
                        gunlukFazlaMesai += (bitis - calismaBitisi).TotalHours;
                    }

                }
                if (gunlukFazlaMesai > 7.5)
                {
                    gunlukFazlaMesai = 7.5;
                }

                return gunlukFazlaMesai;

            }
            //Pazar
            else if (baslangic.DayOfWeek == DayOfWeek.Sunday)
            {
                gunlukFazlaMesai += (bitis - baslangic).TotalHours;

                if (gunlukFazlaMesai >= 10.5)
                {
                    gunlukFazlaMesai = 10.5;
                }

            }

            return gunlukFazlaMesai;
        }


        private string SaatDonusturme(double decimalSaat)
        {
            int saat = (int)decimalSaat;
            double decimaldakika = (decimalSaat - saat) * 60;
            int dakika = (int)Math.Round(decimaldakika);
            if (0 < dakika)
            {
                if (dakika <= 30)
                {
                    dakika = 30;
                }
                else if (dakika > 30)
                {
                    dakika = 60;
                }
            }
            if (dakika == 60)
            {
                saat++;
                dakika = 0;
            }


            return $"{saat:D2}:{dakika:D2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtbas.Value;
                DateTime bitisTarihi = dtbit.Value;
                DateTime baslangicSaati = dtsbas.Value;
                DateTime bitisSaati = dtsbit.Value;

                DateTime baslangic = new DateTime(
                    baslangicTarihi.Year, baslangicTarihi.Month, baslangicTarihi.Day,
                    baslangicSaati.Hour, baslangicSaati.Minute, 0);

                DateTime bitis = new DateTime(
                    bitisTarihi.Year, bitisTarihi.Month, bitisTarihi.Day,
                    bitisSaati.Hour, bitisSaati.Minute, 0);

                if (bitis < baslangic)
                {
                    MessageBox.Show("Bitiş saati, başlangıç saatinden önce olamaz!");
                    return;
                }

                double toplamFazlaMesai = HesaplaFazlaMesai(baslangic, bitis);

                string fazlaMesaiNormal = SaatDonusturme(toplamFazlaMesai);

                lblSonuc.Text = $"Toplam Fazla Mesai: {fazlaMesaiNormal} ";


                //MessageBox.Show("Fazla mesai başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtbas.Value;
                DateTime bitisTarihi = dtbit.Value;
                DateTime baslangicSaati = dtsbas.Value;
                DateTime bitisSaati = dtsbit.Value;

                string muhendis = txtmuhendis.Text;
                string yapılanIs = txtis.Text;
                string kuleAdi = txtad.Text;
                string kuleTipi = txttip.Text;

                DateTime baslangic = new DateTime(
                    baslangicTarihi.Year, baslangicTarihi.Month, baslangicTarihi.Day,
                    baslangicSaati.Hour, baslangicSaati.Minute, 0);

                DateTime bitis = new DateTime(
                    bitisTarihi.Year, bitisTarihi.Month, bitisTarihi.Day,
                    bitisSaati.Hour, bitisSaati.Minute, 0);

                if (bitis < baslangic)
                {
                    MessageBox.Show("Bitiş saati, başlangıç saatinden önce olamaz!");
                    return;
                }

                double toplamFazlaMesai = HesaplaFazlaMesai(baslangic, bitis);
                string fazlaMesaiNormal = SaatDonusturme(toplamFazlaMesai);
                TimeSpan fazlaMesaiTime = TimeSpan.Parse(fazlaMesaiNormal);

                string connectionString = "Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Hesaplamalar (KullaniciId, BaslangicTarihi, BitisTarihi, BaslangicSaati, BitisSaati, Sonuc, muhendis, yapılanIs, kuleAdi, kuleTipi) " +
                                   "VALUES (@KullaniciId, @BaslangicTarihi, @BitisTarihi, @BaslangicSaati, @BitisSaati, @Sonuc, @muhendis, @yapılanIs, @kuleAdi, @kuleTipi)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                        cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangic);
                        cmd.Parameters.AddWithValue("@BitisTarihi", bitis);
                        cmd.Parameters.AddWithValue("@BaslangicSaati", baslangicSaati.TimeOfDay);
                        cmd.Parameters.AddWithValue("@BitisSaati", bitisSaati.TimeOfDay);
                        cmd.Parameters.AddWithValue("@Sonuc", fazlaMesaiNormal);
                        cmd.Parameters.AddWithValue("@muhendis", muhendis);
                        cmd.Parameters.AddWithValue("@yapılanIs", yapılanIs);
                        cmd.Parameters.AddWithValue("@kuleAdi", kuleAdi);
                        cmd.Parameters.AddWithValue("@kuleTipi", kuleTipi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Fazla mesai başarıyla kaydedildi.");
                txtmuhendis.Text = "";
                txtad.Text = "";
                txtis.Text = "";
                txttip.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            LoadData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool isAnyChecked = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["secim"].Value != null && (bool)row.Cells["secim"].Value)
                {
                    isAnyChecked = true;
                    break;
                }
            }
            if (!isAnyChecked)
            {
                MessageBox.Show("Lütfen silmek için en az bir kayıt seçin.");
                return;
            }
            DialogResult result = MessageBox.Show("Seçilen kayıtları silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;"))
                    {
                        con.Open();
                        string query = "DELETE FROM Hesaplamalar WHERE HesaplamaId = @HesaplamaId AND KullaniciId = @KullaniciId";

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["secim"].Value != null && (bool)row.Cells["secim"].Value)
                            {
                                int hesaplamaId = Convert.ToInt32(row.Cells["HesaplamaId"].Value);

                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.Parameters.AddWithValue("@HesaplamaId", hesaplamaId);
                                    cmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    MessageBox.Show("Seçilen kayıtlar başarıyla silindi.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
        }




        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                string connectionString = "Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT HesaplamaId, BaslangicTarihi, BitisTarihi, BaslangicSaati, BitisSaati, Sonuc, muhendis, yapılanIs, kuleAdi,kuleTipi,guncel FROM Hesaplamalar WHERE KullaniciId = @KullaniciId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();

                            if (dataGridView1.Columns.Count == 0)
                            {

                                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                                checkBoxColumn.HeaderText = "Seç";
                                checkBoxColumn.Name = "secim";
                                checkBoxColumn.Width = 30;
                                checkBoxColumn.ReadOnly = false;
                                dataGridView1.Columns.Insert(0, checkBoxColumn);
                                DataGridViewTextBoxColumn guncelColumn = new DataGridViewTextBoxColumn();
                                guncelColumn.HeaderText = "Güncellenme Durumu";
                                guncelColumn.Name = "guncel";
                                guncelColumn.ReadOnly = true;
                                dataGridView1.Columns.Add(guncelColumn);
                              //  dataGridView1.Columns.Add("HesaplamaId", "Hesaplama ID");
                                dataGridView1.Columns.Add("BaslangicTarihi", "Başlangıç Tarihi");
                                dataGridView1.Columns.Add("BitisTarihi", "Bitiş Tarihi");
                                dataGridView1.Columns.Add("BaslangicSaati", "Başlangıç Saati");
                                dataGridView1.Columns.Add("BitisSaati", "Bitiş Saati");
                                dataGridView1.Columns.Add("Sonuc", "Fazla Mesai Süresi");
                                dataGridView1.Columns.Add("muhendis", "Mühendis");
                                dataGridView1.Columns.Add("yapılanIs", "Yapılan İş");
                                dataGridView1.Columns.Add("kuleAdi", "Kule Adı");
                                dataGridView1.Columns.Add("kuleTipi", "Kule Tipi");
                            }

                            while (dr.Read())
                            {
                                dataGridView1.Rows.Add(
                                    false,
                                    dr["guncel"],
                                   // dr["HesaplamaId"],
                                    Convert.ToDateTime(dr["BaslangicTarihi"]).ToString("dd.MM.yyyy"),
                                    Convert.ToDateTime(dr["BitisTarihi"]).ToString("dd.MM.yyyy"),
                                    TimeSpan.Parse(dr["BaslangicSaati"].ToString()).ToString(@"hh\:mm"),
                                    TimeSpan.Parse(dr["BitisSaati"].ToString()).ToString(@"hh\:mm"),
                                    dr["Sonuc"],
                                    dr["muhendis"],
                                    dr["yapılanIs"],
                                    dr["kuleAdi"],
                                    dr["kuleTipi"]

                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}");
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtmuhendis.Text = selectedRow.Cells["muhendis"].Value.ToString();
                txtis.Text = selectedRow.Cells["yapılanIs"].Value.ToString();
                txtad.Text = selectedRow.Cells["kuleAdi"].Value.ToString();
                txttip.Text = selectedRow.Cells["kuleTipi"].Value.ToString();
                secimHesaplamaId = Convert.ToInt32(selectedRow.Cells["HesaplamaId"].Value);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["secim"].Value = isChecked;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string muhendis = txtmuhendis.Text;
                string yapılanIs = txtis.Text;
                string kuleAdi = txtad.Text;
                string kuleTipi = txttip.Text;

                if (secimHesaplamaId <= 0)
                {
                    MessageBox.Show("Güncellemek için bir kayıt seçin.");
                    return;
                }

                string connectionString = "Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "update Hesaplamalar set muhendis = @muhendis, yapılanIs = @yapılanIs, kuleAdi = @kuleAdi, kuleTipi = @kuleTipi, guncel = '*' WHERE HesaplamaId = @HesaplamaId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@muhendis", muhendis);
                        cmd.Parameters.AddWithValue("@yapılanIs", yapılanIs);
                        cmd.Parameters.AddWithValue("@kuleAdi", kuleAdi);
                        cmd.Parameters.AddWithValue("@kuleTipi", kuleTipi);
                        cmd.Parameters.AddWithValue("@HesaplamaId", secimHesaplamaId);

                        cmd.ExecuteNonQuery(); 
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["HesaplamaId"].Value) == secimHesaplamaId)
                    {
                        row.Cells["guncel"].Value = "*"; 
                        row.Cells["muhendis"].Value = muhendis; 
                        row.Cells["yapılanIs"].Value = yapılanIs;
                        row.Cells["kuleAdi"].Value = kuleAdi;
                        row.Cells["kuleTipi"].Value = kuleTipi;
                        break;
                    }
                }

                MessageBox.Show("Kayıt başarıyla güncellendi.");
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}






































//try
//{
//    // Önce seçilen kaydın idsini al
//    if (dataGridView1.SelectedRows.Count > 0) // satır seçilmişse
//    {
//        int hesaplamaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["HesaplamaId"].Value);

//        DateTime baslangicTarihi = dtbas.Value;
//        DateTime bitisTarihi = dtbit.Value;
//        DateTime baslangicSaati = dtsbas.Value;
//        DateTime bitisSaati = dtsbit.Value;

//        DateTime baslangic = new DateTime(
//            baslangicTarihi.Year, baslangicTarihi.Month, baslangicTarihi.Day,
//            baslangicSaati.Hour, baslangicSaati.Minute, 0);

//        DateTime bitis = new DateTime(
//            bitisTarihi.Year, bitisTarihi.Month, bitisTarihi.Day,
//            bitisSaati.Hour, bitisSaati.Minute, 0);

//        if (bitis < baslangic)
//        {
//            MessageBox.Show("Bitiş saati, başlangıç saatinden önce olamaz!");
//            return;
//        }

//        double toplamFazlaMesai = HesaplaFazlaMesai(baslangic, bitis);

//        using (SqlConnection conn = new SqlConnection("Server=LAPTOP-B8MFA7LK;Database=mesai;TrustServerCertificate=True;Integrated Security=True;"))
//        {
//            conn.Open();

//            string query = @"
//    UPDATE Hesaplamalar 
//    SET BaslangicTarihi = @BaslangicTarihi, 
//        BitisTarihi = @BitisTarihi, 
//        BaslangicSaati = @BaslangicSaati, 
//        BitisSaati = @BitisSaati, 
//        Sonuc = @Sonuc 
//    WHERE HesaplamaId = @HesaplamaId";

//            using (SqlCommand cmd = new SqlCommand(query, conn))
//            {
//                cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangic);
//                cmd.Parameters.AddWithValue("@BitisTarihi", bitis);
//                cmd.Parameters.AddWithValue("@BaslangicSaati", baslangic.TimeOfDay);
//                cmd.Parameters.AddWithValue("@BitisSaati", bitis.TimeOfDay);
//                cmd.Parameters.AddWithValue("@Sonuc", toplamFazlaMesai);
//                cmd.Parameters.AddWithValue("@HesaplamaId", hesaplamaId); // Hesaplama ID'sini güncelliyoruz

//                cmd.ExecuteNonQuery();
//            }

//            MessageBox.Show("Kayıt başarıyla güncellendi.");
//        }
//    }
//    else
//    {
//        MessageBox.Show("Lütfen düzenlemek için bir kayıt seçin.");
//    }
//}
//catch (Exception ex)
//{
//    MessageBox.Show("Bir hata oluştu: " + ex.Message);
//}
//LoadData();