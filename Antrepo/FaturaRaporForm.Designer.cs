
namespace Antrepo
{
    partial class FaturaRaporForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FaturaTableAdapter = new Antrepo.db_usersDataSetTableAdapters.FaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FaturaBindingSource
            // 
            this.FaturaBindingSource.DataMember = "Fatura";
            this.FaturaBindingSource.DataSource = this.db_usersDataSet;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FaturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.Fatura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1238, 614);
            this.reportViewer1.TabIndex = 0;
            // 
            // FaturaTableAdapter
            // 
            this.FaturaTableAdapter.ClearBeforeFill = true;
            // 
            // FaturaRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 638);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FaturaRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaRaporForm";
            this.Load += new System.EventHandler(this.FaturaRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FaturaBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.FaturaTableAdapter FaturaTableAdapter;
    }
}