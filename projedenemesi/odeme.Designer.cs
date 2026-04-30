namespace projedenemesi
{
    partial class odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odeme));
            panel1 = new Panel();
            tutar = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            txtCVV = new TextBox();
            txtYil = new TextBox();
            txtKartNo = new TextBox();
            txtKartSahibi = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tutar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtCVV);
            panel1.Controls.Add(txtYil);
            panel1.Controls.Add(txtKartNo);
            panel1.Controls.Add(txtKartSahibi);
            panel1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 576);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tutar
            // 
            tutar.BorderStyle = BorderStyle.None;
            tutar.Location = new Point(754, 424);
            tutar.Name = "tutar";
            tutar.Size = new Size(125, 18);
            tutar.TabIndex = 7;
            tutar.TextChanged += tutar_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(651, 458);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "ÖDE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(563, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 26);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtCVV
            // 
            txtCVV.BorderStyle = BorderStyle.None;
            txtCVV.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtCVV.Location = new Point(798, 361);
            txtCVV.MaxLength = 3;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(60, 18);
            txtCVV.TabIndex = 5;
            txtCVV.TextChanged += textBox5_TextChanged;
            // 
            // txtYil
            // 
            txtYil.BorderStyle = BorderStyle.None;
            txtYil.Location = new Point(678, 360);
            txtYil.MaxLength = 4;
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(67, 18);
            txtYil.TabIndex = 4;
            txtYil.TextChanged += textBox4_TextChanged;
            // 
            // txtKartNo
            // 
            txtKartNo.BorderStyle = BorderStyle.None;
            txtKartNo.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKartNo.Location = new Point(563, 288);
            txtKartNo.MaxLength = 16;
            txtKartNo.Name = "txtKartNo";
            txtKartNo.Size = new Size(275, 18);
            txtKartNo.TabIndex = 2;
            txtKartNo.TextChanged += textBox2_TextChanged;
            // 
            // txtKartSahibi
            // 
            txtKartSahibi.BorderStyle = BorderStyle.None;
            txtKartSahibi.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKartSahibi.Location = new Point(563, 207);
            txtKartSahibi.MaxLength = 100;
            txtKartSahibi.Name = "txtKartSahibi";
            txtKartSahibi.Size = new Size(275, 18);
            txtKartSahibi.TabIndex = 1;
            txtKartSahibi.TextChanged += textBox1_TextChanged;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(982, 953);
            Controls.Add(panel1);
            Name = "odeme";
            Text = "odeme";
            Load += odeme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtKartNo;
        private TextBox txtKartSahibi;
        private ComboBox comboBox1;
        private TextBox txtCVV;
        private TextBox txtYil;
        private Button button1;
        private TextBox tutar;
    }
}