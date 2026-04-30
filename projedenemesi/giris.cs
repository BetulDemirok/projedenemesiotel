using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace projedenemesi

{


    public partial class giris : Form
    {

        public static string girisYapanIsim = "";
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;
        public Form geriDonulecekForm;

        public giris(Form cagiranForm = null)
        {
            InitializeComponent();
            geriDonulecekForm = cagiranForm;
        }

        public giris()
        {
            InitializeComponent();
            YazilariHazirla();
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void YazilariHazirla()
        {
            
            SendMessage(txtAd.Handle, EM_SETCUEBANNER, 0, "Adınız");
            SendMessage(txtSoyad.Handle, EM_SETCUEBANNER, 0, "Soyadınız");
            SendMessage(txtEposta.Handle, EM_SETCUEBANNER, 0, "E-posta Adresiniz");
            SendMessage(txtKullaniciAdi.Handle, EM_SETCUEBANNER, 0, "Kullanıcı Adı Belirleyin");
            SendMessage(txtTelefon.Handle, EM_SETCUEBANNER, 0, "Telefon Numaranız");
            SendMessage(txtSifre.Handle, EM_SETCUEBANNER, 0, "Şifre");
            SendMessage(txtSifreTekrar.Handle, EM_SETCUEBANNER, 0, "Şifre Tekrar");



           
            txtSifre.UseSystemPasswordChar = false;
            txtSifreTekrar.UseSystemPasswordChar = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;

            kayit.BringToFront();
            pnlgiris.Visible = false;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını boş bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=OtelDB;Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                
                string sorgu = "SELECT Ad FROM OtelKullanicilari WHERE KullaniciAdi=@kadi AND Sifre=@sifre";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kadi", textBox4.Text.Trim());
                komut.Parameters.AddWithValue("@sifre", textBox5.Text);

                try
                {
                    baglanti.Open();
                    object sonuc = komut.ExecuteScalar();

                    if (sonuc != null) 
                    {
                        girisYapanIsim = sonuc.ToString();
                        MessageBox.Show($"Giriş Başarılı! Hoş geldiniz, {girisYapanIsim}", "Lumina Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (geriDonulecekForm != null)
                        {
                         
                            geriDonulecekForm.Show();
                            this.Close(); 
                        }
                        else
                        {
                            Form1 anaSayfa = new Form1();
                            anaSayfa.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                txtSifre.UseSystemPasswordChar = txtSifre.Text.Length > 0;
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                txtSifreTekrar.UseSystemPasswordChar = txtSifreTekrar.Text.Length > 0;
            }

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (txtAd.Text.Contains(" ") || txtSoyad.Text.Contains(" ") || txtEposta.Text.Contains(" ") ||
                txtKullaniciAdi.Text.Contains(" ") || txtTelefon.Text.Contains(" ") || txtSifre.Text.Contains(" "))
            {
                MessageBox.Show("Alanlar boşluk karakteri içeremez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (txtAd.Text.Length < 3 || txtSoyad.Text.Length < 3)
            {
                MessageBox.Show("İsim ve soyisim en az 3 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtAd.Text.Any(char.IsDigit) || txtSoyad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("İsim ve soyisim rakam içeremez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtEposta.Text.Contains("@"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz (@ işareti bulunmalı)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (txtKullaniciAdi.Text.Length < 3)
            {
                MessageBox.Show("Kullanıcı adı en az 3 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       
            if (txtTelefon.Text.Length != 10 || !txtTelefon.Text.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası tam 10 haneli ve sadece rakamlardan oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtSifre.Text.Length < 3)
            {
                MessageBox.Show("Şifre en az 3 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool hasDigit = txtSifre.Text.Any(char.IsDigit);
            bool hasSymbol = txtSifre.Text.Any(char.IsPunctuation) || txtSifre.Text.Any(char.IsSymbol);

            if (!hasDigit || !hasSymbol)
            {
                MessageBox.Show("Şifre en az bir rakam ve bir simge içermelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=.; Initial Catalog=OtelDB; Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO OtelKullanicilari (Ad, Soyad, Eposta, Telefon, KullaniciAdi, Sifre) " +
                                   "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", txtAd.Text.Trim());
                        komut.Parameters.AddWithValue("@p2", txtSoyad.Text.Trim());
                        komut.Parameters.AddWithValue("@p3", txtEposta.Text.Trim());
                        komut.Parameters.AddWithValue("@p4", txtTelefon.Text.Trim());
                        komut.Parameters.AddWithValue("@p5", txtKullaniciAdi.Text.Trim());
                        komut.Parameters.AddWithValue("@p6", txtSifre.Text);

                        komut.ExecuteNonQuery(); 
                    }

                    MessageBox.Show($"Sayın {txtAd.Text} {txtSoyad.Text}, kaydınız oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    TemizleVeDon();
                }
                catch (SqlException ex)
                {
                    
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten sistemde kayıtlı! Lütfen başka bir isim seçin.", "Kullanıcı Adı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("SQL Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void TemizleVeDon()
        {
           
            foreach (Control c in kayit.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    c.Text = string.Empty;
                }
            }

            kayit.Visible = false;
            pnlgiris.Visible = true;
        }
       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            bool sifreGoster = checkBox3.Checked;

            if (sifreGoster)
                txtSifre.UseSystemPasswordChar = false;
            else
               
                txtSifre.UseSystemPasswordChar = txtSifre.Text.Length > 0;

        
            if (sifreGoster)
                txtSifreTekrar.UseSystemPasswordChar = false;
            else
                txtSifreTekrar.UseSystemPasswordChar = txtSifreTekrar.Text.Length > 0;
        }
    }
}