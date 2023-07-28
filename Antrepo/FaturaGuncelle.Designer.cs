
namespace Antrepo
{
    partial class FaturaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID13 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBayi = new System.Windows.Forms.ComboBox();
            this.cmbFaturaCins = new System.Windows.Forms.ComboBox();
            this.txtUrunAgirlik = new System.Windows.Forms.MaskedTextBox();
            this.txtGirisTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtKurTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtMalKurDeger = new System.Windows.Forms.MaskedTextBox();
            this.txtMDeger = new System.Windows.Forms.MaskedTextBox();
            this.txtVadeT = new System.Windows.Forms.MaskedTextBox();
            this.txtGFis = new System.Windows.Forms.MaskedTextBox();
            this.txtFaturaT = new System.Windows.Forms.MaskedTextBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbBayi);
            this.groupBox1.Controls.Add(this.txtID13);
            this.groupBox1.Controls.Add(this.cmbFaturaCins);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtUrunAgirlik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGirisTarih);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKurTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFaturaT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGFis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVadeT);
            this.groupBox1.Controls.Add(this.txtMDeger);
            this.groupBox1.Controls.Add(this.txtMalKurDeger);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Güncelle";
            // 
            // txtID13
            // 
            this.txtID13.Enabled = false;
            this.txtID13.Location = new System.Drawing.Point(199, 32);
            this.txtID13.Name = "txtID13";
            this.txtID13.Size = new System.Drawing.Size(145, 30);
            this.txtID13.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(7, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 78;
            this.label10.Text = "Malın Kur Değeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(7, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 77;
            this.label9.Text = "Malın Değeri";
            // 
            // cmbBayi
            // 
            this.cmbBayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBayi.FormattingEnabled = true;
            this.cmbBayi.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Antalya",
            "İzmir",
            "Mersin",
            "Bursa",
            "Kastamonu",
            "Artvin",
            "Bolu",
            "Zonguldak",
            "Samsun",
            "Rize",
            "Giresun",
            "Kars",
            "Kahramanmaraş",
            "Sinop",
            "Sivas"});
            this.cmbBayi.Location = new System.Drawing.Point(559, 263);
            this.cmbBayi.Name = "cmbBayi";
            this.cmbBayi.Size = new System.Drawing.Size(145, 33);
            this.cmbBayi.TabIndex = 76;
            this.cmbBayi.Text = "Bayi Seçiniz";
            // 
            // cmbFaturaCins
            // 
            this.cmbFaturaCins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFaturaCins.FormattingEnabled = true;
            this.cmbFaturaCins.Items.AddRange(new object[] {
            "Fatura",
            "e-Fatura",
            "e-Arşiv"});
            this.cmbFaturaCins.Location = new System.Drawing.Point(559, 95);
            this.cmbFaturaCins.Name = "cmbFaturaCins";
            this.cmbFaturaCins.Size = new System.Drawing.Size(145, 33);
            this.cmbFaturaCins.TabIndex = 75;
            this.cmbFaturaCins.Text = "Fatura Seçiniz";
            // 
            // txtUrunAgirlik
            // 
            this.txtUrunAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAgirlik.Location = new System.Drawing.Point(559, 208);
            this.txtUrunAgirlik.Mask = "00000000";
            this.txtUrunAgirlik.Name = "txtUrunAgirlik";
            this.txtUrunAgirlik.Size = new System.Drawing.Size(145, 30);
            this.txtUrunAgirlik.TabIndex = 73;
            this.txtUrunAgirlik.ValidatingType = typeof(int);
            // 
            // txtGirisTarih
            // 
            this.txtGirisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTarih.Location = new System.Drawing.Point(559, 154);
            this.txtGirisTarih.Mask = "00/00/0000";
            this.txtGirisTarih.Name = "txtGirisTarih";
            this.txtGirisTarih.Size = new System.Drawing.Size(145, 30);
            this.txtGirisTarih.TabIndex = 72;
            this.txtGirisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtKurTarih
            // 
            this.txtKurTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKurTarih.Location = new System.Drawing.Point(559, 32);
            this.txtKurTarih.Mask = "00/00/0000";
            this.txtKurTarih.Name = "txtKurTarih";
            this.txtKurTarih.Size = new System.Drawing.Size(145, 30);
            this.txtKurTarih.TabIndex = 71;
            this.txtKurTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtMalKurDeger
            // 
            this.txtMalKurDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalKurDeger.Location = new System.Drawing.Point(199, 302);
            this.txtMalKurDeger.Name = "txtMalKurDeger";
            this.txtMalKurDeger.Size = new System.Drawing.Size(145, 30);
            this.txtMalKurDeger.TabIndex = 70;
            // 
            // txtMDeger
            // 
            this.txtMDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMDeger.Location = new System.Drawing.Point(199, 246);
            this.txtMDeger.Mask = "0000000000000";
            this.txtMDeger.Name = "txtMDeger";
            this.txtMDeger.Size = new System.Drawing.Size(145, 30);
            this.txtMDeger.TabIndex = 74;
            this.txtMDeger.ValidatingType = typeof(int);
            // 
            // txtVadeT
            // 
            this.txtVadeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVadeT.Location = new System.Drawing.Point(199, 190);
            this.txtVadeT.Mask = "00/00/0000";
            this.txtVadeT.Name = "txtVadeT";
            this.txtVadeT.Size = new System.Drawing.Size(145, 30);
            this.txtVadeT.TabIndex = 69;
            this.txtVadeT.ValidatingType = typeof(System.DateTime);
            // 
            // txtGFis
            // 
            this.txtGFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGFis.Location = new System.Drawing.Point(199, 78);
            this.txtGFis.Mask = "00000";
            this.txtGFis.Name = "txtGFis";
            this.txtGFis.Size = new System.Drawing.Size(145, 30);
            this.txtGFis.TabIndex = 68;
            this.txtGFis.ValidatingType = typeof(int);
            // 
            // txtFaturaT
            // 
            this.txtFaturaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaT.Location = new System.Drawing.Point(199, 134);
            this.txtFaturaT.Mask = "00/00/0000";
            this.txtFaturaT.Name = "txtFaturaT";
            this.txtFaturaT.Size = new System.Drawing.Size(145, 30);
            this.txtFaturaT.TabIndex = 67;
            this.txtFaturaT.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(367, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = "Bayi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(367, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Ürün Ağırlığı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(367, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Giriş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(367, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fatura Cinsi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(367, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Kur Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Vade Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fatura Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Giriş Fişi No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kayıt Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FaturaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FaturaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaGuncelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cmbBayi;
        public System.Windows.Forms.TextBox txtID13;
        public System.Windows.Forms.ComboBox cmbFaturaCins;
        public System.Windows.Forms.MaskedTextBox txtUrunAgirlik;
        public System.Windows.Forms.MaskedTextBox txtGirisTarih;
        public System.Windows.Forms.MaskedTextBox txtKurTarih;
        public System.Windows.Forms.MaskedTextBox txtFaturaT;
        public System.Windows.Forms.MaskedTextBox txtGFis;
        public System.Windows.Forms.MaskedTextBox txtVadeT;
        public System.Windows.Forms.MaskedTextBox txtMDeger;
        public System.Windows.Forms.MaskedTextBox txtMalKurDeger;
    }
}