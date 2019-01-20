namespace GiaodienPhanmem
{
    partial class report
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
            this.QLDienThDataSet9 = new GiaodienPhanmem.QLDienThDataSet9();
            this.HDonMuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HDonMuaTableAdapter = new GiaodienPhanmem.QLDienThDataSet9TableAdapters.HDonMuaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDienThDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDonMuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HDonMuaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GiaodienPhanmem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLDienThDataSet9
            // 
            this.QLDienThDataSet9.DataSetName = "QLDienThDataSet9";
            this.QLDienThDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HDonMuaBindingSource
            // 
            this.HDonMuaBindingSource.DataMember = "HDonMua";
            this.HDonMuaBindingSource.DataSource = this.QLDienThDataSet9;
            // 
            // HDonMuaTableAdapter
            // 
            this.HDonMuaTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 329);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDienThDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDonMuaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HDonMuaBindingSource;
        private QLDienThDataSet9 QLDienThDataSet9;
        private QLDienThDataSet9TableAdapters.HDonMuaTableAdapter HDonMuaTableAdapter;
    }
}