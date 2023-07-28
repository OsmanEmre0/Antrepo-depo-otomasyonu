
namespace Antrepo
{
    partial class GıdaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GıdaEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdTür = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSonTarih = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGelisTarih = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.bntGeriDön = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.MaskedTextBox();
            this.cmbÜrün = new System.Windows.Forms.ComboBox();
            this.cmbGelis = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün İsimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tür";
            // 
            // cmdTür
            // 
            this.cmdTür.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdTür.FormattingEnabled = true;
            this.cmdTür.Items.AddRange(new object[] {
            "Meyve",
            "Sebze",
            "Hazır Gıda"});
            this.cmdTür.Location = new System.Drawing.Point(230, 100);
            this.cmdTür.Name = "cmdTür";
            this.cmdTür.Size = new System.Drawing.Size(174, 33);
            this.cmdTür.TabIndex = 3;
            this.cmdTür.Text = "Tür Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Son Tüketim Tarihi";
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonTarih.Location = new System.Drawing.Point(230, 249);
            this.txtSonTarih.Mask = "00/00/0000";
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Size = new System.Drawing.Size(174, 25);
            this.txtSonTarih.TabIndex = 8;
            this.txtSonTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Geliş Tarihi";
            // 
            // txtGelisTarih
            // 
            this.txtGelisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelisTarih.Location = new System.Drawing.Point(230, 324);
            this.txtGelisTarih.Mask = "00/00/0000";
            this.txtGelisTarih.Name = "txtGelisTarih";
            this.txtGelisTarih.Size = new System.Drawing.Size(174, 25);
            this.txtGelisTarih.TabIndex = 10;
            this.txtGelisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geliş Yeri";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKayitEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayitEkle.FlatAppearance.BorderSize = 0;
            this.btnKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitEkle.Location = new System.Drawing.Point(34, 520);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(369, 45);
            this.btnKayitEkle.TabIndex = 13;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = false;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // bntGeriDön
            // 
            this.bntGeriDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntGeriDön.Location = new System.Drawing.Point(34, 585);
            this.bntGeriDön.Name = "bntGeriDön";
            this.bntGeriDön.Size = new System.Drawing.Size(147, 38);
            this.bntGeriDön.TabIndex = 14;
            this.bntGeriDön.Text = "Geri Dön";
            this.bntGeriDön.UseVisualStyleBackColor = true;
            this.bntGeriDön.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(256, 585);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(147, 38);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(149, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gıda Ekle";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(229, 174);
            this.txtAdet.Mask = "00000";
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(174, 22);
            this.txtAdet.TabIndex = 17;
            this.txtAdet.ValidatingType = typeof(int);
            // 
            // cmbÜrün
            // 
            this.cmbÜrün.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbÜrün.FormattingEnabled = true;
            this.cmbÜrün.Items.AddRange(new object[] {
            "Çilek",
            "Muz",
            "Elma",
            "Armut",
            "Karpuz",
            "Ananas",
            "Kivi",
            "Erik",
            "Portakal",
            "Mandalina",
            "Kiraz",
            "Ispanak",
            "Marul",
            "Pancar",
            "Havuç",
            "Turp",
            "Şalgam",
            "Fasulye",
            "Bezelye",
            "Soğan",
            "Sarımsak",
            "Pırasa",
            "Domates",
            "Patates",
            "Kabak",
            "Patlıcan",
            "Lahana",
            "Biber",
            "Makarna",
            "Erişte",
            "Cips",
            "Bisküvi",
            "Pizza",
            "Börek",
            "Ton Balığı",
            "Çorba",
            "Çay"});
            this.cmbÜrün.Location = new System.Drawing.Point(229, 29);
            this.cmbÜrün.Name = "cmbÜrün";
            this.cmbÜrün.Size = new System.Drawing.Size(174, 33);
            this.cmbÜrün.TabIndex = 3;
            this.cmbÜrün.Text = "Ürün Seçiniz";
            // 
            // cmbGelis
            // 
            this.cmbGelis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGelis.FormattingEnabled = true;
            this.cmbGelis.Items.AddRange(new object[] {
            "Antalya",
            "Ankara",
            "Mersin",
            "Adana",
            "İstanbul",
            "Adıyaman",
            "Ağrı",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Kayseri",
            "Kastamonu",
            "Kahramanmaraş",
            "Manisa",
            "Muş",
            "Muğla",
            "Niğde",
            "Rize",
            "Samsun",
            "Sakarya",
            "Tekirdağ",
            "Batman",
            "Karaman",
            "Konya"});
            this.cmbGelis.Location = new System.Drawing.Point(229, 391);
            this.cmbGelis.Name = "cmbGelis";
            this.cmbGelis.Size = new System.Drawing.Size(175, 33);
            this.cmbGelis.TabIndex = 18;
            this.cmbGelis.Text = "Geliş Seçiniz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "KG Geliş Fiyatı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(230, 461);
            this.txtFiyat.Mask = "00000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(173, 30);
            this.txtFiyat.TabIndex = 20;
            this.txtFiyat.ValidatingType = typeof(int);
            // 
            // GıdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 647);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGelis);
            this.Controls.Add(this.cmbÜrün);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.bntGeriDön);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGelisTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSonTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdTür);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GıdaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GıdaEkle";
            this.Load += new System.EventHandler(this.GıdaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdTür;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtSonTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtGelisTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Button bntGeriDön;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtAdet;
        private System.Windows.Forms.ComboBox cmbÜrün;
        private System.Windows.Forms.ComboBox cmbGelis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
    }
}