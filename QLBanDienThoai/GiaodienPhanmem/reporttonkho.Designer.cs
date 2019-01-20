namespace GiaodienPhanmem
{
    partial class frmreporttonkho
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
            this.QLDienThDataSet5 = new GiaodienPhanmem.QLDienThDataSet5();
            this.MHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MHangTableAdapter = new GiaodienPhanmem.QLDienThDataSet5TableAdapters.MHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDienThDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GiaodienPhanmem.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(955, 741);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLDienThDataSet5
            // 
            this.QLDienThDataSet5.DataSetName = "QLDienThDataSet5";
            this.QLDienThDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MHangBindingSource
            // 
            this.MHangBindingSource.DataMember = "MHang";
            this.MHangBindingSource.DataSource = this.QLDienThDataSet5;
            // 
            // MHangTableAdapter
            // 
            this.MHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmreporttonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 741);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmreporttonkho";
            this.Text = "reporttonkho";
            this.Load += new System.EventHandler(this.reporttonkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDienThDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MHangBindingSource;
        private QLDienThDataSet5 QLDienThDataSet5;
        private QLDienThDataSet5TableAdapters.MHangTableAdapter MHangTableAdapter;
    }
}