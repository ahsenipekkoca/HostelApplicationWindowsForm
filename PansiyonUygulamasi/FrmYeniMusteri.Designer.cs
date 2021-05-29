namespace PansiyonUygulamasi
{
    partial class FrmYeniMusteri
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBosOda = new System.Windows.Forms.Button();
            this.btnOda106 = new System.Windows.Forms.Button();
            this.btnDoluOda = new System.Windows.Forms.Button();
            this.btnOda109 = new System.Windows.Forms.Button();
            this.btnOda108 = new System.Windows.Forms.Button();
            this.btnOda107 = new System.Windows.Forms.Button();
            this.btnOda102 = new System.Windows.Forms.Button();
            this.btnOda103 = new System.Windows.Forms.Button();
            this.btnOda105 = new System.Windows.Forms.Button();
            this.btnOda104 = new System.Windows.Forms.Button();
            this.btnOda101 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.dtpCikisTarihi);
            this.groupBox1.Controls.Add(this.dtpGirisTarihi);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtOdaNo);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(230, 110);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(214, 29);
            this.cmbCinsiyet.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(111, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "Cinsiyet";
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.Location = new System.Drawing.Point(230, 337);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(216, 29);
            this.txtUcret.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(127, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ücret";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(230, 475);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(216, 42);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCikisTarihi.Location = new System.Drawing.Point(228, 431);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(216, 22);
            this.dtpCikisTarihi.TabIndex = 34;
            this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpCikisTarihi_ValueChanged);
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGirisTarihi.Location = new System.Drawing.Point(228, 379);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(216, 22);
            this.dtpGirisTarihi.TabIndex = 33;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(230, 154);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(216, 29);
            this.txtTelefon.TabIndex = 32;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(230, 63);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(216, 29);
            this.txtSoyadi.TabIndex = 31;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(230, 195);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(216, 29);
            this.txtMail.TabIndex = 30;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(230, 288);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(216, 29);
            this.txtOdaNo.TabIndex = 29;
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(230, 238);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(216, 29);
            this.txtTC.TabIndex = 28;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(230, 26);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(216, 29);
            this.txtAdi.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(85, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Çıkış Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(85, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giriş Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "T.C. Kimlik Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Oda Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(134, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(116, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBosOda);
            this.groupBox2.Controls.Add(this.btnOda106);
            this.groupBox2.Controls.Add(this.btnDoluOda);
            this.groupBox2.Controls.Add(this.btnOda109);
            this.groupBox2.Controls.Add(this.btnOda108);
            this.groupBox2.Controls.Add(this.btnOda107);
            this.groupBox2.Controls.Add(this.btnOda102);
            this.groupBox2.Controls.Add(this.btnOda103);
            this.groupBox2.Controls.Add(this.btnOda105);
            this.groupBox2.Controls.Add(this.btnOda104);
            this.groupBox2.Controls.Add(this.btnOda101);
            this.groupBox2.Location = new System.Drawing.Point(537, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 536);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btnBosOda
            // 
            this.btnBosOda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBosOda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosOda.ForeColor = System.Drawing.Color.Black;
            this.btnBosOda.Location = new System.Drawing.Point(350, 445);
            this.btnBosOda.Name = "btnBosOda";
            this.btnBosOda.Size = new System.Drawing.Size(69, 57);
            this.btnBosOda.TabIndex = 10;
            this.btnBosOda.Text = "BOŞ";
            this.btnBosOda.UseVisualStyleBackColor = false;
            this.btnBosOda.Click += new System.EventHandler(this.btnBosOda_Click);
            // 
            // btnOda106
            // 
            this.btnOda106.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda106.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda106.ForeColor = System.Drawing.Color.Black;
            this.btnOda106.Location = new System.Drawing.Point(302, 197);
            this.btnOda106.Name = "btnOda106";
            this.btnOda106.Size = new System.Drawing.Size(69, 57);
            this.btnOda106.TabIndex = 8;
            this.btnOda106.Text = "106";
            this.btnOda106.UseVisualStyleBackColor = false;
            this.btnOda106.Click += new System.EventHandler(this.btnOda106_Click);
            // 
            // btnDoluOda
            // 
            this.btnDoluOda.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDoluOda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoluOda.ForeColor = System.Drawing.Color.Black;
            this.btnDoluOda.Location = new System.Drawing.Point(275, 445);
            this.btnDoluOda.Name = "btnDoluOda";
            this.btnDoluOda.Size = new System.Drawing.Size(69, 57);
            this.btnDoluOda.TabIndex = 9;
            this.btnDoluOda.Text = "DOLU";
            this.btnDoluOda.UseVisualStyleBackColor = false;
            this.btnDoluOda.Click += new System.EventHandler(this.btnDoluOda_Click);
            // 
            // btnOda109
            // 
            this.btnOda109.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda109.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda109.ForeColor = System.Drawing.Color.Black;
            this.btnOda109.Location = new System.Drawing.Point(302, 348);
            this.btnOda109.Name = "btnOda109";
            this.btnOda109.Size = new System.Drawing.Size(69, 57);
            this.btnOda109.TabIndex = 7;
            this.btnOda109.Text = "109";
            this.btnOda109.UseVisualStyleBackColor = false;
            this.btnOda109.Click += new System.EventHandler(this.btnOda109_Click);
            // 
            // btnOda108
            // 
            this.btnOda108.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda108.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda108.ForeColor = System.Drawing.Color.Black;
            this.btnOda108.Location = new System.Drawing.Point(174, 348);
            this.btnOda108.Name = "btnOda108";
            this.btnOda108.Size = new System.Drawing.Size(69, 57);
            this.btnOda108.TabIndex = 6;
            this.btnOda108.Text = "108";
            this.btnOda108.UseVisualStyleBackColor = false;
            this.btnOda108.Click += new System.EventHandler(this.btnOda108_Click);
            // 
            // btnOda107
            // 
            this.btnOda107.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda107.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda107.ForeColor = System.Drawing.Color.Black;
            this.btnOda107.Location = new System.Drawing.Point(35, 348);
            this.btnOda107.Name = "btnOda107";
            this.btnOda107.Size = new System.Drawing.Size(69, 57);
            this.btnOda107.TabIndex = 5;
            this.btnOda107.Text = "107";
            this.btnOda107.UseVisualStyleBackColor = false;
            this.btnOda107.Click += new System.EventHandler(this.btnOda107_Click);
            // 
            // btnOda102
            // 
            this.btnOda102.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda102.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda102.ForeColor = System.Drawing.Color.Black;
            this.btnOda102.Location = new System.Drawing.Point(174, 55);
            this.btnOda102.Name = "btnOda102";
            this.btnOda102.Size = new System.Drawing.Size(69, 57);
            this.btnOda102.TabIndex = 4;
            this.btnOda102.Text = "102";
            this.btnOda102.UseVisualStyleBackColor = false;
            this.btnOda102.Click += new System.EventHandler(this.btnOda102_Click);
            // 
            // btnOda103
            // 
            this.btnOda103.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda103.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda103.ForeColor = System.Drawing.Color.Black;
            this.btnOda103.Location = new System.Drawing.Point(302, 55);
            this.btnOda103.Name = "btnOda103";
            this.btnOda103.Size = new System.Drawing.Size(69, 57);
            this.btnOda103.TabIndex = 3;
            this.btnOda103.Text = "103";
            this.btnOda103.UseVisualStyleBackColor = false;
            this.btnOda103.Click += new System.EventHandler(this.btnOda103_Click);
            // 
            // btnOda105
            // 
            this.btnOda105.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda105.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda105.ForeColor = System.Drawing.Color.Black;
            this.btnOda105.Location = new System.Drawing.Point(174, 197);
            this.btnOda105.Name = "btnOda105";
            this.btnOda105.Size = new System.Drawing.Size(69, 57);
            this.btnOda105.TabIndex = 2;
            this.btnOda105.Text = "105";
            this.btnOda105.UseVisualStyleBackColor = false;
            this.btnOda105.Click += new System.EventHandler(this.btnOda105_Click);
            // 
            // btnOda104
            // 
            this.btnOda104.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda104.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda104.ForeColor = System.Drawing.Color.Black;
            this.btnOda104.Location = new System.Drawing.Point(35, 197);
            this.btnOda104.Name = "btnOda104";
            this.btnOda104.Size = new System.Drawing.Size(69, 57);
            this.btnOda104.TabIndex = 1;
            this.btnOda104.Text = "104";
            this.btnOda104.UseVisualStyleBackColor = false;
            this.btnOda104.Click += new System.EventHandler(this.btnOda104_Click);
            // 
            // btnOda101
            // 
            this.btnOda101.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOda101.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda101.ForeColor = System.Drawing.Color.Black;
            this.btnOda101.Location = new System.Drawing.Point(35, 55);
            this.btnOda101.Name = "btnOda101";
            this.btnOda101.Size = new System.Drawing.Size(69, 57);
            this.btnOda101.TabIndex = 0;
            this.btnOda101.Text = "101";
            this.btnOda101.UseVisualStyleBackColor = false;
            this.btnOda101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(32, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 40;
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(988, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMusteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOda106;
        private System.Windows.Forms.Button btnOda109;
        private System.Windows.Forms.Button btnOda108;
        private System.Windows.Forms.Button btnOda107;
        private System.Windows.Forms.Button btnOda102;
        private System.Windows.Forms.Button btnOda103;
        private System.Windows.Forms.Button btnOda105;
        private System.Windows.Forms.Button btnOda104;
        private System.Windows.Forms.Button btnOda101;
        private System.Windows.Forms.Button btnDoluOda;
        private System.Windows.Forms.Button btnBosOda;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label11;
    }
}