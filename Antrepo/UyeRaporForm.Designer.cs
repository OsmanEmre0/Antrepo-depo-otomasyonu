﻿
namespace Antrepo
{
    partial class UyeRaporForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_usersDataSet = new Antrepo.db_usersDataSet();
            this.KallanıcıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KallanıcıTableAdapter = new Antrepo.db_usersDataSetTableAdapters.KallanıcıTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KallanıcıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KallanıcıBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(588, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KallanıcıBindingSource
            // 
            this.KallanıcıBindingSource.DataMember = "Kallanıcı";
            this.KallanıcıBindingSource.DataSource = this.db_usersDataSet;
            // 
            // KallanıcıTableAdapter
            // 
            this.KallanıcıTableAdapter.ClearBeforeFill = true;
            // 
            // UyeRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UyeRaporForm";
            this.Text = "UyeRaporForm";
            this.Load += new System.EventHandler(this.UyeRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KallanıcıBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KallanıcıBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.KallanıcıTableAdapter KallanıcıTableAdapter;
    }
}