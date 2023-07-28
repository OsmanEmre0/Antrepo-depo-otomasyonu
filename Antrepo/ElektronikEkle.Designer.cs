
namespace Antrepo
{
    partial class ElektronikEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElektronikEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtTaneFiyati = new System.Windows.Forms.MaskedTextBox();
            this.txtGelisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.cmbGelisYeri = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.MaskedTextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtGelisTarihi1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtisim);
            this.groupBox1.Controls.Add(this.txtTaneFiyati);
            this.groupBox1.Controls.Add(this.txtGelisFiyati);
            this.groupBox1.Controls.Add(this.cmbGelisYeri);
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.txtGelisTarihi1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elektronik Kayıt Ekle";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(283, 35);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(177, 30);
            this.txtisim.TabIndex = 15;
            // 
            // txtTaneFiyati
            // 
            this.txtTaneFiyati.Location = new System.Drawing.Point(283, 434);
            this.txtTaneFiyati.Mask = "0000000000";
            this.txtTaneFiyati.Name = "txtTaneFiyati";
            this.txtTaneFiyati.Size = new System.Drawing.Size(177, 30);
            this.txtTaneFiyati.TabIndex = 14;
            this.txtTaneFiyati.ValidatingType = typeof(int);
            // 
            // txtGelisFiyati
            // 
            this.txtGelisFiyati.Location = new System.Drawing.Point(283, 377);
            this.txtGelisFiyati.Mask = "000000000000";
            this.txtGelisFiyati.Name = "txtGelisFiyati";
            this.txtGelisFiyati.Size = new System.Drawing.Size(177, 30);
            this.txtGelisFiyati.TabIndex = 13;
            this.txtGelisFiyati.ValidatingType = typeof(int);
            // 
            // cmbGelisYeri
            // 
            this.cmbGelisYeri.FormattingEnabled = true;
            this.cmbGelisYeri.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "Antalya",
            "Amerika",
            "Almanya",
            "Çin",
            "Japonya",
            "Mersin",
            "Fransa",
            "İngiltere",
            "İtalya"});
            this.cmbGelisYeri.Location = new System.Drawing.Point(283, 317);
            this.cmbGelisYeri.Name = "cmbGelisYeri";
            this.cmbGelisYeri.Size = new System.Drawing.Size(177, 33);
            this.cmbGelisYeri.TabIndex = 12;
            this.cmbGelisYeri.Text = "Geliş Yeri Seçiniz";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(283, 263);
            this.txtAdet.Mask = "00000000";
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(177, 30);
            this.txtAdet.TabIndex = 11;
            this.txtAdet.ValidatingType = typeof(int);
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Samsung",
            "Bosh",
            "Arçelik",
            "Siemens",
            "Apple",
            "Dyson",
            "Philips",
            "Vestel",
            "Xiaomi",
            "LG",
            "Tefal",
            "Huawei",
            "Arzum",
            "Jbl ",
            "Lenova",
            "Logitech",
            "Gamepower",
            "Rampage",
            "Asus",
            "MSI",
            "Dell",
            "Casper",
            "Monster",
            "Hp",
            "Razer",
            "Oppo",
            "Sony"});
            this.cmbMarka.Location = new System.Drawing.Point(283, 203);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(177, 33);
            this.cmbMarka.TabIndex = 10;
            this.cmbMarka.Text = "Marka Seçiniz";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Telefon",
            "Fare",
            "Klavye",
            "Monitör",
            "Elektrikli Süpürge",
            "Tablet",
            "Çamaşır Makinesi",
            "Bulaşık Makinesi",
            "Yazıcı",
            "Kulak İçi Kulaklık",
            "Kulak Dışı Kulaklık",
            "Kamera",
            "Çay Makinesi",
            "Kahve Makinesi",
            "Saç Kurutma Makinesi",
            "Hoparlör",
            "Traş Makinesi",
            "Televizyon",
            "Leptop",
            "Bilgisayar Kasası"});
            this.cmbTur.Location = new System.Drawing.Point(283, 146);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(177, 33);
            this.cmbTur.TabIndex = 9;
            this.cmbTur.Text = "Tür Seçiniz";
            // 
            // txtGelisTarihi1
            // 
            this.txtGelisTarihi1.Location = new System.Drawing.Point(283, 92);
            this.txtGelisTarihi1.Mask = "00/00/0000";
            this.txtGelisTarihi1.Name = "txtGelisTarihi1";
            this.txtGelisTarihi1.Size = new System.Drawing.Size(177, 30);
            this.txtGelisTarihi1.TabIndex = 8;
            this.txtGelisTarihi1.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tane Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Geliş Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Geliş Yeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geliş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 511);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(486, 62);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Kayıt Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(8, 584);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(152, 36);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(342, 585);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(152, 36);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ElektronikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 630);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ElektronikEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElektronikEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.MaskedTextBox txtTaneFiyati;
        private System.Windows.Forms.MaskedTextBox txtGelisFiyati;
        private System.Windows.Forms.ComboBox cmbGelisYeri;
        private System.Windows.Forms.MaskedTextBox txtAdet;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.MaskedTextBox txtGelisTarihi1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTemizle;
    }
}