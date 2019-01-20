namespace GiaodienPhanmem
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.dataGridViewTonkho = new System.Windows.Forms.DataGridView();
            this.coSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripin = new System.Windows.Forms.ToolStripButton();
            this.toolStripThoat = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTonkho)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTonkho
            // 
            this.dataGridViewTonkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTonkho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTonkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coSTT,
            this.coMaMH,
            this.coTenMH,
            this.coMaNSX,
            this.coTenNSX,
            this.coSL});
            this.dataGridViewTonkho.Location = new System.Drawing.Point(55, 94);
            this.dataGridViewTonkho.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTonkho.Name = "dataGridViewTonkho";
            this.dataGridViewTonkho.RowTemplate.Height = 28;
            this.dataGridViewTonkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTonkho.Size = new System.Drawing.Size(841, 443);
            this.dataGridViewTonkho.TabIndex = 97;
            this.dataGridViewTonkho.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTonkho_RowPrePaint);
            // 
            // coSTT
            // 
            this.coSTT.HeaderText = "STT";
            this.coSTT.Name = "coSTT";
            // 
            // coMaMH
            // 
            this.coMaMH.DataPropertyName = "MaMH";
            this.coMaMH.HeaderText = "Mã MH";
            this.coMaMH.Name = "coMaMH";
            // 
            // coTenMH
            // 
            this.coTenMH.DataPropertyName = "TenMH";
            this.coTenMH.HeaderText = "Tên MH";
            this.coTenMH.Name = "coTenMH";
            // 
            // coMaNSX
            // 
            this.coMaNSX.DataPropertyName = "MaNSX";
            this.coMaNSX.HeaderText = "Mã NXS";
            this.coMaNSX.Name = "coMaNSX";
            // 
            // coTenNSX
            // 
            this.coTenNSX.DataPropertyName = "TenNSX";
            this.coTenNSX.HeaderText = "Tên NSX";
            this.coTenNSX.Name = "coTenNSX";
            // 
            // coSL
            // 
            this.coSL.DataPropertyName = "SoLuongTon";
            this.coSL.HeaderText = "Số Lượng Tồn";
            this.coSL.Name = "coSL";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(417, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 96;
            this.label2.Text = "Tồn Kho ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripin,
            this.toolStripThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1313, 25);
            this.toolStrip1.TabIndex = 133;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripin
            // 
            this.toolStripin.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripin.Image = global::GiaodienPhanmem.Properties.Resources.tsbPrint;
            this.toolStripin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripin.Name = "toolStripin";
            this.toolStripin.Size = new System.Drawing.Size(37, 22);
            this.toolStripin.Text = "&In";
            this.toolStripin.Click += new System.EventHandler(this.toolStripin_Click);
            // 
            // toolStripThoat
            // 
            this.toolStripThoat.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripThoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripThoat.Image")));
            this.toolStripThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThoat.Name = "toolStripThoat";
            this.toolStripThoat.Size = new System.Drawing.Size(58, 22);
            this.toolStripThoat.Text = "&Thoát";
            this.toolStripThoat.Click += new System.EventHandler(this.toolStripThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaodienPhanmem.Properties.Resources.images__10_;
            this.pictureBox1.Location = new System.Drawing.Point(965, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1313, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewTonkho);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTonKho";
            this.Text = "frmTonKho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTonkho)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTonkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSL;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripThoat;
        private System.Windows.Forms.ToolStripButton toolStripin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}