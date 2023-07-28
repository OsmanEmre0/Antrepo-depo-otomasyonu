
namespace Antrepo
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvgPersonel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPersonelBirim = new System.Windows.Forms.ComboBox();
            this.txtPersonelTcno = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.chkPersonelBirim = new System.Windows.Forms.CheckBox();
            this.chkPersonelTcno = new System.Windows.Forms.CheckBox();
            this.chkPersonelAd = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUyeKullanıcı = new System.Windows.Forms.TextBox();
            this.btnUyeAra = new System.Windows.Forms.Button();
            this.chkUyeKullanıcı = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblArananalan = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTcNo = new System.Windows.Forms.RadioButton();
            this.radAd = new System.Windows.Forms.RadioButton();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersonel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.üyeToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.anaEkranToolStripMenuItem,
            this.uygulamayıKapatToolStripMenuItem,
            this.kullanıcıDeğiştirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1743, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1,
            this.güncelleToolStripMenuItem1});
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.üyeToolStripMenuItem.Text = "Üye";
            this.üyeToolStripMenuItem.Click += new System.EventHandler(this.üyeToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // güncelleToolStripMenuItem1
            // 
            this.güncelleToolStripMenuItem1.Name = "güncelleToolStripMenuItem1";
            this.güncelleToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.güncelleToolStripMenuItem1.Text = "Güncelle";
            this.güncelleToolStripMenuItem1.Click += new System.EventHandler(this.güncelleToolStripMenuItem1_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListeleToolStripMenuItem,
            this.üyeListeleToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // personelListeleToolStripMenuItem
            // 
            this.personelListeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelListeleToolStripMenuItem,
            this.birimListeleToolStripMenuItem});
            this.personelListeleToolStripMenuItem.Name = "personelListeleToolStripMenuItem";
            this.personelListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personelListeleToolStripMenuItem.Text = "Personel Listele";
            // 
            // genelListeleToolStripMenuItem
            // 
            this.genelListeleToolStripMenuItem.Name = "genelListeleToolStripMenuItem";
            this.genelListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.genelListeleToolStripMenuItem.Text = "Genel Listele";
            this.genelListeleToolStripMenuItem.Click += new System.EventHandler(this.genelListeleToolStripMenuItem_Click);
            // 
            // birimListeleToolStripMenuItem
            // 
            this.birimListeleToolStripMenuItem.Name = "birimListeleToolStripMenuItem";
            this.birimListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.birimListeleToolStripMenuItem.Text = "Birim Listele";
            this.birimListeleToolStripMenuItem.Click += new System.EventHandler(this.birimListeleToolStripMenuItem_Click);
            // 
            // üyeListeleToolStripMenuItem
            // 
            this.üyeListeleToolStripMenuItem.Name = "üyeListeleToolStripMenuItem";
            this.üyeListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.üyeListeleToolStripMenuItem.Text = "Üye Listele";
            this.üyeListeleToolStripMenuItem.Click += new System.EventHandler(this.üyeListeleToolStripMenuItem_Click);
            // 
            // anaEkranToolStripMenuItem
            // 
            this.anaEkranToolStripMenuItem.Name = "anaEkranToolStripMenuItem";
            this.anaEkranToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.anaEkranToolStripMenuItem.Text = "Ana Ekran";
            this.anaEkranToolStripMenuItem.Click += new System.EventHandler(this.anaEkranToolStripMenuItem_Click);
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            this.uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            this.uygulamayıKapatToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.uygulamayıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.uygulamayıKapatToolStripMenuItem.Click += new System.EventHandler(this.uygulamayıKapatToolStripMenuItem_Click);
            // 
            // kullanıcıDeğiştirToolStripMenuItem
            // 
            this.kullanıcıDeğiştirToolStripMenuItem.Name = "kullanıcıDeğiştirToolStripMenuItem";
            this.kullanıcıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.kullanıcıDeğiştirToolStripMenuItem.Text = "Kullanıcı Değiştir";
            this.kullanıcıDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıDeğiştirToolStripMenuItem_Click);
            // 
            // dvgPersonel
            // 
            this.dvgPersonel.AllowUserToAddRows = false;
            this.dvgPersonel.AllowUserToDeleteRows = false;
            this.dvgPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPersonel.Location = new System.Drawing.Point(1, 133);
            this.dvgPersonel.Name = "dvgPersonel";
            this.dvgPersonel.ReadOnly = true;
            this.dvgPersonel.RowHeadersWidth = 51;
            this.dvgPersonel.RowTemplate.Height = 24;
            this.dvgPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPersonel.Size = new System.Drawing.Size(1219, 461);
            this.dvgPersonel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbPersonelBirim);
            this.groupBox1.Controls.Add(this.txtPersonelTcno);
            this.groupBox1.Controls.Add(this.txtPersonelAd);
            this.groupBox1.Controls.Add(this.btnPersonelAra);
            this.groupBox1.Controls.Add(this.chkPersonelBirim);
            this.groupBox1.Controls.Add(this.chkPersonelTcno);
            this.groupBox1.Controls.Add(this.chkPersonelAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1226, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt Arama";
            // 
            // cmbPersonelBirim
            // 
            this.cmbPersonelBirim.Enabled = false;
            this.cmbPersonelBirim.FormattingEnabled = true;
            this.cmbPersonelBirim.Location = new System.Drawing.Point(110, 153);
            this.cmbPersonelBirim.Name = "cmbPersonelBirim";
            this.cmbPersonelBirim.Size = new System.Drawing.Size(137, 33);
            this.cmbPersonelBirim.TabIndex = 6;
            // 
            // txtPersonelTcno
            // 
            this.txtPersonelTcno.Enabled = false;
            this.txtPersonelTcno.Location = new System.Drawing.Point(110, 97);
            this.txtPersonelTcno.Mask = "00000000000";
            this.txtPersonelTcno.Name = "txtPersonelTcno";
            this.txtPersonelTcno.Size = new System.Drawing.Size(137, 30);
            this.txtPersonelTcno.TabIndex = 5;
            this.txtPersonelTcno.ValidatingType = typeof(int);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Enabled = false;
            this.txtPersonelAd.Location = new System.Drawing.Point(110, 39);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(137, 30);
            this.txtPersonelAd.TabIndex = 4;
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Location = new System.Drawing.Point(52, 193);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(144, 44);
            this.btnPersonelAra.TabIndex = 3;
            this.btnPersonelAra.Text = "Ara";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // chkPersonelBirim
            // 
            this.chkPersonelBirim.AutoSize = true;
            this.chkPersonelBirim.Location = new System.Drawing.Point(15, 157);
            this.chkPersonelBirim.Name = "chkPersonelBirim";
            this.chkPersonelBirim.Size = new System.Drawing.Size(77, 29);
            this.chkPersonelBirim.TabIndex = 2;
            this.chkPersonelBirim.Text = "Birim";
            this.chkPersonelBirim.UseVisualStyleBackColor = true;
            this.chkPersonelBirim.CheckedChanged += new System.EventHandler(this.chkPersonelBirim_CheckedChanged);
            // 
            // chkPersonelTcno
            // 
            this.chkPersonelTcno.AutoSize = true;
            this.chkPersonelTcno.Location = new System.Drawing.Point(15, 99);
            this.chkPersonelTcno.Name = "chkPersonelTcno";
            this.chkPersonelTcno.Size = new System.Drawing.Size(87, 29);
            this.chkPersonelTcno.TabIndex = 1;
            this.chkPersonelTcno.Text = "Tc No";
            this.chkPersonelTcno.UseVisualStyleBackColor = true;
            this.chkPersonelTcno.CheckedChanged += new System.EventHandler(this.chkPersonelTcno_CheckedChanged);
            // 
            // chkPersonelAd
            // 
            this.chkPersonelAd.AutoSize = true;
            this.chkPersonelAd.Location = new System.Drawing.Point(15, 41);
            this.chkPersonelAd.Name = "chkPersonelAd";
            this.chkPersonelAd.Size = new System.Drawing.Size(59, 29);
            this.chkPersonelAd.TabIndex = 0;
            this.chkPersonelAd.Text = "Ad";
            this.chkPersonelAd.UseVisualStyleBackColor = true;
            this.chkPersonelAd.CheckedChanged += new System.EventHandler(this.chkPersonelAd_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtUyeKullanıcı);
            this.groupBox2.Controls.Add(this.btnUyeAra);
            this.groupBox2.Controls.Add(this.chkUyeKullanıcı);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1226, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye Kayıt Arama";
            // 
            // txtUyeKullanıcı
            // 
            this.txtUyeKullanıcı.Enabled = false;
            this.txtUyeKullanıcı.Location = new System.Drawing.Point(110, 39);
            this.txtUyeKullanıcı.Name = "txtUyeKullanıcı";
            this.txtUyeKullanıcı.Size = new System.Drawing.Size(137, 30);
            this.txtUyeKullanıcı.TabIndex = 2;
            // 
            // btnUyeAra
            // 
            this.btnUyeAra.Location = new System.Drawing.Point(52, 78);
            this.btnUyeAra.Name = "btnUyeAra";
            this.btnUyeAra.Size = new System.Drawing.Size(144, 44);
            this.btnUyeAra.TabIndex = 1;
            this.btnUyeAra.Text = "Ara";
            this.btnUyeAra.UseVisualStyleBackColor = true;
            this.btnUyeAra.Click += new System.EventHandler(this.btnUyeAra_Click);
            // 
            // chkUyeKullanıcı
            // 
            this.chkUyeKullanıcı.AutoSize = true;
            this.chkUyeKullanıcı.Location = new System.Drawing.Point(9, 40);
            this.chkUyeKullanıcı.Name = "chkUyeKullanıcı";
            this.chkUyeKullanıcı.Size = new System.Drawing.Size(107, 29);
            this.chkUyeKullanıcı.TabIndex = 0;
            this.chkUyeKullanıcı.Text = "Kullanıcı";
            this.chkUyeKullanıcı.UseVisualStyleBackColor = true;
            this.chkUyeKullanıcı.CheckedChanged += new System.EventHandler(this.chkUyeKullanıcı_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtAranan);
            this.groupBox3.Controls.Add(this.lblArananalan);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cmbAramaTuru);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(1491, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 243);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Hızlı Arama";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(113, 186);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(111, 30);
            this.txtAranan.TabIndex = 4;
            this.txtAranan.TextChanged += new System.EventHandler(this.txtAranan_TextChanged);
            // 
            // lblArananalan
            // 
            this.lblArananalan.AutoSize = true;
            this.lblArananalan.Location = new System.Drawing.Point(14, 191);
            this.lblArananalan.Name = "lblArananalan";
            this.lblArananalan.Size = new System.Drawing.Size(37, 25);
            this.lblArananalan.TabIndex = 3;
            this.lblArananalan.Text = "Ad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTcNo);
            this.groupBox4.Controls.Add(this.radAd);
            this.groupBox4.Location = new System.Drawing.Point(6, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 83);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alan Seçimi";
            // 
            // radTcNo
            // 
            this.radTcNo.AutoSize = true;
            this.radTcNo.Location = new System.Drawing.Point(107, 40);
            this.radTcNo.Name = "radTcNo";
            this.radTcNo.Size = new System.Drawing.Size(86, 29);
            this.radTcNo.TabIndex = 1;
            this.radTcNo.TabStop = true;
            this.radTcNo.Text = "Tc No";
            this.radTcNo.UseVisualStyleBackColor = true;
            this.radTcNo.CheckedChanged += new System.EventHandler(this.radTcNo_CheckedChanged);
            // 
            // radAd
            // 
            this.radAd.AutoSize = true;
            this.radAd.Location = new System.Drawing.Point(6, 40);
            this.radAd.Name = "radAd";
            this.radAd.Size = new System.Drawing.Size(58, 29);
            this.radAd.TabIndex = 0;
            this.radAd.TabStop = true;
            this.radAd.Text = "Ad";
            this.radAd.UseVisualStyleBackColor = true;
            this.radAd.CheckedChanged += new System.EventHandler(this.radAd_CheckedChanged);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(113, 26);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(123, 33);
            this.cmbAramaTuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Türü";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1743, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgPersonel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Activated += new System.EventHandler(this.Personel_Load);
            this.Load += new System.EventHandler(this.Personel_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersonel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private System.Windows.Forms.DataGridView dvgPersonel;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPersonelAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPersonelBirim;
        private System.Windows.Forms.MaskedTextBox txtPersonelTcno;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.CheckBox chkPersonelBirim;
        private System.Windows.Forms.CheckBox chkPersonelTcno;
        private System.Windows.Forms.CheckBox chkUyeKullanıcı;
        private System.Windows.Forms.Button btnUyeAra;
        private System.Windows.Forms.TextBox txtUyeKullanıcı;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListeleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblArananalan;
        private System.Windows.Forms.RadioButton radTcNo;
        private System.Windows.Forms.RadioButton radAd;
    }
}