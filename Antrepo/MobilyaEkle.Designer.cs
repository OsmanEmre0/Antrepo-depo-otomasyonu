
namespace Antrepo
{
    partial class MobilyaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobilyaEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTur2 = new System.Windows.Forms.ComboBox();
            this.cmbGelisYeri2 = new System.Windows.Forms.ComboBox();
            this.cmbMarka2 = new System.Windows.Forms.ComboBox();
            this.txtTaneFiyati2 = new System.Windows.Forms.MaskedTextBox();
            this.txtGelisFiyati2 = new System.Windows.Forms.MaskedTextBox();
            this.txtAdet2 = new System.Windows.Forms.MaskedTextBox();
            this.txtGelisTarihi2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbTur2);
            this.groupBox1.Controls.Add(this.cmbGelisYeri2);
            this.groupBox1.Controls.Add(this.cmbMarka2);
            this.groupBox1.Controls.Add(this.txtTaneFiyati2);
            this.groupBox1.Controls.Add(this.txtGelisFiyati2);
            this.groupBox1.Controls.Add(this.txtAdet2);
            this.groupBox1.Controls.Add(this.txtGelisTarihi2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mobilya Kayıt Ekle";
            // 
            // cmbTur2
            // 
            this.cmbTur2.FormattingEnabled = true;
            this.cmbTur2.Items.AddRange(new object[] {
            "Koltuk",
            "Sandalye",
            "Sehpa",
            "Masa",
            "Dolap",
            "Gardırop",
            "Yatak",
            "Beşik"});
            this.cmbTur2.Location = new System.Drawing.Point(223, 193);
            this.cmbTur2.Name = "cmbTur2";
            this.cmbTur2.Size = new System.Drawing.Size(180, 33);
            this.cmbTur2.TabIndex = 16;
            this.cmbTur2.Text = "Tür Seçiniz";
            // 
            // cmbGelisYeri2
            // 
            this.cmbGelisYeri2.FormattingEnabled = true;
            this.cmbGelisYeri2.Items.AddRange(new object[] {
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
            this.cmbGelisYeri2.Location = new System.Drawing.Point(223, 149);
            this.cmbGelisYeri2.Name = "cmbGelisYeri2";
            this.cmbGelisYeri2.Size = new System.Drawing.Size(180, 33);
            this.cmbGelisYeri2.TabIndex = 16;
            this.cmbGelisYeri2.Text = "Geliş Yeri Seçiniz";
            // 
            // cmbMarka2
            // 
            this.cmbMarka2.FormattingEnabled = true;
            this.cmbMarka2.Items.AddRange(new object[] {
            "Bellona",
            "Doğtaş",
            "İstikbal",
            "Mondi",
            "İkea",
            "Kelebek",
            "Vivense",
            "Modalife"});
            this.cmbMarka2.Location = new System.Drawing.Point(223, 66);
            this.cmbMarka2.Name = "cmbMarka2";
            this.cmbMarka2.Size = new System.Drawing.Size(180, 33);
            this.cmbMarka2.TabIndex = 16;
            this.cmbMarka2.Text = "Marka Seçiniz";
            // 
            // txtTaneFiyati2
            // 
            this.txtTaneFiyati2.Location = new System.Drawing.Point(223, 291);
            this.txtTaneFiyati2.Mask = "000000000000";
            this.txtTaneFiyati2.Name = "txtTaneFiyati2";
            this.txtTaneFiyati2.Size = new System.Drawing.Size(180, 30);
            this.txtTaneFiyati2.TabIndex = 15;
            this.txtTaneFiyati2.ValidatingType = typeof(int);
            // 
            // txtGelisFiyati2
            // 
            this.txtGelisFiyati2.Location = new System.Drawing.Point(223, 242);
            this.txtGelisFiyati2.Mask = "00000000";
            this.txtGelisFiyati2.Name = "txtGelisFiyati2";
            this.txtGelisFiyati2.Size = new System.Drawing.Size(180, 30);
            this.txtGelisFiyati2.TabIndex = 14;
            this.txtGelisFiyati2.ValidatingType = typeof(int);
            // 
            // txtAdet2
            // 
            this.txtAdet2.Location = new System.Drawing.Point(223, 111);
            this.txtAdet2.Mask = "000000000";
            this.txtAdet2.Name = "txtAdet2";
            this.txtAdet2.Size = new System.Drawing.Size(180, 30);
            this.txtAdet2.TabIndex = 11;
            this.txtAdet2.ValidatingType = typeof(int);
            // 
            // txtGelisTarihi2
            // 
            this.txtGelisTarihi2.Location = new System.Drawing.Point(223, 30);
            this.txtGelisTarihi2.Mask = "00/00/0000";
            this.txtGelisTarihi2.Name = "txtGelisTarihi2";
            this.txtGelisTarihi2.Size = new System.Drawing.Size(180, 30);
            this.txtGelisTarihi2.TabIndex = 9;
            this.txtGelisTarihi2.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Geliş Yeri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Geliş Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tür";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tane Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geliş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(6, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(6, 2);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 383);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(422, 56);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Kayıt Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(279, 452);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(149, 43);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // MobilyaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 512);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MobilyaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobilyaEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTur2;
        private System.Windows.Forms.ComboBox cmbGelisYeri2;
        private System.Windows.Forms.ComboBox cmbMarka2;
        private System.Windows.Forms.MaskedTextBox txtTaneFiyati2;
        private System.Windows.Forms.MaskedTextBox txtGelisFiyati2;
        private System.Windows.Forms.MaskedTextBox txtAdet2;
        private System.Windows.Forms.MaskedTextBox txtGelisTarihi2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTemizle;
    }
}