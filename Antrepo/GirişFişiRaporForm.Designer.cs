
namespace Antrepo
{
    partial class GirişFişiRaporForm
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
            this.GirişFişiİşlemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GirişFişiİşlemleriTableAdapter = new Antrepo.db_usersDataSetTableAdapters.GirişFişiİşlemleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GirişFişiİşlemleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GirişFişiİşlemleriBindingSource
            // 
            this.GirişFişiİşlemleriBindingSource.DataMember = "GirişFişiİşlemleri";
            this.GirişFişiİşlemleriBindingSource.DataSource = this.db_usersDataSet;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GirişFişiİşlemleriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.GirisFisi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1246, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // GirişFişiİşlemleriTableAdapter
            // 
            this.GirişFişiİşlemleriTableAdapter.ClearBeforeFill = true;
            // 
            // GirişFişiRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 623);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GirişFişiRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirişFişiRaporForm";
            this.Load += new System.EventHandler(this.GirişFişiRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GirişFişiİşlemleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GirişFişiİşlemleriBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.GirişFişiİşlemleriTableAdapter GirişFişiİşlemleriTableAdapter;
    }
}