
namespace Antrepo
{
    partial class YurtDışıSevkiyatEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YurtDışıSevkiyatEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGyer = new System.Windows.Forms.ComboBox();
            this.cmbTasit = new System.Windows.Forms.ComboBox();
            this.txtGTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtYfiyat = new System.Windows.Forms.MaskedTextBox();
            this.txtAdet = new System.Windows.Forms.MaskedTextBox();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbGyer);
            this.groupBox1.Controls.Add(this.cmbTasit);
            this.groupBox1.Controls.Add(this.txtGTarihi);
            this.groupBox1.Controls.Add(this.txtYfiyat);
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.cmbMalzeme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbGyer
            // 
            this.cmbGyer.FormattingEnabled = true;
            this.cmbGyer.Items.AddRange(new object[] {
            "Almanya \t",
            "İsveç ",
            "Amerika Birleşik Devletleri\t",
            "İsviçre\t",
            "Avustralya\t",
            "Kanada",
            "Avusturya\t",
            "Katar",
            "Azerbaycan\t",
            "Kazakistan",
            "Kuveyt",
            "Belçika\t",
            "KKTC\t",
            "Cezayir\t",
            "Libya",
            "Danimarka\t",
            "Rusya",
            "Fransa\t",
            "Suudi Arabistan",
            "Hollanda\t",
            "Türkmenistan",
            "İngiltere  \t"});
            this.cmbGyer.Location = new System.Drawing.Point(186, 391);
            this.cmbGyer.Name = "cmbGyer";
            this.cmbGyer.Size = new System.Drawing.Size(146, 33);
            this.cmbGyer.TabIndex = 23;
            this.cmbGyer.Text = "Yer Seçin";
            // 
            // cmbTasit
            // 
            this.cmbTasit.FormattingEnabled = true;
            this.cmbTasit.Items.AddRange(new object[] {
            "BMC",
            "DAF",
            "Fiat",
            "Ford Trucks",
            "Iveco",
            "Liaz",
            "Mack",
            "MAN",
            "Mercedes-Benz",
            "Renault",
            "Scania",
            "Volvo",
            "Cessna F172M Skyhawk",
            "Cessna 152",
            "TC-UZI Fly Synthesis",
            "AutoSera 2019 AeroPract A22 Ls",
            "Antanov An26 type"});
            this.cmbTasit.Location = new System.Drawing.Point(186, 319);
            this.cmbTasit.Name = "cmbTasit";
            this.cmbTasit.Size = new System.Drawing.Size(146, 33);
            this.cmbTasit.TabIndex = 22;
            this.cmbTasit.Text = "Taşıt Seçiniz";
            // 
            // txtGTarihi
            // 
            this.txtGTarihi.Location = new System.Drawing.Point(186, 250);
            this.txtGTarihi.Mask = "00/00/0000";
            this.txtGTarihi.Name = "txtGTarihi";
            this.txtGTarihi.Size = new System.Drawing.Size(146, 30);
            this.txtGTarihi.TabIndex = 21;
            this.txtGTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txtYfiyat
            // 
            this.txtYfiyat.Location = new System.Drawing.Point(186, 178);
            this.txtYfiyat.Mask = "000000000000000";
            this.txtYfiyat.Name = "txtYfiyat";
            this.txtYfiyat.Size = new System.Drawing.Size(146, 30);
            this.txtYfiyat.TabIndex = 20;
            this.txtYfiyat.ValidatingType = typeof(int);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(186, 106);
            this.txtAdet.Mask = "00000000";
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(146, 30);
            this.txtAdet.TabIndex = 19;
            this.txtAdet.ValidatingType = typeof(int);
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Items.AddRange(new object[] {
            "Gıda",
            "Elektronik",
            "Mobilya"});
            this.cmbMalzeme.Location = new System.Drawing.Point(186, 31);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(146, 33);
            this.cmbMalzeme.TabIndex = 18;
            this.cmbMalzeme.Text = "Malzeme Seçiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gönderilen Yer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Taşıt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gönderme Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Giden Malzeme";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(296, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(154, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kayıt Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(8, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // YurtDışıSevkiyatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YurtDışıSevkiyatEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YurtDışıSevkiyatEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGyer;
        private System.Windows.Forms.ComboBox cmbTasit;
        private System.Windows.Forms.MaskedTextBox txtGTarihi;
        private System.Windows.Forms.MaskedTextBox txtYfiyat;
        private System.Windows.Forms.MaskedTextBox txtAdet;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}