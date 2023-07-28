
namespace Antrepo
{
    partial class GıdaGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GıdaGüncelle));
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGelis = new System.Windows.Forms.ComboBox();
            this.cmbÜrün = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGelisTarih = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonTarih = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdTür = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(237, 508);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiyat.Mask = "00000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(226, 30);
            this.txtFiyat.TabIndex = 35;
            this.txtFiyat.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 510);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "KG Geliş Fiyatı";
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
            this.cmbGelis.Location = new System.Drawing.Point(237, 444);
            this.cmbGelis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGelis.Name = "cmbGelis";
            this.cmbGelis.Size = new System.Drawing.Size(229, 33);
            this.cmbGelis.TabIndex = 33;
            this.cmbGelis.Text = "Geliş Seçiniz";
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
            this.cmbÜrün.Location = new System.Drawing.Point(235, 124);
            this.cmbÜrün.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbÜrün.Name = "cmbÜrün";
            this.cmbÜrün.Size = new System.Drawing.Size(228, 33);
            this.cmbÜrün.TabIndex = 23;
            this.cmbÜrün.Text = "Ürün Seçiniz";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(235, 253);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdet.Mask = "00000";
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(228, 30);
            this.txtAdet.TabIndex = 32;
            this.txtAdet.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(154, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Gıda Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Geliş Yeri";
            // 
            // txtGelisTarih
            // 
            this.txtGelisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelisTarih.Location = new System.Drawing.Point(235, 384);
            this.txtGelisTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGelisTarih.Mask = "00/00/0000";
            this.txtGelisTarih.Name = "txtGelisTarih";
            this.txtGelisTarih.Size = new System.Drawing.Size(228, 25);
            this.txtGelisTarih.TabIndex = 29;
            this.txtGelisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Geliş Tarihi";
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonTarih.Location = new System.Drawing.Point(237, 321);
            this.txtSonTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSonTarih.Mask = "00/00/0000";
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Size = new System.Drawing.Size(228, 25);
            this.txtSonTarih.TabIndex = 27;
            this.txtSonTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Son Tüketim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Adet";
            // 
            // cmdTür
            // 
            this.cmdTür.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdTür.FormattingEnabled = true;
            this.cmdTür.Items.AddRange(new object[] {
            "Meyve",
            "Sebze",
            "Hazır Gıda"});
            this.cmdTür.Location = new System.Drawing.Point(237, 187);
            this.cmdTür.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTür.Name = "cmdTür";
            this.cmdTür.Size = new System.Drawing.Size(228, 33);
            this.cmdTür.TabIndex = 24;
            this.cmdTür.Text = "Tür Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tür";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ürün İsimi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 570);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 67);
            this.button1.TabIndex = 36;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 570);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 67);
            this.button2.TabIndex = 36;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 30);
            this.txtID.TabIndex = 38;
            // 
            // GıdaGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 644);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGelis);
            this.Controls.Add(this.cmbÜrün);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGelisTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSonTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdTür);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GıdaGüncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GıdaGüncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox txtFiyat;
        public System.Windows.Forms.ComboBox cmbGelis;
        public System.Windows.Forms.ComboBox cmbÜrün;
        public System.Windows.Forms.MaskedTextBox txtAdet;
        public System.Windows.Forms.MaskedTextBox txtGelisTarih;
        public System.Windows.Forms.MaskedTextBox txtSonTarih;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.ComboBox cmdTür;
    }
}