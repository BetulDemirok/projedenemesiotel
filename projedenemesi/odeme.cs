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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projedenemesi
{
    public partial class odeme : Form
    {
        long gelenTutar;
        DateTime gelenGiris, gelenCikis;
        int sAdet, aAdet, suAdet, kAdet;

        
        public odeme(long tutar, DateTime girisTarihi, DateTime cikisTarihi, int standart, int aile, int suit, int kral)
        {
            InitializeComponent();

         
            gelenTutar = tutar;
            gelenGiris = girisTarihi; 
            gelenCikis = cikisTarihi;
            sAdet = standart;
            aAdet = aile;
            suAdet = suit;
            kAdet = kral;
        }
        private void odeme_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void odeme_Load(object sender, EventArgs e)
        {
            tutar.Text = gelenTutar.ToString("N0") + " ₺";
            comboBox1.Items.Clear(); 
            comboBox1.DrawMode = DrawMode.Normal; 

           
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i.ToString("D2"));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKartSahibi.Text))
            {
                MessageBox.Show("Kart sahibi adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (txtKartNo.Text.Length != 16)
            {
                MessageBox.Show("Kart numarası 16 hane olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen son kullanma ayını seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtYil.Text.Length != 4)
            {
                MessageBox.Show("Yıl 4 haneli olmalıdır! (Örn: 2026)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (txtCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV 3 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KaydetVeEksilt();

            MessageBox.Show("Rezervasyonunuz başarıyla oluşturuldu!");
        }
        private void KaydetVeEksilt()
        {
            string connStr = "Data Source=.;Initial Catalog=OtelDB;Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connStr))
            {
                baglanti.Open();

              
                if (sAdet > 0) RezervasyonKaydiAt(baglanti, "Standart", sAdet);
                if (aAdet > 0) RezervasyonKaydiAt(baglanti, "Aile", aAdet);
                if (suAdet > 0) RezervasyonKaydiAt(baglanti, "Suit", suAdet);
                if (kAdet > 0) RezervasyonKaydiAt(baglanti, "Kral", kAdet);

                MessageBox.Show("Rezervasyonunuz onaylandı ve odanız ayrıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void tutar_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void RezervasyonKaydiAt(SqlConnection bag, string odaTipi, int adet)
        {
            string sorgu = "INSERT INTO Rezervasyonlar (KullaniciAd, OdaTipi, GirisTarihi, CikisTarihi, OdaAdedi) " +
                   "VALUES (@ad, @tip, @giris, @cikis, @adet)";

            SqlCommand komut = new SqlCommand(sorgu, bag);
            komut.Parameters.AddWithValue("@ad", giris.girisYapanIsim);
            komut.Parameters.AddWithValue("@tip", odaTipi);
            komut.Parameters.AddWithValue("@giris", gelenGiris);
            komut.Parameters.AddWithValue("@cikis", gelenCikis);
            komut.Parameters.AddWithValue("@adet", adet);

            komut.ExecuteNonQuery();
        }


    }
}