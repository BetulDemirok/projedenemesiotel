namespace projedenemesi
{
    partial class giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            pnlgiris = new Panel();
            button3 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            checkBox1 = new CheckBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            checkBox2 = new CheckBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            kayit = new Panel();
            checkBox3 = new CheckBox();
            textBox7 = new TextBox();
            btnKayitOl = new Button();
            txtTelefon = new TextBox();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtEposta = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            pnlgiris.SuspendLayout();
            kayit.SuspendLayout();
            SuspendLayout();
            // 
            // pnlgiris
            // 
            pnlgiris.BackgroundImageLayout = ImageLayout.Stretch;
            pnlgiris.Controls.Add(button3);
            pnlgiris.Controls.Add(button2);
            pnlgiris.Controls.Add(textBox6);
            pnlgiris.Controls.Add(checkBox1);
            pnlgiris.Controls.Add(textBox5);
            pnlgiris.Controls.Add(textBox4);
            pnlgiris.Controls.Add(checkBox2);
            pnlgiris.Controls.Add(textBox3);
            pnlgiris.Controls.Add(textBox2);
            pnlgiris.Controls.Add(textBox1);
            pnlgiris.Controls.Add(button1);
            pnlgiris.Location = new Point(128, 71);
            pnlgiris.Name = "pnlgiris";
            pnlgiris.Size = new Size(500, 500);
            pnlgiris.TabIndex = 0;
            pnlgiris.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(179, 293);
            button3.MaximumSize = new Size(94, 29);
            button3.MinimumSize = new Size(94, 29);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "giriş yap ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(221, 380);
            button2.MaximumSize = new Size(94, 29);
            button2.MinimumSize = new Size(94, 29);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "KAYIT OL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.MistyRose;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox6.Location = new Point(64, 385);
            textBox6.MaximumSize = new Size(151, 18);
            textBox6.MinimumSize = new Size(151, 18);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 18);
            textBox6.TabIndex = 10;
            textBox6.Text = "eğer üyeliğiniz yoksa";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(269, 263);
            checkBox1.MaximumSize = new Size(116, 24);
            checkBox1.MinimumSize = new Size(116, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "şifreyi göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(64, 230);
            textBox5.MaximumSize = new Size(321, 27);
            textBox5.MinimumSize = new Size(321, 27);
            textBox5.Name = "textBox5";
            textBox5.RightToLeft = RightToLeft.No;
            textBox5.Size = new Size(321, 27);
            textBox5.TabIndex = 7;
            textBox5.UseSystemPasswordChar = true;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 141);
            textBox4.MaximumSize = new Size(321, 27);
            textBox4.MinimumSize = new Size(321, 27);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(321, 27);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(64, 263);
            checkBox2.MaximumSize = new Size(109, 24);
            checkBox2.MinimumSize = new Size(109, 24);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(109, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Beni Hatırla";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MistyRose;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(169, 17);
            textBox3.MaximumSize = new Size(193, 23);
            textBox3.MinimumSize = new Size(193, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "GİRİŞ EKRANI";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(64, 206);
            textBox2.MaximumSize = new Size(125, 18);
            textBox2.MinimumSize = new Size(125, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 18);
            textBox2.TabIndex = 2;
            textBox2.Text = "ŞİFRE";
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(64, 117);
            textBox1.MaximumSize = new Size(164, 18);
            textBox1.MinimumSize = new Size(164, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 18);
            textBox1.TabIndex = 1;
            textBox1.Text = "KULLANICI ADI";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(314, 53);
            button1.MaximumSize = new Size(164, 27);
            button1.MinimumSize = new Size(164, 27);
            button1.Name = "button1";
            button1.Size = new Size(164, 27);
            button1.TabIndex = 0;
            button1.Text = "ANASAYFA 🏠";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kayit
            // 
            kayit.Controls.Add(checkBox3);
            kayit.Controls.Add(textBox7);
            kayit.Controls.Add(btnKayitOl);
            kayit.Controls.Add(txtTelefon);
            kayit.Controls.Add(txtSifreTekrar);
            kayit.Controls.Add(txtSifre);
            kayit.Controls.Add(txtKullaniciAdi);
            kayit.Controls.Add(txtEposta);
            kayit.Controls.Add(txtSoyad);
            kayit.Controls.Add(txtAd);
            kayit.Location = new Point(128, 71);
            kayit.Name = "kayit";
            kayit.Size = new Size(500, 500);
            kayit.TabIndex = 1;
            kayit.Paint += kayit_Paint;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox3.Location = new Point(179, 316);
            checkBox3.MaximumSize = new Size(102, 22);
            checkBox3.MinimumSize = new Size(102, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 22);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "şifre göster";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.MistyRose;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox7.Location = new Point(126, 15);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(254, 23);
            textBox7.TabIndex = 0;
            textBox7.Text = "KAYIT EKRANI ";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Font = new Font("Georgia", 9F, FontStyle.Underline, GraphicsUnit.Point, 162);
            btnKayitOl.Location = new Point(187, 369);
            btnKayitOl.MaximumSize = new Size(94, 29);
            btnKayitOl.MinimumSize = new Size(94, 29);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(94, 29);
            btnKayitOl.TabIndex = 8;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelefon.Location = new Point(66, 180);
            txtTelefon.MaximumSize = new Size(215, 25);
            txtTelefon.MaxLength = 10;
            txtTelefon.MinimumSize = new Size(215, 25);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.RightToLeft = RightToLeft.No;
            txtTelefon.Size = new Size(215, 25);
            txtTelefon.TabIndex = 7;
            txtTelefon.TextAlign = HorizontalAlignment.Center;
            txtTelefon.TextChanged += textBox14_TextChanged;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifreTekrar.Location = new Point(66, 285);
            txtSifreTekrar.MaximumSize = new Size(215, 25);
            txtSifreTekrar.MinimumSize = new Size(215, 25);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.RightToLeft = RightToLeft.No;
            txtSifreTekrar.Size = new Size(215, 25);
            txtSifreTekrar.TabIndex = 6;
            txtSifreTekrar.TextAlign = HorizontalAlignment.Center;
            txtSifreTekrar.TextChanged += textBox13_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(66, 250);
            txtSifre.MaximumSize = new Size(215, 25);
            txtSifre.MaxLength = 30;
            txtSifre.MinimumSize = new Size(215, 25);
            txtSifre.Name = "txtSifre";
            txtSifre.RightToLeft = RightToLeft.No;
            txtSifre.Size = new Size(215, 25);
            txtSifre.TabIndex = 5;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.TextChanged += textBox12_TextChanged;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(66, 215);
            txtKullaniciAdi.MaximumSize = new Size(215, 25);
            txtKullaniciAdi.MaxLength = 20;
            txtKullaniciAdi.MinimumSize = new Size(215, 25);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.RightToLeft = RightToLeft.No;
            txtKullaniciAdi.Size = new Size(215, 25);
            txtKullaniciAdi.TabIndex = 4;
            txtKullaniciAdi.TextAlign = HorizontalAlignment.Center;
            txtKullaniciAdi.TextChanged += textBox11_TextChanged;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEposta.Location = new Point(66, 145);
            txtEposta.MaximumSize = new Size(215, 25);
            txtEposta.MaxLength = 30;
            txtEposta.MinimumSize = new Size(215, 25);
            txtEposta.Name = "txtEposta";
            txtEposta.RightToLeft = RightToLeft.No;
            txtEposta.Size = new Size(215, 25);
            txtEposta.TabIndex = 3;
            txtEposta.TextAlign = HorizontalAlignment.Center;
            txtEposta.TextChanged += textBox10_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(66, 110);
            txtSoyad.MaximumSize = new Size(215, 25);
            txtSoyad.MaxLength = 30;
            txtSoyad.MinimumSize = new Size(215, 25);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.RightToLeft = RightToLeft.No;
            txtSoyad.Size = new Size(215, 25);
            txtSoyad.TabIndex = 2;
            txtSoyad.TextAlign = HorizontalAlignment.Center;
            txtSoyad.TextChanged += textBox9_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(66, 75);
            txtAd.MaximumSize = new Size(215, 25);
            txtAd.MaxLength = 30;
            txtAd.MinimumSize = new Size(215, 25);
            txtAd.Name = "txtAd";
            txtAd.RightToLeft = RightToLeft.No;
            txtAd.Size = new Size(215, 25);
            txtAd.TabIndex = 1;
            txtAd.TextAlign = HorizontalAlignment.Center;
            txtAd.TextChanged += textBox8_TextChanged;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MistyRose;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 450);
            Controls.Add(pnlgiris);
            Controls.Add(kayit);
            Name = "giris";
            RightToLeft = RightToLeft.Yes;
            Text = "giris";
            Load += giris_Load;
            pnlgiris.ResumeLayout(false);
            pnlgiris.PerformLayout();
            kayit.ResumeLayout(false);
            kayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlgiris;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Button button2;
        private TextBox textBox6;
        private Panel kayit;
        private TextBox textBox7;
        private Button button3;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtEposta;
        private TextBox txtSoyad;
        private Button btnKayitOl;
        private CheckBox checkBox3;
    }
}