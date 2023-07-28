
namespace Antrepo
{
    partial class ElektronikTürRaporForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.ElektronikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ElektronikTableAdapter = new Antrepo.db_usersDataSetTableAdapters.ElektronikTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarkaArama = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElektronikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.ElektronikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.ElektronikTürRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1324, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ElektronikBindingSource
            // 
            this.ElektronikBindingSource.DataMember = "Elektronik";
            this.ElektronikBindingSource.DataSource = this.db_usersDataSet;
            // 
            // ElektronikTableAdapter
            // 
            this.ElektronikTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // cmbMarkaArama
            // 
            this.cmbMarkaArama.FormattingEnabled = true;
            this.cmbMarkaArama.Items.AddRange(new object[] {
            "Samsung",
            "Bosh",
            "Arçelik",
            "Siemens",
            "Apple",
            "Dyson",
            "Philips",
            "Vestel",
            "Xiaomi",
            "LG",
            "Tefal",
            "Huawei",
            "Arzum",
            "Jbl ",
            "Lenova",
            "Logitech",
            "Gamepower",
            "Rampage",
            "Asus",
            "MSI",
            "Dell",
            "Casper",
            "Monster",
            "Hp",
            "Razer",
            "Oppo",
            "Sony"});
            this.cmbMarkaArama.Location = new System.Drawing.Point(179, 685);
            this.cmbMarkaArama.Name = "cmbMarkaArama";
            this.cmbMarkaArama.Size = new System.Drawing.Size(121, 24);
            this.cmbMarkaArama.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElektronikTürRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMarkaArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ElektronikTürRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElektronikTürRaporForm";
            this.Load += new System.EventHandler(this.ElektronikTürRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElektronikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ElektronikBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.ElektronikTableAdapter ElektronikTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarkaArama;
        private System.Windows.Forms.Button button1;
    }
}