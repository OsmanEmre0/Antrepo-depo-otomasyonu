
namespace Antrepo
{
    partial class PersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSrc = new System.Windows.Forms.ComboBox();
            this.txtİban = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cmbKan = new System.Windows.Forms.ComboBox();
            this.txtCalismaYili = new System.Windows.Forms.MaskedTextBox();
            this.txtAvans = new System.Windows.Forms.MaskedTextBox();
            this.txtPrim = new System.Windows.Forms.MaskedTextBox();
            this.txtMaas = new System.Windows.Forms.MaskedTextBox();
            this.txtEhliyetNo = new System.Windows.Forms.MaskedTextBox();
            this.txtİseBaslamaTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.cmbOgrenim = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.radBayan = new System.Windows.Forms.RadioButton();
            this.radBay = new System.Windows.Forms.RadioButton();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtID8 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtID8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbSrc);
            this.groupBox1.Controls.Add(this.txtİban);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.cmbKan);
            this.groupBox1.Controls.Add(this.txtCalismaYili);
            this.groupBox1.Controls.Add(this.txtAvans);
            this.groupBox1.Controls.Add(this.txtPrim);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.txtEhliyetNo);
            this.groupBox1.Controls.Add(this.txtİseBaslamaTarih);
            this.groupBox1.Controls.Add(this.cmbBirim);
            this.groupBox1.Controls.Add(this.cmbOgrenim);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.radBayan);
            this.groupBox1.Controls.Add(this.radBay);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(888, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Güncelle";
            // 
            // cmbSrc
            // 
            this.cmbSrc.FormattingEnabled = true;
            this.cmbSrc.Items.AddRange(new object[] {
            "SRC 1: Uluslararası Yolcu Taşımacılığı",
            "SRC 2: Yurtiçi Yolcu Taşımacılığı",
            "SRC 3: Uluslararası Eşya-Kargo Taşımacılığı",
            "SRC 4: Yurtiçi Eşya-Kargo Taşımacılığı"});
            this.cmbSrc.Location = new System.Drawing.Point(684, 115);
            this.cmbSrc.Name = "cmbSrc";
            this.cmbSrc.Size = new System.Drawing.Size(183, 33);
            this.cmbSrc.TabIndex = 69;
            this.cmbSrc.Text = "Src Seçiniz";
            // 
            // txtİban
            // 
            this.txtİban.Location = new System.Drawing.Point(230, 416);
            this.txtİban.Name = "txtİban";
            this.txtİban.Size = new System.Drawing.Size(182, 30);
            this.txtİban.TabIndex = 68;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(230, 246);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(182, 30);
            this.txtAdres.TabIndex = 67;
            // 
            // cmbKan
            // 
            this.cmbKan.FormattingEnabled = true;
            this.cmbKan.Items.AddRange(new object[] {
            "0 Rh-",
            "0 Rh+",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-"});
            this.cmbKan.Location = new System.Drawing.Point(685, 330);
            this.cmbKan.Name = "cmbKan";
            this.cmbKan.Size = new System.Drawing.Size(182, 33);
            this.cmbKan.TabIndex = 66;
            this.cmbKan.Text = "Kan Grubu Seçin";
            // 
            // txtCalismaYili
            // 
            this.txtCalismaYili.Location = new System.Drawing.Point(685, 290);
            this.txtCalismaYili.Mask = "00";
            this.txtCalismaYili.Name = "txtCalismaYili";
            this.txtCalismaYili.Size = new System.Drawing.Size(182, 30);
            this.txtCalismaYili.TabIndex = 62;
            this.txtCalismaYili.ValidatingType = typeof(int);
            // 
            // txtAvans
            // 
            this.txtAvans.Location = new System.Drawing.Point(685, 247);
            this.txtAvans.Mask = "0000000000";
            this.txtAvans.Name = "txtAvans";
            this.txtAvans.Size = new System.Drawing.Size(182, 30);
            this.txtAvans.TabIndex = 65;
            this.txtAvans.ValidatingType = typeof(int);
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(685, 204);
            this.txtPrim.Mask = "000000000";
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(182, 30);
            this.txtPrim.TabIndex = 64;
            this.txtPrim.ValidatingType = typeof(int);
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(685, 161);
            this.txtMaas.Mask = "00000000";
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(182, 30);
            this.txtMaas.TabIndex = 63;
            this.txtMaas.ValidatingType = typeof(int);
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Location = new System.Drawing.Point(685, 72);
            this.txtEhliyetNo.Mask = "00000";
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(182, 30);
            this.txtEhliyetNo.TabIndex = 61;
            this.txtEhliyetNo.ValidatingType = typeof(int);
            // 
            // txtİseBaslamaTarih
            // 
            this.txtİseBaslamaTarih.Location = new System.Drawing.Point(684, 32);
            this.txtİseBaslamaTarih.Mask = "00/00/0000";
            this.txtİseBaslamaTarih.Name = "txtİseBaslamaTarih";
            this.txtİseBaslamaTarih.Size = new System.Drawing.Size(182, 30);
            this.txtİseBaslamaTarih.TabIndex = 60;
            this.txtİseBaslamaTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "İşçi",
            "Temizlikci",
            "Çaycı",
            "Şöför"});
            this.cmbBirim.Location = new System.Drawing.Point(230, 370);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(182, 33);
            this.cmbBirim.TabIndex = 59;
            this.cmbBirim.Text = "Birim Seçiniz";
            // 
            // cmbOgrenim
            // 
            this.cmbOgrenim.FormattingEnabled = true;
            this.cmbOgrenim.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise",
            "Önlisans",
            "Lisans",
            "Yüksek Lisans"});
            this.cmbOgrenim.Location = new System.Drawing.Point(230, 327);
            this.cmbOgrenim.Name = "cmbOgrenim";
            this.cmbOgrenim.Size = new System.Drawing.Size(182, 33);
            this.cmbOgrenim.TabIndex = 58;
            this.cmbOgrenim.Text = "Öğrenim Durumu";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(230, 287);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(182, 30);
            this.txtTel.TabIndex = 57;
            // 
            // radBayan
            // 
            this.radBayan.AutoSize = true;
            this.radBayan.Location = new System.Drawing.Point(323, 202);
            this.radBayan.Name = "radBayan";
            this.radBayan.Size = new System.Drawing.Size(89, 29);
            this.radBayan.TabIndex = 56;
            this.radBayan.TabStop = true;
            this.radBayan.Text = "Bayan";
            this.radBayan.UseVisualStyleBackColor = true;
            // 
            // radBay
            // 
            this.radBay.AutoSize = true;
            this.radBay.Location = new System.Drawing.Point(230, 202);
            this.radBay.Name = "radBay";
            this.radBay.Size = new System.Drawing.Size(67, 29);
            this.radBay.TabIndex = 55;
            this.radBay.TabStop = true;
            this.radBay.Text = "Bay";
            this.radBay.UseVisualStyleBackColor = true;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(230, 158);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(182, 30);
            this.txtTcNo.TabIndex = 54;
            this.txtTcNo.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(230, 115);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 30);
            this.txtSoyad.TabIndex = 53;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(230, 72);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(182, 30);
            this.txtAd.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(493, 338);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 25);
            this.label19.TabIndex = 51;
            this.label19.Text = "Kan Grubu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(493, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 25);
            this.label16.TabIndex = 50;
            this.label16.Text = "Ehliyet No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(493, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 25);
            this.label15.TabIndex = 49;
            this.label15.Text = "Src No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(493, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "İşe Başlama Tarihi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(493, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 47;
            this.label13.Text = "Çalışma Yılı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(493, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "Maaş";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Birim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Pirim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Avans";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "İban ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Öğrenim Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tc No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 25);
            this.label17.TabIndex = 70;
            this.label17.Text = "ID";
            // 
            // txtID8
            // 
            this.txtID8.Enabled = false;
            this.txtID8.Location = new System.Drawing.Point(230, 31);
            this.txtID8.Name = "txtID8";
            this.txtID8.Size = new System.Drawing.Size(182, 30);
            this.txtID8.TabIndex = 71;
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonelGuncelle";
            this.Text = "PersonelGuncelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ComboBox cmbSrc;
        public System.Windows.Forms.MaskedTextBox txtİban;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.ComboBox cmbKan;
        public System.Windows.Forms.MaskedTextBox txtCalismaYili;
        public System.Windows.Forms.MaskedTextBox txtAvans;
        public System.Windows.Forms.MaskedTextBox txtPrim;
        public System.Windows.Forms.MaskedTextBox txtMaas;
        public System.Windows.Forms.MaskedTextBox txtEhliyetNo;
        public System.Windows.Forms.MaskedTextBox txtİseBaslamaTarih;
        public System.Windows.Forms.ComboBox cmbBirim;
        public System.Windows.Forms.ComboBox cmbOgrenim;
        public System.Windows.Forms.MaskedTextBox txtTel;
        public System.Windows.Forms.RadioButton radBayan;
        public System.Windows.Forms.RadioButton radBay;
        public System.Windows.Forms.MaskedTextBox txtTcNo;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtID8;
    }
}