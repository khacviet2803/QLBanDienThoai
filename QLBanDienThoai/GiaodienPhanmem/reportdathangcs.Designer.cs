namespace GiaodienPhanmem
{
    partial class frmreportdathangcs
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
            this.QLDienThDataSet15 = new GiaodienPhanmem.QLDienThDataSet15();
            this.HDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HDonBanTableAdapter = new GiaodienPhanmem.QLDienThDataSet15TableAdapters.HDonBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDienThDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDonBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HDonBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GiaodienPhanmem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1034, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLDienThDataSet15
            // 
            this.QLDienThDataSet15.DataSetName = "QLDienThDataSet15";
            this.QLDienThDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HDonBanBindingSource
            // 
            this.HDonBanBindingSource.DataMember = "HDonBan";
            this.HDonBanBindingSource.DataSource = this.QLDienThDataSet15;
            // 
            // HDonBanTableAdapter
            // 
            this.HDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmreportdathangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 556);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmreportdathangcs";
            this.Text = "reportdathangcs";
            this.Load += new System.EventHandler(this.reportdathangcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDienThDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDonBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HDonBanBindingSource;
        private QLDienThDataSet15 QLDienThDataSet15;
        private QLDienThDataSet15TableAdapters.HDonBanTableAdapter HDonBanTableAdapter;

    }
}