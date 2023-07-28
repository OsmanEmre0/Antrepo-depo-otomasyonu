
namespace Antrepo
{
    partial class MobilyaMarkaRaporForm
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
            this.MobilyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MobilyaTableAdapter = new Antrepo.db_usersDataSetTableAdapters.MobilyaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMobilyaArama = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobilyaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.MobilyaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.MobilyaMarkaRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1291, 588);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MobilyaBindingSource
            // 
            this.MobilyaBindingSource.DataMember = "Mobilya";
            this.MobilyaBindingSource.DataSource = this.db_usersDataSet;
            // 
            // MobilyaTableAdapter
            // 
            this.MobilyaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tür";
            // 
            // cmbMobilyaArama
            // 
            this.cmbMobilyaArama.FormattingEnabled = true;
            this.cmbMobilyaArama.Items.AddRange(new object[] {
            "Koltuk",
            "Sandalye",
            "Sehpa",
            "Masa",
            "Dolap",
            "Gardırop",
            "Yatak",
            "Beşik"});
            this.cmbMobilyaArama.Location = new System.Drawing.Point(157, 629);
            this.cmbMobilyaArama.Name = "cmbMobilyaArama";
            this.cmbMobilyaArama.Size = new System.Drawing.Size(121, 24);
            this.cmbMobilyaArama.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MobilyaMarkaRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMobilyaArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MobilyaMarkaRaporForm";
            this.Text = "MobilyaMarkaRaporForm";
            this.Load += new System.EventHandler(this.MobilyaMarkaRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobilyaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MobilyaBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.MobilyaTableAdapter MobilyaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMobilyaArama;
        private System.Windows.Forms.Button button1;
    }
}