
namespace Antrepo
{
    partial class HavaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HavaGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAgirlik = new System.Windows.Forms.MaskedTextBox();
            this.txtDegeri = new System.Windows.Forms.MaskedTextBox();
            this.txtUyili = new System.Windows.Forms.MaskedTextBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID19 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtID19);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAgirlik);
            this.groupBox1.Controls.Add(this.txtDegeri);
            this.groupBox1.Controls.Add(this.txtUyili);
            this.groupBox1.Controls.Add(this.cmbRenk);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hava Güncelle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kayıt Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(413, 168);
            this.txtAgirlik.Mask = "00000000";
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(166, 30);
            this.txtAgirlik.TabIndex = 16;
            this.txtAgirlik.ValidatingType = typeof(int);
            // 
            // txtDegeri
            // 
            this.txtDegeri.Location = new System.Drawing.Point(413, 99);
            this.txtDegeri.Mask = "0000000000000";
            this.txtDegeri.Name = "txtDegeri";
            this.txtDegeri.Size = new System.Drawing.Size(166, 30);
            this.txtDegeri.TabIndex = 17;
            this.txtDegeri.ValidatingType = typeof(int);
            // 
            // txtUyili
            // 
            this.txtUyili.Location = new System.Drawing.Point(411, 36);
            this.txtUyili.Mask = "0000";
            this.txtUyili.Name = "txtUyili";
            this.txtUyili.Size = new System.Drawing.Size(166, 30);
            this.txtUyili.TabIndex = 18;
            this.txtUyili.ValidatingType = typeof(int);
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Items.AddRange(new object[] {
            "Siyah",
            "Beyaz",
            "Kırmızı",
            "Yeşil",
            "Sarı",
            "Mavi",
            "Mor"});
            this.cmbRenk.Location = new System.Drawing.Point(96, 165);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(166, 33);
            this.cmbRenk.TabIndex = 15;
            this.cmbRenk.Text = "Renk Seçiniz";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "Cessna F172M Skyhawk",
            "Cessna 152",
            "TC-UZI Fly Synthesis",
            "AutoSera 2019 AeroPract A22 Ls",
            "Antanov An26 type"});
            this.cmbModel.Location = new System.Drawing.Point(96, 99);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(166, 33);
            this.cmbModel.TabIndex = 14;
            this.cmbModel.Text = "Model Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ağırlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Piyasa değeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Üretim Yılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Renk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID";
            // 
            // txtID19
            // 
            this.txtID19.Enabled = false;
            this.txtID19.Location = new System.Drawing.Point(96, 36);
            this.txtID19.Name = "txtID19";
            this.txtID19.Size = new System.Drawing.Size(166, 30);
            this.txtID19.TabIndex = 20;
            // 
            // HavaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HavaGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HavaGuncelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txtAgirlik;
        public System.Windows.Forms.MaskedTextBox txtDegeri;
        public System.Windows.Forms.MaskedTextBox txtUyili;
        public System.Windows.Forms.ComboBox cmbRenk;
        public System.Windows.Forms.ComboBox cmbModel;
        public System.Windows.Forms.TextBox txtID19;
    }
}