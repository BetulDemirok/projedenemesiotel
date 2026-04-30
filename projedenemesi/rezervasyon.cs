using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projedenemesi
{
    public partial class rezervasyon : Form
    {
        long genelToplam = 0;
        public rezervasyon()
        {
            InitializeComponent();

        }
        private void rezervasyon_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void rezervasyon_Load(object sender, EventArgs e)
        {
            txtMisafirAdi.Text = "👤" + giris.girisYapanIsim;
            monthCalendar1.MinDate = DateTime.Now;
            btnGiris.Text = "Giriş: " + DateTime.Now.ToShortDateString();
            btnCikis.Text = "Çıkış: " + DateTime.Now.ToShortDateString();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Fiyat: Artan");
            comboBox1.Items.Add("Fiyat: Azalan");



            comboBox1.SelectedIndex = 0;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();


            anaSayfa.Show();


            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));
            odeme odemeSayfasi = new odeme(genelToplam, gTarihi, cTarihi, secilenStandartOda, secilenAileOda, secilenSuitOda, secilenKralOda);
            odemeSayfasi.Show();
            this.Close();
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            btnGiris.Text = "Giriş: " + e.Start.ToShortDateString();
            btnCikis.Text = "Çıkış: " + e.End.ToShortDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;


            if (panel1.Visible)
            {
                panel1.BringToFront();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int odaSayisi = 1;
        int yetiskinSayisi = 1;
        int cocukSayisi = 0;
        int secilenStandartOda = 0;
        int secilenAileOda = 0;
        int secilenSuitOda = 0;
        int secilenKralOda = 0;


        private void VerileriGuncelle()
        {
            lblOdaSayisi.Text = odaSayisi.ToString();
            lblYetiskinSayisi.Text = yetiskinSayisi.ToString();
            lblCocukSayisi.Text = cocukSayisi.ToString();

            int toplamMisafir = yetiskinSayisi + cocukSayisi;


            btnSecimPaneli.Text = $"{odaSayisi} ODA, {toplamMisafir} MİSAFİR";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pnlSecimEkrani.Visible = !pnlSecimEkrani.Visible;
            pnlSecimEkrani.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (odaSayisi < 9) { odaSayisi++; VerileriGuncelle(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (odaSayisi > 1) { odaSayisi--; VerileriGuncelle(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (yetiskinSayisi < 20) { yetiskinSayisi++; VerileriGuncelle(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (yetiskinSayisi > 1) { yetiskinSayisi--; VerileriGuncelle(); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cocukSayisi < 10) { cocukSayisi++; VerileriGuncelle(); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cocukSayisi > 0) { cocukSayisi--; VerileriGuncelle(); }
        }
        private void btnSecimPaneli_Click(object sender, EventArgs e)
        {
            pnlSecimEkrani.Visible = !pnlSecimEkrani.Visible;
            pnlSecimEkrani.BringToFront();
        }

        private void lblOdaSayisi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCocukSayisi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private int MusaitOdaSayisiGetir(string odaTipi, DateTime giris, DateTime cikis)
        {
            int musaitAdet = 0;
            string connStr = "Data Source=.;Initial Catalog=OtelDB;Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connStr))
            {

                string sorgu = @"
            SELECT 
                (SELECT ToplamAdet FROM Odalar WHERE OdaTipi = @tip) - 
                ISNULL((SELECT SUM(OdaAdedi) FROM Rezervasyonlar 
                        WHERE OdaTipi = @tip 
                        AND GirisTarihi < @istenenCikis 
                        AND CikisTarihi > @istenenGiris), 0)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tip", odaTipi);
                komut.Parameters.AddWithValue("@istenenGiris", giris);
                komut.Parameters.AddWithValue("@istenenCikis", cikis);

                try
                {
                    baglanti.Open();
                    musaitAdet = Convert.ToInt32(komut.ExecuteScalar());
                }
                catch
                {
                    musaitAdet = 0;
                }
            }
            return musaitAdet;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pnlStandart.Visible || pnlKral.Visible || pnlSuit.Visible || pnlAile.Visible)
            {
                OdalariSiralaVeKonumlandir();
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {


            panel1.Visible = false;
            pnlSecimEkrani.Visible = false;

            pnlStandart.Visible = false;
            pnlKral.Visible = false;
            pnlSuit.Visible = false;
            pnlAile.Visible = false;

            int toplamMisafir = yetiskinSayisi + cocukSayisi;
            DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));


            int bosStandart = MusaitOdaSayisiGetir("Standart", gTarihi, cTarihi);
            int bosAile = MusaitOdaSayisiGetir("Aile", gTarihi, cTarihi);
            int bosSuit = MusaitOdaSayisiGetir("Suit", gTarihi, cTarihi);
            int bosKral = MusaitOdaSayisiGetir("Kral", gTarihi, cTarihi);

            // ODALARI FİLTRELEME 
            // --- STANDART ODA ---

            if (toplamMisafir <= (2 * odaSayisi) && bosStandart >= 1) ;
            {
                pnlStandart.Visible = true;
            }

            // --- SUİT ODA ---

            if ((cocukSayisi == 0 && yetiskinSayisi <= (2 * odaSayisi)) && bosSuit >= 1) ;
            {
                pnlSuit.Visible = true;
            }

            // --- AİLE ODASI ---

            if (toplamMisafir <= (4 * odaSayisi) && bosAile >= 1) ;
            {
                pnlAile.Visible = true;
            }

            // --- KRAL DAİRESİ ---

            if (yetiskinSayisi <= (3 * odaSayisi) && bosKral >= 1) ;
            {
                pnlKral.Visible = true;
            }

            //  SIRALAMA VE KONUMLANDIRMA

            OdalariSiralaVeKonumlandir();


            if (!pnlStandart.Visible && !pnlKral.Visible && !pnlSuit.Visible && !pnlAile.Visible)
            {
                MessageBox.Show("Seçtiğiniz kişi sayısına uygun oda bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OdalariSiralaVeKonumlandir()
        {
            int sabitX = 634;
            int[] olasiYKonumlari = { 522, 833, 1144, 1455 };


            List<Control> odaListesi = new List<Control>();
            if (pnlStandart.Visible) odaListesi.Add(pnlStandart);
            if (pnlAile.Visible) odaListesi.Add(pnlAile);
            if (pnlSuit.Visible) odaListesi.Add(pnlSuit);
            if (pnlKral.Visible) odaListesi.Add(pnlKral);


            if (comboBox1.Text == "Fiyat: Artan")
            {

                odaListesi = odaListesi.OrderBy(x => GetOdaFiyati(x.Name)).ToList();
            }
            else if (comboBox1.Text == "Fiyat: Azalan")
            {

                odaListesi = odaListesi.OrderByDescending(x => GetOdaFiyati(x.Name)).ToList();
            }


            for (int i = 0; i < odaListesi.Count; i++)
            {
                if (i < olasiYKonumlari.Length)
                {
                    odaListesi[i].Location = new Point(sabitX, olasiYKonumlari[i]);
                }
            }
        }

        private int GetOdaFiyati(string panelName)
        {
            if (panelName == "pnlStandart") return 1;
            if (panelName == "pnlAile") return 2;
            if (panelName == "pnlSuit") return 3;
            if (panelName == "pnlKral") return 4;
            return 0;
        }

        private void Guncelle()
        {
            lblOdaSayisi.Text = odaSayisi.ToString();
            lblYetiskinSayisi.Text = yetiskinSayisi.ToString();
            lblCocukSayisi.Text = cocukSayisi.ToString();

            int toplamMisafir = yetiskinSayisi + cocukSayisi;
            btnSecimPaneli.Text = $"{odaSayisi} ODA, {toplamMisafir} MİSAFİR";


        }
        private void btnCikis_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;


            if (panel1.Visible)
            {
                panel1.BringToFront();
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }






        private void button12_Click(object sender, EventArgs e)
        {

            DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));

            int musaitStandart = MusaitOdaSayisiGetir("Standart", gTarihi, cTarihi);
            int toplamSecilen = secilenStandartOda + secilenAileOda + secilenSuitOda + secilenKralOda;

            if (toplamSecilen < odaSayisi)
            {
                if (secilenStandartOda < musaitStandart)
                {
                    secilenStandartOda++;
                    lblStandartAdet.Text = secilenStandartOda.ToString();
                    FiyatHesapla();
                }
                else
                {
                    MessageBox.Show($"Üzgünüz, seçtiğiniz tarih aralığında 'Standart Oda' tipinden başka oda kalmadı. (Müsait: {musaitStandart})", "Kapasite Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Toplamda en fazla {odaSayisi} oda seçebilirsiniz!", "Limit Doldu");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (secilenStandartOda > 0)
            {
                secilenStandartOda--;
                lblStandartAdet.Text = secilenStandartOda.ToString();


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));

            int musaitKral = MusaitOdaSayisiGetir("Kral", gTarihi, cTarihi);
            int toplamSecilen = secilenStandartOda + secilenAileOda + secilenSuitOda + secilenKralOda;

            if (toplamSecilen < odaSayisi)
            {
                if (secilenKralOda < musaitKral)
                {
                    secilenKralOda++;
                    lblKralAdet.Text = secilenKralOda.ToString();
                    FiyatHesapla();
                }
                else
                {
                    MessageBox.Show($"Üzgünüz, seçtiğiniz tarih aralığında 'Kral Dairesi' tipinden başka oda kalmadı. (Müsait: {musaitKral})", "Kapasite Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Toplamda en fazla {odaSayisi} oda seçme hakkınız var.", "Limit Doldu");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (secilenKralOda > 0)
            {
                secilenKralOda--;
                lblKralAdet.Text = secilenKralOda.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));

            int musaitSuit = MusaitOdaSayisiGetir("Suit", gTarihi, cTarihi);
            int toplamSecilen = secilenStandartOda + secilenAileOda + secilenSuitOda + secilenKralOda;

            if (toplamSecilen < odaSayisi)
            {
                if (secilenSuitOda < musaitSuit)
                {
                    secilenSuitOda++;
                    lblSuitAdet.Text = secilenSuitOda.ToString();
                    FiyatHesapla();
                }
                else
                {
                    MessageBox.Show($"Üzgünüz, seçtiğiniz tarih aralığında 'Suit Oda' tipinden başka oda kalmadı. (Müsait: {musaitSuit})", "Kapasite Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Toplamda en fazla {odaSayisi} oda seçebilirsiniz.");
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (secilenSuitOda > 0)
            {
                secilenSuitOda--;
                lblSuitAdet.Text = secilenSuitOda.ToString();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));

            int musaitAile = MusaitOdaSayisiGetir("Aile", gTarihi, cTarihi);
            int toplamSecilen = secilenStandartOda + secilenAileOda + secilenSuitOda + secilenKralOda;

            if (toplamSecilen < odaSayisi)
            {
                if (secilenAileOda < musaitAile)
                {
                    secilenAileOda++;
                    lblAileAdet.Text = secilenAileOda.ToString();
                    FiyatHesapla();
                }
                else
                {
                    MessageBox.Show($"Üzgünüz, seçtiğiniz tarih aralığında 'Aile Odası' tipinden başka oda kalmadı. (Müsait: {musaitAile})", "Kapasite Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Toplamda en fazla {odaSayisi} oda seçebilirsiniz.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (secilenAileOda > 0)
            {
                secilenAileOda--;
                lblAileAdet.Text = secilenAileOda.ToString();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (secilenStandartOda > 0 || secilenAileOda > 0 || secilenSuitOda > 0 || secilenKralOda > 0)
            {
                panelSepetOzeti.Visible = true;
                panelSepetOzeti.BringToFront();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir oda seçiniz.");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }
        public void FiyatHesapla()
        {

            DateTime girisTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
            DateTime cikisTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));

            TimeSpan fark = cikisTarihi - girisTarihi;
            int geceSayisi = fark.Days;
            if (geceSayisi <= 0) geceSayisi = 1;


            int sY, sC, aY, aC, kY, kC, suY, suC;

            int.TryParse(txtStandartYetiskin.Text, out sY);
            int.TryParse(txtStandartCocuk.Text, out sC);
            int.TryParse(txtAileYetiskin.Text, out aY);
            int.TryParse(txtAileCocuk.Text, out aC);
            int.TryParse(txtKralYetiskin.Text, out kY);
            int.TryParse(txtKralCocuk.Text, out kC);
            int.TryParse(txtSuitYetiskin.Text, out suY);



            int panelToplamYetiskin = sY + aY + kY + suY;
            int panelToplamCocuk = sC + aC + kC;


            if (panelToplamYetiskin == yetiskinSayisi && panelToplamCocuk == cocukSayisi)
            {

                button2.Enabled = true;
            }
            else
            {

                button2.Enabled = false;
            }


            long gunlukTutar = (sY * 5000) + (sC * 2500) +
                     (aY * 7000) + (aC * 3500) +
                     (kY * 20000) + (kC * 10000) +
                     (suY * 8000);

            genelToplam = gunlukTutar * geceSayisi;


            lblToplamFiyat.Text = $"TOPLAM ({geceSayisi} Gece): " + genelToplam.ToString("N0") + " ₺";
        }

        private void lblToplamFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giris.girisYapanIsim))
            {
                MessageBox.Show("Ödeme işlemine devam edebilmek için lütfen önce giriş yapınız.", "Giriş Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                giris girisFormu = new giris(this);
                girisFormu.Show();

                this.Hide();
            }
            else
            {
                DateTime gTarihi = DateTime.Parse(btnGiris.Text.Replace("Giriş: ", ""));
                DateTime cTarihi = DateTime.Parse(btnCikis.Text.Replace("Çıkış: ", ""));

                odeme odemeformu = new odeme(genelToplam, gTarihi, cTarihi, secilenStandartOda, secilenAileOda, secilenSuitOda, secilenKralOda);
                odemeformu.Show();
                this.Close();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

      
    }

}