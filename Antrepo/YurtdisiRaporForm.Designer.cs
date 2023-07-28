
namespace Antrepo
{
    partial class YurtdisiRaporForm
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
            this.YurtDisisevkiyatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.YurtDisisevkiyatTableAdapter = new Antrepo.db_usersDataSetTableAdapters.YurtDisisevkiyatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.YurtDisisevkiyatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // YurtDisisevkiyatBindingSource
            // 
            this.YurtDisisevkiyatBindingSource.DataMember = "YurtDisisevkiyat";
            this.YurtDisisevkiyatBindingSource.DataSource = this.db_usersDataSet;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.YurtDisisevkiyatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.Yurtdisi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1227, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // YurtDisisevkiyatTableAdapter
            // 
            this.YurtDisisevkiyatTableAdapter.ClearBeforeFill = true;
            // 
            // YurtdisiRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 611);
            this.Controls.Add(this.reportViewer1);
            this.Name = "YurtdisiRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YurtdisiRaporForm";
            this.Load += new System.EventHandler(this.YurtdisiRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YurtDisisevkiyatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource YurtDisisevkiyatBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.YurtDisisevkiyatTableAdapter YurtDisisevkiyatTableAdapter;
    }
}