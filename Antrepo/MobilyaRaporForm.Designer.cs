
namespace Antrepo
{
    partial class MobilyaRaporForm
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
            this.MobilyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MobilyaTableAdapter = new Antrepo.db_usersDataSetTableAdapters.MobilyaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MobilyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MobilyaBindingSource
            // 
            this.MobilyaBindingSource.DataMember = "Mobilya";
            this.MobilyaBindingSource.DataSource = this.db_usersDataSet;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MobilyaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.Mobilya.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1214, 716);
            this.reportViewer1.TabIndex = 0;
            // 
            // MobilyaTableAdapter
            // 
            this.MobilyaTableAdapter.ClearBeforeFill = true;
            // 
            // MobilyaRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 740);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MobilyaRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobilyaRaporForm";
            this.Load += new System.EventHandler(this.MobilyaRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MobilyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MobilyaBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.MobilyaTableAdapter MobilyaTableAdapter;
    }
}