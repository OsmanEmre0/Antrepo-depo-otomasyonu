﻿
namespace Antrepo
{
    partial class HavaTasitRaporForm
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
            this.HavaTasitiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HavaTasitiTableAdapter = new Antrepo.db_usersDataSetTableAdapters.HavaTasitiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HavaTasitiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HavaTasitiBindingSource
            // 
            this.HavaTasitiBindingSource.DataMember = "HavaTasiti";
            this.HavaTasitiBindingSource.DataSource = this.db_usersDataSet;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 28;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HavaTasitiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.HavaTasit.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1247, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // HavaTasitiTableAdapter
            // 
            this.HavaTasitiTableAdapter.ClearBeforeFill = true;
            // 
            // HavaTasitRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 643);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HavaTasitRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HavaTasitRaporForm";
            this.Load += new System.EventHandler(this.HavaTasitRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HavaTasitiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HavaTasitiBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.HavaTasitiTableAdapter HavaTasitiTableAdapter;
    }
}