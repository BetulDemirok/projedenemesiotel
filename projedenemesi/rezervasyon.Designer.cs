namespace projedenemesi
{
    partial class rezervasyon
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezervasyon));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            monthCalendar1 = new MonthCalendar();
            btnGiris = new Button();
            btnCikis = new Button();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtMisafirAdi = new TextBox();
            button3 = new Button();
            btnSecimPaneli = new Button();
            label1 = new Label();
            pnlSecimEkrani = new Panel();
            label6 = new Label();
            lblCocukSayisi = new Label();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            label5 = new Label();
            lblYetiskinSayisi = new Label();
            label3 = new Label();
            lblOdaSayisi = new Label();
            button6 = new Button();
            button5 = new Button();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            odaara = new Button();
            pnlStandart = new Panel();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            lblStandartAdet = new Label();
            button12 = new Button();
            button11 = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pnlKral = new Panel();
            textBox7 = new TextBox();
            lblKralAdet = new Label();
            button14 = new Button();
            button13 = new Button();
            textBox2 = new TextBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            pnlSuit = new Panel();
            textBox9 = new TextBox();
            lblSuitAdet = new Label();
            button16 = new Button();
            button15 = new Button();
            textBox3 = new TextBox();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            pnlAile = new Panel();
            textBox10 = new TextBox();
            lblAileAdet = new Label();
            button18 = new Button();
            button17 = new Button();
            textBox4 = new TextBox();
            label13 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            label14 = new Label();
            txtStandartYetiskin = new TextBox();
            txtStandartCocuk = new TextBox();
            txtKralYetiskin = new TextBox();
            txtKralCocuk = new TextBox();
            lblToplamFiyat = new TextBox();
            label17 = new Label();
            button2 = new Button();
            panelSepetOzeti = new Panel();
            txtAileCocuk = new TextBox();
            txtAileYetiskin = new TextBox();
            txtSuitYetiskin = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label19 = new Label();
            label18 = new Label();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlSecimEkrani.SuspendLayout();
            pnlStandart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlKral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlSuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlAile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelSepetOzeti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 24);
            pictureBox1.MaximumSize = new Size(581, 361);
            pictureBox1.MinimumSize = new Size(581, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(634, 54);
            button1.Name = "button1";
            button1.Size = new Size(219, 27);
            button1.TabIndex = 2;
            button1.Text = "ANASAYFA 🏠";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(72, 8);
            monthCalendar1.Margin = new Padding(10, 8, 10, 8);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(634, 252);
            btnGiris.MaximumSize = new Size(219, 27);
            btnGiris.MinimumSize = new Size(219, 27);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(219, 27);
            btnGiris.TabIndex = 5;
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += button3_Click;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCikis.Location = new Point(858, 252);
            btnCikis.MaximumSize = new Size(219, 27);
            btnCikis.MinimumSize = new Size(219, 27);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(219, 27);
            btnCikis.TabIndex = 6;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(monthCalendar1);
            panel1.Location = new Point(634, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 232);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtMisafirAdi
            // 
            txtMisafirAdi.BackColor = Color.MistyRose;
            txtMisafirAdi.BorderStyle = BorderStyle.None;
            txtMisafirAdi.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMisafirAdi.Location = new Point(1466, 45);
            txtMisafirAdi.Name = "txtMisafirAdi";
            txtMisafirAdi.Size = new Size(296, 31);
            txtMisafirAdi.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Location = new Point(1609, 361);
            button3.Name = "button3";
            button3.Size = new Size(153, 27);
            button3.TabIndex = 10;
            button3.Text = "SEPETE EKLE \U0001f6d2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // btnSecimPaneli
            // 
            btnSecimPaneli.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSecimPaneli.Location = new Point(1094, 253);
            btnSecimPaneli.Name = "btnSecimPaneli";
            btnSecimPaneli.Size = new Size(443, 26);
            btnSecimPaneli.TabIndex = 11;
            btnSecimPaneli.Text = "1 ODA, 1 MİSAFİR";
            btnSecimPaneli.UseVisualStyleBackColor = true;
            btnSecimPaneli.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 12;
            label1.Text = "ODALAR";
            label1.Click += label1_Click;
            // 
            // pnlSecimEkrani
            // 
            pnlSecimEkrani.Controls.Add(label6);
            pnlSecimEkrani.Controls.Add(lblCocukSayisi);
            pnlSecimEkrani.Controls.Add(button10);
            pnlSecimEkrani.Controls.Add(button9);
            pnlSecimEkrani.Controls.Add(button8);
            pnlSecimEkrani.Controls.Add(button7);
            pnlSecimEkrani.Controls.Add(label5);
            pnlSecimEkrani.Controls.Add(lblYetiskinSayisi);
            pnlSecimEkrani.Controls.Add(label3);
            pnlSecimEkrani.Controls.Add(lblOdaSayisi);
            pnlSecimEkrani.Controls.Add(button6);
            pnlSecimEkrani.Controls.Add(button5);
            pnlSecimEkrani.Controls.Add(label1);
            pnlSecimEkrani.Location = new Point(1094, 284);
            pnlSecimEkrani.MaximumSize = new Size(443, 232);
            pnlSecimEkrani.MinimumSize = new Size(443, 232);
            pnlSecimEkrani.Name = "pnlSecimEkrani";
            pnlSecimEkrani.Size = new Size(443, 232);
            pnlSecimEkrani.TabIndex = 13;
            pnlSecimEkrani.Visible = false;
            pnlSecimEkrani.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(75, 168);
            label6.Name = "label6";
            label6.Size = new Size(174, 16);
            label6.TabIndex = 16;
            label6.Text = "(13 yaşından küçükler için)";
            label6.Click += label6_Click;
            // 
            // lblCocukSayisi
            // 
            lblCocukSayisi.AutoSize = true;
            lblCocukSayisi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCocukSayisi.Location = new Point(295, 134);
            lblCocukSayisi.Name = "lblCocukSayisi";
            lblCocukSayisi.Size = new Size(26, 31);
            lblCocukSayisi.TabIndex = 18;
            lblCocukSayisi.Text = "0";
            lblCocukSayisi.Click += lblCocukSayisi_Click;
            // 
            // button10
            // 
            button10.Location = new Point(367, 134);
            button10.Name = "button10";
            button10.Size = new Size(39, 32);
            button10.TabIndex = 22;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(205, 134);
            button9.Name = "button9";
            button9.Size = new Size(39, 32);
            button9.TabIndex = 21;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(367, 79);
            button8.Name = "button8";
            button8.Size = new Size(39, 32);
            button8.TabIndex = 20;
            button8.Text = "+";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(205, 79);
            button7.Name = "button7";
            button7.Size = new Size(39, 32);
            button7.TabIndex = 19;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(128, 141);
            label5.Name = "label5";
            label5.Size = new Size(62, 18);
            label5.TabIndex = 17;
            label5.Text = "ÇOCUK";
            label5.Click += label5_Click;
            // 
            // lblYetiskinSayisi
            // 
            lblYetiskinSayisi.AutoSize = true;
            lblYetiskinSayisi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYetiskinSayisi.Location = new Point(295, 77);
            lblYetiskinSayisi.Name = "lblYetiskinSayisi";
            lblYetiskinSayisi.Size = new Size(26, 31);
            lblYetiskinSayisi.TabIndex = 16;
            lblYetiskinSayisi.Text = "1";
            lblYetiskinSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(106, 86);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 15;
            label3.Text = "YETİŞKİN";
            label3.Click += label3_Click;
            // 
            // lblOdaSayisi
            // 
            lblOdaSayisi.AutoSize = true;
            lblOdaSayisi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOdaSayisi.Location = new Point(295, 22);
            lblOdaSayisi.Name = "lblOdaSayisi";
            lblOdaSayisi.Size = new Size(26, 31);
            lblOdaSayisi.TabIndex = 14;
            lblOdaSayisi.Text = "1";
            lblOdaSayisi.Click += lblOdaSayisi_Click;
            // 
            // button6
            // 
            button6.Location = new Point(367, 21);
            button6.MaximumSize = new Size(39, 32);
            button6.MinimumSize = new Size(39, 32);
            button6.Name = "button6";
            button6.Size = new Size(39, 32);
            button6.TabIndex = 13;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(205, 19);
            button5.MaximumSize = new Size(39, 32);
            button5.MinimumSize = new Size(39, 32);
            button5.Name = "button5";
            button5.Size = new Size(39, 32);
            button5.TabIndex = 0;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(2, 24);
            label2.Name = "label2";
            label2.Size = new Size(185, 48);
            label2.TabIndex = 14;
            label2.Text = "LUMİNA";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(156, 48);
            label4.TabIndex = 15;
            label4.Text = "HOTEL";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1543, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 26);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // odaara
            // 
            odaara.BackColor = Color.MistyRose;
            odaara.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            odaara.Location = new Point(1609, 312);
            odaara.Name = "odaara";
            odaara.Size = new Size(153, 27);
            odaara.TabIndex = 17;
            odaara.Text = "ODA ARA";
            odaara.UseVisualStyleBackColor = false;
            odaara.Click += button4_Click_1;
            // 
            // pnlStandart
            // 
            pnlStandart.BackColor = Color.Snow;
            pnlStandart.Controls.Add(textBox8);
            pnlStandart.Controls.Add(textBox5);
            pnlStandart.Controls.Add(lblStandartAdet);
            pnlStandart.Controls.Add(button12);
            pnlStandart.Controls.Add(button11);
            pnlStandart.Controls.Add(textBox1);
            pnlStandart.Controls.Add(label7);
            pnlStandart.Controls.Add(pictureBox2);
            pnlStandart.Location = new Point(634, 522);
            pnlStandart.Name = "pnlStandart";
            pnlStandart.Size = new Size(903, 305);
            pnlStandart.TabIndex = 18;
            pnlStandart.Visible = false;
            pnlStandart.Paint += panel2_Paint_1;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Snow;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(682, 178);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(220, 53);
            textBox8.TabIndex = 40;
            textBox8.Text = "Kişi başı:5000₺\r\nİndirimli çocuk fiyatı:2500₺";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Snow;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(682, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 18);
            textBox5.TabIndex = 38;
            // 
            // lblStandartAdet
            // 
            lblStandartAdet.AutoSize = true;
            lblStandartAdet.Font = new Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblStandartAdet.Location = new Point(719, 227);
            lblStandartAdet.Name = "lblStandartAdet";
            lblStandartAdet.Size = new Size(38, 39);
            lblStandartAdet.TabIndex = 25;
            lblStandartAdet.Text = "0";
            lblStandartAdet.Click += label8_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.MistyRose;
            button12.Location = new Point(763, 237);
            button12.Name = "button12";
            button12.Size = new Size(30, 30);
            button12.TabIndex = 24;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.MistyRose;
            button11.Location = new Point(683, 236);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 23;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(578, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 121);
            textBox1.TabIndex = 21;
            textBox1.Text = "Ücretsiz yüksek hızlı Wi-Fi, ücretsiz açık büfe kahvaltı, balkon, buzdolabı, mini bar, klima, küvet/duş, kahve/çay makinesi, saç kurutma makinesi, çalar saat, çalışma masası, TV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 15);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 20;
            label7.Text = "STANDART";
            label7.Click += label7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(559, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnlKral
            // 
            pnlKral.Anchor = AnchorStyles.Top;
            pnlKral.BackColor = Color.Snow;
            pnlKral.Controls.Add(textBox7);
            pnlKral.Controls.Add(lblKralAdet);
            pnlKral.Controls.Add(button14);
            pnlKral.Controls.Add(button13);
            pnlKral.Controls.Add(textBox2);
            pnlKral.Controls.Add(label9);
            pnlKral.Controls.Add(pictureBox3);
            pnlKral.Location = new Point(638, 833);
            pnlKral.Name = "pnlKral";
            pnlKral.Size = new Size(903, 305);
            pnlKral.TabIndex = 19;
            pnlKral.Visible = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Snow;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(682, 196);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(206, 46);
            textBox7.TabIndex = 33;
            textBox7.Text = "Kişi başı:20000₺\r\nİndirimli çocuk fiyatı:10000₺";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // lblKralAdet
            // 
            lblKralAdet.AutoSize = true;
            lblKralAdet.Font = new Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKralAdet.Location = new Point(719, 238);
            lblKralAdet.Name = "lblKralAdet";
            lblKralAdet.Size = new Size(38, 39);
            lblKralAdet.TabIndex = 32;
            lblKralAdet.Text = "0";
            // 
            // button14
            // 
            button14.BackColor = Color.MistyRose;
            button14.Location = new Point(763, 248);
            button14.Name = "button14";
            button14.Size = new Size(30, 30);
            button14.TabIndex = 31;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.MistyRose;
            button13.Location = new Point(683, 248);
            button13.Name = "button13";
            button13.Size = new Size(30, 30);
            button13.TabIndex = 30;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Georgia", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(578, 34);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 181);
            textBox2.TabIndex = 28;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(578, 13);
            label9.Name = "label9";
            label9.Size = new Size(116, 18);
            label9.TabIndex = 27;
            label9.Text = "KRAL DAİRESİ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(559, 274);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pnlSuit
            // 
            pnlSuit.Anchor = AnchorStyles.Top;
            pnlSuit.BackColor = Color.Snow;
            pnlSuit.Controls.Add(textBox9);
            pnlSuit.Controls.Add(lblSuitAdet);
            pnlSuit.Controls.Add(button16);
            pnlSuit.Controls.Add(button15);
            pnlSuit.Controls.Add(textBox3);
            pnlSuit.Controls.Add(label11);
            pnlSuit.Controls.Add(pictureBox4);
            pnlSuit.Location = new Point(646, 1144);
            pnlSuit.Name = "pnlSuit";
            pnlSuit.Size = new Size(903, 305);
            pnlSuit.TabIndex = 33;
            pnlSuit.Visible = false;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Snow;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(683, 180);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(208, 49);
            textBox9.TabIndex = 41;
            textBox9.Text = "Kişi başı:8000₺\r\nİndirimli çocuk fiyatı:4000₺";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // lblSuitAdet
            // 
            lblSuitAdet.AutoSize = true;
            lblSuitAdet.Font = new Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSuitAdet.Location = new Point(719, 225);
            lblSuitAdet.Name = "lblSuitAdet";
            lblSuitAdet.Size = new Size(38, 39);
            lblSuitAdet.TabIndex = 40;
            lblSuitAdet.Text = "0";
            // 
            // button16
            // 
            button16.BackColor = Color.MistyRose;
            button16.Location = new Point(763, 235);
            button16.Name = "button16";
            button16.Size = new Size(30, 30);
            button16.TabIndex = 39;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.MistyRose;
            button15.Location = new Point(683, 235);
            button15.Name = "button15";
            button15.Size = new Size(30, 30);
            button15.TabIndex = 38;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Snow;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Georgia", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(578, 36);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 155);
            textBox3.TabIndex = 36;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(578, 15);
            label11.Name = "label11";
            label11.Size = new Size(44, 18);
            label11.TabIndex = 35;
            label11.Text = "SUİT";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(559, 274);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // pnlAile
            // 
            pnlAile.Anchor = AnchorStyles.Top;
            pnlAile.BackColor = Color.Snow;
            pnlAile.Controls.Add(textBox10);
            pnlAile.Controls.Add(lblAileAdet);
            pnlAile.Controls.Add(button18);
            pnlAile.Controls.Add(button17);
            pnlAile.Controls.Add(textBox4);
            pnlAile.Controls.Add(label13);
            pnlAile.Controls.Add(pictureBox5);
            pnlAile.Location = new Point(646, 1455);
            pnlAile.Name = "pnlAile";
            pnlAile.Size = new Size(903, 305);
            pnlAile.TabIndex = 34;
            pnlAile.Visible = false;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Snow;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(680, 192);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(205, 46);
            textBox10.TabIndex = 39;
            textBox10.Text = "Kişi başı:7000₺\r\nİndirimli çocuk fiyatı:3500₺";
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // lblAileAdet
            // 
            lblAileAdet.AutoSize = true;
            lblAileAdet.Font = new Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAileAdet.Location = new Point(719, 235);
            lblAileAdet.Name = "lblAileAdet";
            lblAileAdet.Size = new Size(38, 39);
            lblAileAdet.TabIndex = 38;
            lblAileAdet.Text = "0";
            // 
            // button18
            // 
            button18.BackColor = Color.MistyRose;
            button18.Location = new Point(763, 244);
            button18.Name = "button18";
            button18.Size = new Size(30, 30);
            button18.TabIndex = 37;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.MistyRose;
            button17.Location = new Point(683, 244);
            button17.Name = "button17";
            button17.Size = new Size(30, 30);
            button17.TabIndex = 36;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Snow;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Georgia", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox4.Location = new Point(578, 37);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 167);
            textBox4.TabIndex = 2;
            textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(578, 16);
            label13.Name = "label13";
            label13.Size = new Size(44, 18);
            label13.TabIndex = 1;
            label13.Text = "AİLE";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(559, 274);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(257, 1775);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1428, 213);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1667, 55);
            label15.Name = "label15";
            label15.Size = new Size(95, 18);
            label15.TabIndex = 36;
            label15.Text = "GİRİŞ 14.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1671, 79);
            label16.Name = "label16";
            label16.Size = new Size(91, 18);
            label16.TabIndex = 37;
            label16.Text = "ÇIKIŞ 12.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 10);
            label8.Name = "label8";
            label8.Size = new Size(157, 18);
            label8.TabIndex = 0;
            label8.Text = "standart oda kişi sayısı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 40);
            label10.Name = "label10";
            label10.Size = new Size(174, 18);
            label10.TabIndex = 1;
            label10.Text = "standart oda çocuk sayısı";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 70);
            label12.Name = "label12";
            label12.Size = new Size(147, 18);
            label12.TabIndex = 2;
            label12.Text = "kral dairesi kişi sayısı";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 100);
            label14.Name = "label14";
            label14.Size = new Size(164, 18);
            label14.TabIndex = 3;
            label14.Text = "kral dairesi çocuk sayısı";
            // 
            // txtStandartYetiskin
            // 
            txtStandartYetiskin.Location = new Point(185, 10);
            txtStandartYetiskin.Name = "txtStandartYetiskin";
            txtStandartYetiskin.Size = new Size(79, 25);
            txtStandartYetiskin.TabIndex = 4;
            txtStandartYetiskin.TextChanged += textBox6_TextChanged;
            // 
            // txtStandartCocuk
            // 
            txtStandartCocuk.Location = new Point(186, 37);
            txtStandartCocuk.Name = "txtStandartCocuk";
            txtStandartCocuk.Size = new Size(79, 25);
            txtStandartCocuk.TabIndex = 5;
            txtStandartCocuk.TextChanged += textBox11_TextChanged;
            // 
            // txtKralYetiskin
            // 
            txtKralYetiskin.Location = new Point(186, 70);
            txtKralYetiskin.Name = "txtKralYetiskin";
            txtKralYetiskin.Size = new Size(79, 25);
            txtKralYetiskin.TabIndex = 6;
            txtKralYetiskin.TextChanged += textBox12_TextChanged;
            // 
            // txtKralCocuk
            // 
            txtKralCocuk.Location = new Point(186, 97);
            txtKralCocuk.Name = "txtKralCocuk";
            txtKralCocuk.Size = new Size(79, 25);
            txtKralCocuk.TabIndex = 7;
            txtKralCocuk.TextChanged += textBox13_TextChanged;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.BackColor = Color.MistyRose;
            lblToplamFiyat.BorderStyle = BorderStyle.None;
            lblToplamFiyat.Location = new Point(14, 256);
            lblToplamFiyat.Multiline = true;
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(248, 99);
            lblToplamFiyat.TabIndex = 8;
            lblToplamFiyat.TextChanged += lblToplamFiyat_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(75, 235);
            label17.Name = "label17";
            label17.Size = new Size(121, 18);
            label17.TabIndex = 9;
            label17.Text = "TOPLAM FİYAT";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Location = new Point(75, 366);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 10;
            button2.Text = "ÖDEME YAP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panelSepetOzeti
            // 
            panelSepetOzeti.Controls.Add(txtAileCocuk);
            panelSepetOzeti.Controls.Add(txtAileYetiskin);
            panelSepetOzeti.Controls.Add(txtSuitYetiskin);
            panelSepetOzeti.Controls.Add(label22);
            panelSepetOzeti.Controls.Add(label21);
            panelSepetOzeti.Controls.Add(label19);
            panelSepetOzeti.Controls.Add(label18);
            panelSepetOzeti.Controls.Add(button2);
            panelSepetOzeti.Controls.Add(label17);
            panelSepetOzeti.Controls.Add(lblToplamFiyat);
            panelSepetOzeti.Controls.Add(txtKralCocuk);
            panelSepetOzeti.Controls.Add(txtKralYetiskin);
            panelSepetOzeti.Controls.Add(txtStandartCocuk);
            panelSepetOzeti.Controls.Add(txtStandartYetiskin);
            panelSepetOzeti.Controls.Add(label14);
            panelSepetOzeti.Controls.Add(label12);
            panelSepetOzeti.Controls.Add(label10);
            panelSepetOzeti.Controls.Add(label8);
            panelSepetOzeti.Location = new Point(1540, 394);
            panelSepetOzeti.Name = "panelSepetOzeti";
            panelSepetOzeti.Size = new Size(265, 417);
            panelSepetOzeti.TabIndex = 38;
            panelSepetOzeti.Visible = false;
            panelSepetOzeti.Paint += panel2_Paint_2;
            // 
            // txtAileCocuk
            // 
            txtAileCocuk.Location = new Point(185, 183);
            txtAileCocuk.Name = "txtAileCocuk";
            txtAileCocuk.Size = new Size(79, 25);
            txtAileCocuk.TabIndex = 18;
            txtAileCocuk.TextChanged += textBox17_TextChanged;
            // 
            // txtAileYetiskin
            // 
            txtAileYetiskin.Location = new Point(185, 158);
            txtAileYetiskin.Name = "txtAileYetiskin";
            txtAileYetiskin.Size = new Size(79, 25);
            txtAileYetiskin.TabIndex = 17;
            txtAileYetiskin.TextChanged += textBox16_TextChanged;
            // 
            // txtSuitYetiskin
            // 
            txtSuitYetiskin.Location = new Point(185, 130);
            txtSuitYetiskin.Name = "txtSuitYetiskin";
            txtSuitYetiskin.Size = new Size(79, 25);
            txtSuitYetiskin.TabIndex = 16;
            txtSuitYetiskin.TextChanged += textBox15_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(5, 190);
            label22.Name = "label22";
            label22.Size = new Size(152, 18);
            label22.TabIndex = 15;
            label22.Text = "aile odası çocuk sayısı";
            label22.Click += label22_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(5, 161);
            label21.Name = "label21";
            label21.Size = new Size(135, 18);
            label21.TabIndex = 14;
            label21.Text = "aile odası kişi sayısı";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(5, 130);
            label19.Name = "label19";
            label19.Size = new Size(126, 18);
            label19.TabIndex = 12;
            label19.Text = "suit oda kişi sayısı";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(5, 128);
            label18.Name = "label18";
            label18.Size = new Size(0, 18);
            label18.TabIndex = 11;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1435, 1460);
            pictureBox7.MaximumSize = new Size(367, 309);
            pictureBox7.MinimumSize = new Size(367, 309);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(367, 309);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 39;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // rezervasyon
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1800, 2000);
            BackColor = Color.MistyRose;
            ClientSize = new Size(895, 349);
            Controls.Add(panelSepetOzeti);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(pictureBox6);
            Controls.Add(pnlAile);
            Controls.Add(pnlSuit);
            Controls.Add(pnlKral);
            Controls.Add(pnlStandart);
            Controls.Add(odaara);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pnlSecimEkrani);
            Controls.Add(btnSecimPaneli);
            Controls.Add(button3);
            Controls.Add(txtMisafirAdi);
            Controls.Add(panel1);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox7);
            Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "rezervasyon";
            Text = "rezervasyon";
            Load += rezervasyon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            pnlSecimEkrani.ResumeLayout(false);
            pnlSecimEkrani.PerformLayout();
            pnlStandart.ResumeLayout(false);
            pnlStandart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlKral.ResumeLayout(false);
            pnlKral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlSuit.ResumeLayout(false);
            pnlSuit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlAile.ResumeLayout(false);
            pnlAile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelSepetOzeti.ResumeLayout(false);
            panelSepetOzeti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MonthCalendar monthCalendar1;
        private Button btnGiris;
        private Button btnCikis;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMisafirAdi;
        private Button button3;
        private Button btnSecimPaneli;
        private Label label1;
        private Panel pnlSecimEkrani;
        private Button button5;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label lblCocukSayisi;
        private Label label5;
        private Label lblYetiskinSayisi;
        private Label label3;
        private Label lblOdaSayisi;
        private Button button6;
        private Label label2;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private Button odaara;
        private Panel pnlStandart;
        private PictureBox pictureBox2;
        private Label label7;
        private Label lblStandartAdet;
        private Button button12;
        private Button button11;
        private TextBox textBox1;
        private Panel pnlKral;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private Label label9;
        private Label lblKralAdet;
        private Button button14;
        private Button button13;
        private Panel pnlSuit;
        private PictureBox pictureBox4;
        private Label lblSuitAdet;
        private Button button16;
        private Button button15;
        private TextBox textBox3;
        private Label label11;
        private Panel pnlAile;
        private TextBox textBox4;
        private Label label13;
        private PictureBox pictureBox5;
        private Label lblAileAdet;
        private Button button18;
        private Button button17;
        private PictureBox pictureBox6;
        private Label label15;
        private Label label16;
        private TextBox textBox5;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label14;
        private TextBox txtStandartYetiskin;
        private TextBox txtStandartCocuk;
        private TextBox txtKralYetiskin;
        private TextBox txtKralCocuk;
        private TextBox lblToplamFiyat;
        private Label label17;
        private Button button2;
        private Panel panelSepetOzeti;
        private Label label18;
        private Label label21;
        private Label label19;
        private Label label22;
        private TextBox txtAileCocuk;
        private TextBox txtAileYetiskin;
        private TextBox txtSuitYetiskin;
        private PictureBox pictureBox7;
    }
}