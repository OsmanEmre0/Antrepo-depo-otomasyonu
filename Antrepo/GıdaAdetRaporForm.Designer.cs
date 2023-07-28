
namespace Antrepo
{
    partial class GıdaAdetRaporForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.GıdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GıdaTableAdapter = new Antrepo.db_usersDataSetTableAdapters.GıdaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbArama = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GıdaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.GıdaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.GıdaAdetRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1326, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GıdaBindingSource
            // 
            this.GıdaBindingSource.DataMember = "Gıda";
            this.GıdaBindingSource.DataSource = this.db_usersDataSet;
            // 
            // GıdaTableAdapter
            // 
            this.GıdaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geliş Yeri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbArama
            // 
            this.cmbArama.FormattingEnabled = true;
            this.cmbArama.Items.AddRange(new object[] {
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
            this.cmbArama.Location = new System.Drawing.Point(159, 679);
            this.cmbArama.Name = "cmbArama";
            this.cmbArama.Size = new System.Drawing.Size(121, 24);
            this.cmbArama.TabIndex = 4;
            // 
            // GıdaAdetRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 722);
            this.Controls.Add(this.cmbArama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GıdaAdetRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GıdaAdetRaporForm";
            this.Load += new System.EventHandler(this.GıdaAdetRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GıdaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GıdaBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.GıdaTableAdapter GıdaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbArama;
    }
}