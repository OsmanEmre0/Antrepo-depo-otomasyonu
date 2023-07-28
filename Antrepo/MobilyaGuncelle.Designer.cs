
namespace Antrepo
{
    partial class MobilyaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobilyaGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cmbGelisYeri = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtTaneFiyati = new System.Windows.Forms.MaskedTextBox();
            this.txtGelisFiyati = new System.Windows.Forms.MaskedTextBox();
            this.txtAdet = new System.Windows.Forms.MaskedTextBox();
            this.txtGelisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.cmbGelisYeri);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.txtTaneFiyati);
            this.groupBox1.Controls.Add(this.txtGelisFiyati);
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.txtGelisTarihi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mobilya Güncelle";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Koltuk",
            "Sandalye",
            "Sehpa",
            "Masa",
            "Dolap",
            "Gardırop",
            "Yatak",
            "Beşik"});
            this.cmbTur.Location = new System.Drawing.Point(215, 266);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(180, 33);
            this.cmbTur.TabIndex = 30;
            this.cmbTur.Text = "Tür Seçiniz";
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
            this.cmbGelisYeri.Location = new System.Drawing.Point(215, 220);
            this.cmbGelisYeri.Name = "cmbGelisYeri";
            this.cmbGelisYeri.Size = new System.Drawing.Size(180, 33);
            this.cmbGelisYeri.TabIndex = 31;
            this.cmbGelisYeri.Text = "Geliş Yeri Seçiniz";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Bellona",
            "Doğtaş",
            "İstikbal",
            "Mondi",
            "İkea",
            "Kelebek",
            "Vivense",
            "Modalife"});
            this.cmbMarka.Location = new System.Drawing.Point(215, 128);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(180, 33);
            this.cmbMarka.TabIndex = 32;
            this.cmbMarka.Text = "Marka Seçiniz";
            // 
            // txtTaneFiyati
            // 
            this.txtTaneFiyati.Location = new System.Drawing.Point(215, 361);
            this.txtTaneFiyati.Mask = "000000000000";
            this.txtTaneFiyati.Name = "txtTaneFiyati";
            this.txtTaneFiyati.Size = new System.Drawing.Size(180, 30);
            this.txtTaneFiyati.TabIndex = 29;
            this.txtTaneFiyati.ValidatingType = typeof(int);
            // 
            // txtGelisFiyati
            // 
            this.txtGelisFiyati.Location = new System.Drawing.Point(215, 315);
            this.txtGelisFiyati.Mask = "00000000";
            this.txtGelisFiyati.Name = "txtGelisFiyati";
            this.txtGelisFiyati.Size = new System.Drawing.Size(180, 30);
            this.txtGelisFiyati.TabIndex = 28;
            this.txtGelisFiyati.ValidatingType = typeof(int);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(215, 177);
            this.txtAdet.Mask = "000000000";
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(180, 30);
            this.txtAdet.TabIndex = 27;
            this.txtAdet.ValidatingType = typeof(int);
            // 
            // txtGelisTarihi
            // 
            this.txtGelisTarihi.Location = new System.Drawing.Point(215, 85);
            this.txtGelisTarihi.Mask = "00/00/0000";
            this.txtGelisTarihi.Name = "txtGelisTarihi";
            this.txtGelisTarihi.Size = new System.Drawing.Size(180, 30);
            this.txtGelisTarihi.TabIndex = 26;
            this.txtGelisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Geliş Yeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Geliş Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tür";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tane Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Geliş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(6, 2);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(6, 2);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(215, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 30);
            this.txtID.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kayıt Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MobilyaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MobilyaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobilyaGuncelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbTur;
        public System.Windows.Forms.ComboBox cmbGelisYeri;
        public System.Windows.Forms.ComboBox cmbMarka;
        public System.Windows.Forms.MaskedTextBox txtTaneFiyati;
        public System.Windows.Forms.MaskedTextBox txtGelisFiyati;
        public System.Windows.Forms.MaskedTextBox txtAdet;
        public System.Windows.Forms.MaskedTextBox txtGelisTarihi;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}