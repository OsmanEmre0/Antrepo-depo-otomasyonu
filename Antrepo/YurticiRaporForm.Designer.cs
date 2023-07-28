
namespace Antrepo
{
    partial class YurticiRaporForm
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
            this.YurticisevkiyatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.YurticisevkiyatTableAdapter = new Antrepo.db_usersDataSetTableAdapters.YurticisevkiyatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.YurticisevkiyatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // YurticisevkiyatBindingSource
            // 
            this.YurticisevkiyatBindingSource.DataMember = "Yurticisevkiyat";
            this.YurticisevkiyatBindingSource.DataSource = this.db_usersDataSet;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 33;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.YurticisevkiyatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.Yurtİci.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1296, 665);
            this.reportViewer1.TabIndex = 0;
            // 
            // YurticisevkiyatTableAdapter
            // 
            this.YurticisevkiyatTableAdapter.ClearBeforeFill = true;
            // 
            // YurticiRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 689);
            this.Controls.Add(this.reportViewer1);
            this.Name = "YurticiRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YurticiRaporForm";
            this.Load += new System.EventHandler(this.YurticiRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YurticisevkiyatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource YurticisevkiyatBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.YurticisevkiyatTableAdapter YurticisevkiyatTableAdapter;
    }
}