
namespace Antrepo
{
    partial class Fatura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.btngeri = new System.Windows.Forms.Button();
            this.btncik = new System.Windows.Forms.Button();
            this.dvgFatura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaturaT = new System.Windows.Forms.MaskedTextBox();
            this.txtVadeT = new System.Windows.Forms.MaskedTextBox();
            this.txtKurTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbFaturaCins = new System.Windows.Forms.ComboBox();
            this.txtGirisTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtUrunAgirlik = new System.Windows.Forms.MaskedTextBox();
            this.cmbBayi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMDeger = new System.Windows.Forms.MaskedTextBox();
            this.txtMalKurDeger = new System.Windows.Forms.MaskedTextBox();
            this.txtGFis = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbFaturaBayi = new System.Windows.Forms.ComboBox();
            this.cmbKFaturaCins = new System.Windows.Forms.ComboBox();
            this.txtFaturaTarihi = new System.Windows.Forms.MaskedTextBox();
            this.chkBayi = new System.Windows.Forms.CheckBox();
            this.chkFaturacins = new System.Windows.Forms.CheckBox();
            this.chkFaturaTarih = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblArananAlan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radDeger = new System.Windows.Forms.RadioButton();
            this.radBayi = new System.Windows.Forms.RadioButton();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFatura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Location = new System.Drawing.Point(1327, 1);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(82, 75);
            this.btngeri.TabIndex = 0;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btncik
            // 
            this.btncik.BackColor = System.Drawing.Color.Transparent;
            this.btncik.FlatAppearance.BorderSize = 0;
            this.btncik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncik.Location = new System.Drawing.Point(1460, 1);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(83, 74);
            this.btncik.TabIndex = 1;
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Click += new System.EventHandler(this.btncik_Click);
            // 
            // dvgFatura
            // 
            this.dvgFatura.AllowUserToAddRows = false;
            this.dvgFatura.AllowUserToDeleteRows = false;
            this.dvgFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFatura.Location = new System.Drawing.Point(544, 103);
            this.dvgFatura.Name = "dvgFatura";
            this.dvgFatura.ReadOnly = true;
            this.dvgFatura.RowHeadersWidth = 51;
            this.dvgFatura.RowTemplate.Height = 24;
            this.dvgFatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgFatura.Size = new System.Drawing.Size(1030, 436);
            this.dvgFatura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giriş Fişi No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fatura Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vade Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kur Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fatura Cinsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giriş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ürün Ağırlığı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bayi";
            // 
            // txtFaturaT
            // 
            this.txtFaturaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaT.Location = new System.Drawing.Point(204, 173);
            this.txtFaturaT.Mask = "00/00/0000";
            this.txtFaturaT.Name = "txtFaturaT";
            this.txtFaturaT.Size = new System.Drawing.Size(145, 30);
            this.txtFaturaT.TabIndex = 11;
            this.txtFaturaT.ValidatingType = typeof(System.DateTime);
            // 
            // txtVadeT
            // 
            this.txtVadeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVadeT.Location = new System.Drawing.Point(204, 229);
            this.txtVadeT.Mask = "00/00/0000";
            this.txtVadeT.Name = "txtVadeT";
            this.txtVadeT.Size = new System.Drawing.Size(145, 30);
            this.txtVadeT.TabIndex = 11;
            this.txtVadeT.ValidatingType = typeof(System.DateTime);
            // 
            // txtKurTarih
            // 
            this.txtKurTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKurTarih.Location = new System.Drawing.Point(204, 397);
            this.txtKurTarih.Mask = "00/00/0000";
            this.txtKurTarih.Name = "txtKurTarih";
            this.txtKurTarih.Size = new System.Drawing.Size(145, 30);
            this.txtKurTarih.TabIndex = 11;
            this.txtKurTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbFaturaCins
            // 
            this.cmbFaturaCins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFaturaCins.FormattingEnabled = true;
            this.cmbFaturaCins.Items.AddRange(new object[] {
            "Fatura",
            "e-Fatura",
            "e-Arşiv"});
            this.cmbFaturaCins.Location = new System.Drawing.Point(204, 450);
            this.cmbFaturaCins.Name = "cmbFaturaCins";
            this.cmbFaturaCins.Size = new System.Drawing.Size(145, 33);
            this.cmbFaturaCins.TabIndex = 12;
            this.cmbFaturaCins.Text = "Fatura Seçiniz";
            // 
            // txtGirisTarih
            // 
            this.txtGirisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTarih.Location = new System.Drawing.Point(204, 509);
            this.txtGirisTarih.Mask = "00/00/0000";
            this.txtGirisTarih.Name = "txtGirisTarih";
            this.txtGirisTarih.Size = new System.Drawing.Size(145, 30);
            this.txtGirisTarih.TabIndex = 11;
            this.txtGirisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtUrunAgirlik
            // 
            this.txtUrunAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAgirlik.Location = new System.Drawing.Point(204, 563);
            this.txtUrunAgirlik.Mask = "00000000";
            this.txtUrunAgirlik.Name = "txtUrunAgirlik";
            this.txtUrunAgirlik.Size = new System.Drawing.Size(145, 30);
            this.txtUrunAgirlik.TabIndex = 11;
            this.txtUrunAgirlik.ValidatingType = typeof(int);
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
            this.cmbBayi.Location = new System.Drawing.Point(204, 618);
            this.cmbBayi.Name = "cmbBayi";
            this.cmbBayi.Size = new System.Drawing.Size(145, 33);
            this.cmbBayi.TabIndex = 12;
            this.cmbBayi.Text = "Bayi Seçiniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Malın Değeri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Malın Kur Değeri";
            // 
            // txtMDeger
            // 
            this.txtMDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMDeger.Location = new System.Drawing.Point(204, 285);
            this.txtMDeger.Mask = "0000000000000";
            this.txtMDeger.Name = "txtMDeger";
            this.txtMDeger.Size = new System.Drawing.Size(145, 30);
            this.txtMDeger.TabIndex = 11;
            this.txtMDeger.ValidatingType = typeof(int);
            // 
            // txtMalKurDeger
            // 
            this.txtMalKurDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalKurDeger.Location = new System.Drawing.Point(204, 341);
            this.txtMalKurDeger.Name = "txtMalKurDeger";
            this.txtMalKurDeger.Size = new System.Drawing.Size(145, 30);
            this.txtMalKurDeger.TabIndex = 11;
            // 
            // txtGFis
            // 
            this.txtGFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGFis.Location = new System.Drawing.Point(204, 117);
            this.txtGFis.Mask = "00000";
            this.txtGFis.Name = "txtGFis";
            this.txtGFis.Size = new System.Drawing.Size(145, 30);
            this.txtGFis.TabIndex = 11;
            this.txtGFis.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(370, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(930, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(510, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(790, 563);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(650, 563);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 38);
            this.button5.TabIndex = 15;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.cmbFaturaBayi);
            this.groupBox1.Controls.Add(this.cmbKFaturaCins);
            this.groupBox1.Controls.Add(this.txtFaturaTarihi);
            this.groupBox1.Controls.Add(this.chkBayi);
            this.groupBox1.Controls.Add(this.chkFaturacins);
            this.groupBox1.Controls.Add(this.chkFaturaTarih);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(370, 609);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Kayıt Arama";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(320, 63);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(195, 41);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbFaturaBayi
            // 
            this.cmbFaturaBayi.Enabled = false;
            this.cmbFaturaBayi.FormattingEnabled = true;
            this.cmbFaturaBayi.Location = new System.Drawing.Point(661, 25);
            this.cmbFaturaBayi.Name = "cmbFaturaBayi";
            this.cmbFaturaBayi.Size = new System.Drawing.Size(141, 33);
            this.cmbFaturaBayi.TabIndex = 5;
            // 
            // cmbKFaturaCins
            // 
            this.cmbKFaturaCins.Enabled = false;
            this.cmbKFaturaCins.FormattingEnabled = true;
            this.cmbKFaturaCins.Location = new System.Drawing.Point(436, 24);
            this.cmbKFaturaCins.Name = "cmbKFaturaCins";
            this.cmbKFaturaCins.Size = new System.Drawing.Size(141, 33);
            this.cmbKFaturaCins.TabIndex = 4;
            // 
            // txtFaturaTarihi
            // 
            this.txtFaturaTarihi.Enabled = false;
            this.txtFaturaTarihi.Location = new System.Drawing.Point(153, 27);
            this.txtFaturaTarihi.Mask = "00/00/0000";
            this.txtFaturaTarihi.Name = "txtFaturaTarihi";
            this.txtFaturaTarihi.Size = new System.Drawing.Size(141, 30);
            this.txtFaturaTarihi.TabIndex = 3;
            this.txtFaturaTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // chkBayi
            // 
            this.chkBayi.AutoSize = true;
            this.chkBayi.Location = new System.Drawing.Point(583, 29);
            this.chkBayi.Name = "chkBayi";
            this.chkBayi.Size = new System.Drawing.Size(72, 29);
            this.chkBayi.TabIndex = 2;
            this.chkBayi.Text = "Bayi";
            this.chkBayi.UseVisualStyleBackColor = true;
            this.chkBayi.CheckedChanged += new System.EventHandler(this.chkBayi_CheckedChanged);
            // 
            // chkFaturacins
            // 
            this.chkFaturacins.AutoSize = true;
            this.chkFaturacins.Location = new System.Drawing.Point(300, 29);
            this.chkFaturacins.Name = "chkFaturacins";
            this.chkFaturacins.Size = new System.Drawing.Size(139, 29);
            this.chkFaturacins.TabIndex = 1;
            this.chkFaturacins.Text = "Fatura Cinsi";
            this.chkFaturacins.UseVisualStyleBackColor = true;
            this.chkFaturacins.CheckedChanged += new System.EventHandler(this.chkFaturacins_CheckedChanged);
            // 
            // chkFaturaTarih
            // 
            this.chkFaturaTarih.AutoSize = true;
            this.chkFaturaTarih.Location = new System.Drawing.Point(6, 29);
            this.chkFaturaTarih.Name = "chkFaturaTarih";
            this.chkFaturaTarih.Size = new System.Drawing.Size(144, 29);
            this.chkFaturaTarih.TabIndex = 0;
            this.chkFaturaTarih.Text = "Fatura Tarihi";
            this.chkFaturaTarih.UseVisualStyleBackColor = true;
            this.chkFaturaTarih.CheckedChanged += new System.EventHandler(this.chkFaturaTarih_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtAranan);
            this.groupBox2.Controls.Add(this.lblArananAlan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1202, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 211);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Arama";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(178, 168);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(152, 30);
            this.txtAranan.TabIndex = 4;
            this.txtAranan.TextChanged += new System.EventHandler(this.txtAranan_TextChanged);
            // 
            // lblArananAlan
            // 
            this.lblArananAlan.AutoSize = true;
            this.lblArananAlan.Location = new System.Drawing.Point(29, 168);
            this.lblArananAlan.Name = "lblArananAlan";
            this.lblArananAlan.Size = new System.Drawing.Size(61, 25);
            this.lblArananAlan.TabIndex = 3;
            this.lblArananAlan.Text = "Bayi :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radDeger);
            this.groupBox3.Controls.Add(this.radBayi);
            this.groupBox3.Location = new System.Drawing.Point(10, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçimi";
            // 
            // radDeger
            // 
            this.radDeger.AutoSize = true;
            this.radDeger.Location = new System.Drawing.Point(189, 39);
            this.radDeger.Name = "radDeger";
            this.radDeger.Size = new System.Drawing.Size(142, 29);
            this.radDeger.TabIndex = 1;
            this.radDeger.TabStop = true;
            this.radDeger.Text = "Malın Değeri";
            this.radDeger.UseVisualStyleBackColor = true;
            this.radDeger.CheckedChanged += new System.EventHandler(this.radDeger_CheckedChanged);
            // 
            // radBayi
            // 
            this.radBayi.AutoSize = true;
            this.radBayi.Location = new System.Drawing.Point(6, 39);
            this.radBayi.Name = "radBayi";
            this.radBayi.Size = new System.Drawing.Size(71, 29);
            this.radBayi.TabIndex = 0;
            this.radBayi.TabStop = true;
            this.radBayi.Text = "Bayi";
            this.radBayi.UseVisualStyleBackColor = true;
            this.radBayi.CheckedChanged += new System.EventHandler(this.radBayi_CheckedChanged);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(178, 28);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(152, 33);
            this.cmbAramaTuru.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Arama Türü";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(1070, 563);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 38);
            this.button6.TabIndex = 18;
            this.button6.Text = "Rapor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1575, 759);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBayi);
            this.Controls.Add(this.cmbFaturaCins);
            this.Controls.Add(this.txtUrunAgirlik);
            this.Controls.Add(this.txtGirisTarih);
            this.Controls.Add(this.txtKurTarih);
            this.Controls.Add(this.txtMalKurDeger);
            this.Controls.Add(this.txtMDeger);
            this.Controls.Add(this.txtVadeT);
            this.Controls.Add(this.txtGFis);
            this.Controls.Add(this.txtFaturaT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgFatura);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.btngeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFatura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btncik;
        private System.Windows.Forms.DataGridView dvgFatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtFaturaT;
        private System.Windows.Forms.MaskedTextBox txtVadeT;
        private System.Windows.Forms.MaskedTextBox txtKurTarih;
        private System.Windows.Forms.ComboBox cmbFaturaCins;
        private System.Windows.Forms.MaskedTextBox txtGirisTarih;
        private System.Windows.Forms.MaskedTextBox txtUrunAgirlik;
        private System.Windows.Forms.ComboBox cmbBayi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtMDeger;
        private System.Windows.Forms.MaskedTextBox txtMalKurDeger;
        private System.Windows.Forms.MaskedTextBox txtGFis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbFaturaBayi;
        private System.Windows.Forms.ComboBox cmbKFaturaCins;
        private System.Windows.Forms.MaskedTextBox txtFaturaTarihi;
        private System.Windows.Forms.CheckBox chkBayi;
        private System.Windows.Forms.CheckBox chkFaturacins;
        private System.Windows.Forms.CheckBox chkFaturaTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblArananAlan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radDeger;
        private System.Windows.Forms.RadioButton radBayi;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
    }
}