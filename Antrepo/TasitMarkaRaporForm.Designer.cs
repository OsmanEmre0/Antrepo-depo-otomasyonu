
namespace Antrepo
{
    partial class TasitMarkaRaporForm
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
            this.KaraTasitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KaraTasitTableAdapter = new Antrepo.db_usersDataSetTableAdapters.KaraTasitTableAdapter();
            this.Plaka = new System.Windows.Forms.Label();
            this.txtPlakaAra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaraTasitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.KaraTasitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Antrepo.TaşitMarkaRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1349, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_usersDataSet
            // 
            this.db_usersDataSet.DataSetName = "db_usersDataSet";
            this.db_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KaraTasitBindingSource
            // 
            this.KaraTasitBindingSource.DataMember = "KaraTasit";
            this.KaraTasitBindingSource.DataSource = this.db_usersDataSet;
            // 
            // KaraTasitTableAdapter
            // 
            this.KaraTasitTableAdapter.ClearBeforeFill = true;
            // 
            // Plaka
            // 
            this.Plaka.AutoSize = true;
            this.Plaka.Location = new System.Drawing.Point(85, 666);
            this.Plaka.Name = "Plaka";
            this.Plaka.Size = new System.Drawing.Size(43, 17);
            this.Plaka.TabIndex = 1;
            this.Plaka.Text = "Plaka";
            // 
            // txtPlakaAra
            // 
            this.txtPlakaAra.Location = new System.Drawing.Point(184, 663);
            this.txtPlakaAra.Name = "txtPlakaAra";
            this.txtPlakaAra.Size = new System.Drawing.Size(136, 22);
            this.txtPlakaAra.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TasitMarkaRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlakaAra);
            this.Controls.Add(this.Plaka);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TasitMarkaRaporForm";
            this.Text = "TasitMarkaRaporForm";
            this.Load += new System.EventHandler(this.TasitMarkaRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaraTasitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KaraTasitBindingSource;
        private db_usersDataSet db_usersDataSet;
        private db_usersDataSetTableAdapters.KaraTasitTableAdapter KaraTasitTableAdapter;
        private System.Windows.Forms.Label Plaka;
        private System.Windows.Forms.TextBox txtPlakaAra;
        private System.Windows.Forms.Button button1;
    }
}