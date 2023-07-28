
namespace Antrepo
{
    partial class CikisFisiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CikisFisiGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtCTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtTTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtMdegeri = new System.Windows.Forms.MaskedTextBox();
            this.cmbMcinsi = new System.Windows.Forms.ComboBox();
            this.cmbTTipi = new System.Windows.Forms.ComboBox();
            this.cmbAlici = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMKurDegeri = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMKurDegeri);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.txtCTarihi);
            this.groupBox1.Controls.Add(this.txtTTarih);
            this.groupBox1.Controls.Add(this.txtMdegeri);
            this.groupBox1.Controls.Add(this.cmbMcinsi);
            this.groupBox1.Controls.Add(this.cmbTTipi);
            this.groupBox1.Controls.Add(this.cmbAlici);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çıkış Fişi Güncelle";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(568, 92);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(152, 30);
            this.txtPlaka.TabIndex = 48;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(222, 251);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(152, 30);
            this.txtSoyadi.TabIndex = 47;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(222, 200);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(152, 30);
            this.txtAdi.TabIndex = 46;
            // 
            // txtCTarihi
            // 
            this.txtCTarihi.Location = new System.Drawing.Point(568, 145);
            this.txtCTarihi.Mask = "00/00/0000";
            this.txtCTarihi.Name = "txtCTarihi";
            this.txtCTarihi.Size = new System.Drawing.Size(152, 30);
            this.txtCTarihi.TabIndex = 45;
            this.txtCTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtTTarih
            // 
            this.txtTTarih.Location = new System.Drawing.Point(568, 203);
            this.txtTTarih.Mask = "00/00/0000";
            this.txtTTarih.Name = "txtTTarih";
            this.txtTTarih.Size = new System.Drawing.Size(152, 30);
            this.txtTTarih.TabIndex = 44;
            this.txtTTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtMdegeri
            // 
            this.txtMdegeri.Location = new System.Drawing.Point(222, 304);
            this.txtMdegeri.Mask = "0000000000";
            this.txtMdegeri.Name = "txtMdegeri";
            this.txtMdegeri.Size = new System.Drawing.Size(152, 30);
            this.txtMdegeri.TabIndex = 42;
            this.txtMdegeri.ValidatingType = typeof(int);
            // 
            // cmbMcinsi
            // 
            this.cmbMcinsi.FormattingEnabled = true;
            this.cmbMcinsi.Items.AddRange(new object[] {
            "Gıda ",
            "Elektronik",
            "Mobilya"});
            this.cmbMcinsi.Location = new System.Drawing.Point(568, 36);
            this.cmbMcinsi.Name = "cmbMcinsi";
            this.cmbMcinsi.Size = new System.Drawing.Size(152, 33);
            this.cmbMcinsi.TabIndex = 40;
            this.cmbMcinsi.Text = "Malın Cins Seçiniz";
            // 
            // cmbTTipi
            // 
            this.cmbTTipi.FormattingEnabled = true;
            this.cmbTTipi.Items.AddRange(new object[] {
            "Hava Taşımacılığı",
            "Kara Taşımacılığı"});
            this.cmbTTipi.Location = new System.Drawing.Point(222, 142);
            this.cmbTTipi.Name = "cmbTTipi";
            this.cmbTTipi.Size = new System.Drawing.Size(152, 33);
            this.cmbTTipi.TabIndex = 41;
            this.cmbTTipi.Text = "Taşıma Seçiniz";
            // 
            // cmbAlici
            // 
            this.cmbAlici.FormattingEnabled = true;
            this.cmbAlici.Items.AddRange(new object[] {
            "İstanbul ",
            "Ankara",
            "İzmir",
            "Mersin",
            "Kastamonu ",
            "Rize",
            "Samsun",
            "Antalya",
            "Bolu",
            "Sivas",
            "Kayseri",
            "Bursa",
            "Balıkesir",
            "Giresun"});
            this.cmbAlici.Location = new System.Drawing.Point(222, 89);
            this.cmbAlici.Name = "cmbAlici";
            this.cmbAlici.Size = new System.Drawing.Size(152, 33);
            this.cmbAlici.TabIndex = 39;
            this.cmbAlici.Text = "Alıcı Seçiniz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(397, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Tasfiye Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(397, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Çıkış Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(397, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Plaka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(397, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Malın Cinsi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(24, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Malın Kur Değeri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Malın Değeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Çekici Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Çekici Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Taşıma tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Alıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(222, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(152, 30);
            this.txtID.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kayıt Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMKurDegeri
            // 
            this.txtMKurDegeri.Location = new System.Drawing.Point(222, 357);
            this.txtMKurDegeri.Name = "txtMKurDegeri";
            this.txtMKurDegeri.Size = new System.Drawing.Size(152, 30);
            this.txtMKurDegeri.TabIndex = 51;
            // 
            // CikisFisiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CikisFisiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CikisFisiGuncelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtPlaka;
        public System.Windows.Forms.TextBox txtSoyadi;
        public System.Windows.Forms.TextBox txtAdi;
        public System.Windows.Forms.MaskedTextBox txtCTarihi;
        public System.Windows.Forms.MaskedTextBox txtTTarih;
        public System.Windows.Forms.MaskedTextBox txtMdegeri;
        public System.Windows.Forms.ComboBox cmbMcinsi;
        public System.Windows.Forms.ComboBox cmbTTipi;
        public System.Windows.Forms.ComboBox cmbAlici;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.MaskedTextBox txtMKurDegeri;
    }
}