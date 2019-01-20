namespace GiaodienPhanmem
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripin = new System.Windows.Forms.ToolStripButton();
            this.toolStripThoat = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txttenmathang = new System.Windows.Forms.TextBox();
            this.txtmansx = new System.Windows.Forms.TextBox();
            this.cmbmahang = new System.Windows.Forms.ComboBox();
            this.masktxtngaynhap = new System.Windows.Forms.MaskedTextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewnhaphang = new System.Windows.Forms.DataGridView();
            this.costt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDonMuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet9 = new GiaodienPhanmem.QLDienThDataSet9();
            this.label1 = new System.Windows.Forms.Label();
            this.hDonMuaTableAdapter = new GiaodienPhanmem.QLDienThDataSet9TableAdapters.HDonMuaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhaphang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDonMuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripThem,
            this.toolStripLuu,
            this.toolStripin,
            this.toolStripThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 25);
            this.toolStrip1.TabIndex = 133;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripThem
            // 
            this.toolStripThem.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripThem.Image")));
            this.toolStripThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThem.Name = "toolStripThem";
            this.toolStripThem.Size = new System.Drawing.Size(58, 22);
            this.toolStripThem.Text = "&Thêm";
            this.toolStripThem.Click += new System.EventHandler(this.toolStripThem_Click);
            // 
            // toolStripLuu
            // 
            this.toolStripLuu.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripLuu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLuu.Image")));
            this.toolStripLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLuu.Name = "toolStripLuu";
            this.toolStripLuu.Size = new System.Drawing.Size(47, 22);
            this.toolStripLuu.Text = "&Lưu";
            this.toolStripLuu.Click += new System.EventHandler(this.toolStripLuu_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txttenmathang);
            this.panel1.Controls.Add(this.txtmansx);
            this.panel1.Controls.Add(this.cmbmahang);
            this.panel1.Controls.Add(this.masktxtngaynhap);
            this.panel1.Controls.Add(this.txtTT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGiaNhap);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(58, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 163);
            this.panel1.TabIndex = 132;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(42, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 27);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tên Mặt Hàng :";
            // 
            // txttenmathang
            // 
            this.txttenmathang.Location = new System.Drawing.Point(135, 89);
            this.txttenmathang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenmathang.Name = "txttenmathang";
            this.txttenmathang.Size = new System.Drawing.Size(137, 20);
            this.txttenmathang.TabIndex = 30;
            // 
            // txtmansx
            // 
            this.txtmansx.Location = new System.Drawing.Point(135, 120);
            this.txtmansx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmansx.Name = "txtmansx";
            this.txtmansx.Size = new System.Drawing.Size(137, 20);
            this.txtmansx.TabIndex = 31;
            // 
            // cmbmahang
            // 
            this.cmbmahang.FormattingEnabled = true;
            this.cmbmahang.Location = new System.Drawing.Point(135, 59);
            this.cmbmahang.Name = "cmbmahang";
            this.cmbmahang.Size = new System.Drawing.Size(137, 21);
            this.cmbmahang.TabIndex = 29;
            this.cmbmahang.SelectedIndexChanged += new System.EventHandler(this.cmbmahang_SelectedIndexChanged);
            // 
            // masktxtngaynhap
            // 
            this.masktxtngaynhap.Location = new System.Drawing.Point(379, 120);
            this.masktxtngaynhap.Name = "masktxtngaynhap";
            this.masktxtngaynhap.Size = new System.Drawing.Size(151, 20);
            this.masktxtngaynhap.TabIndex = 34;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(379, 89);
            this.txtTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(151, 20);
            this.txtTT.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(309, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tổng Tiền:";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(135, 29);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(136, 20);
            this.txtMaDH.TabIndex = 28;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(379, 31);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(151, 20);
            this.txtSL.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(309, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(42, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã ĐH:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(42, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã NSX :";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(309, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giá Nhập ";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(379, 60);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(151, 20);
            this.txtGiaNhap.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(42, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã Mặt Hàng :";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(309, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ngày Nhập:";
            // 
            // dataGridViewnhaphang
            // 
            this.dataGridViewnhaphang.AutoGenerateColumns = false;
            this.dataGridViewnhaphang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewnhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costt,
            this.maHDMDataGridViewTextBoxColumn,
            this.maNSXDataGridViewTextBoxColumn,
            this.maMHDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngaynhapDataGridViewTextBoxColumn});
            this.dataGridViewnhaphang.DataSource = this.hDonMuaBindingSource;
            this.dataGridViewnhaphang.Location = new System.Drawing.Point(58, 295);
            this.dataGridViewnhaphang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewnhaphang.Name = "dataGridViewnhaphang";
            this.dataGridViewnhaphang.ReadOnly = true;
            this.dataGridViewnhaphang.RowTemplate.Height = 28;
            this.dataGridViewnhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewnhaphang.Size = new System.Drawing.Size(686, 245);
            this.dataGridViewnhaphang.TabIndex = 135;
            this.dataGridViewnhaphang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewnhaphang_RowPrePaint);
            this.dataGridViewnhaphang.SelectionChanged += new System.EventHandler(this.dataGridViewnhaphang_SelectionChanged);
            // 
            // costt
            // 
            this.costt.HeaderText = "STT";
            this.costt.Name = "costt";
            this.costt.ReadOnly = true;
            // 
            // maHDMDataGridViewTextBoxColumn
            // 
            this.maHDMDataGridViewTextBoxColumn.DataPropertyName = "MaHDM";
            this.maHDMDataGridViewTextBoxColumn.HeaderText = "Mã HĐ";
            this.maHDMDataGridViewTextBoxColumn.Name = "maHDMDataGridViewTextBoxColumn";
            this.maHDMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNSXDataGridViewTextBoxColumn
            // 
            this.maNSXDataGridViewTextBoxColumn.DataPropertyName = "MaNSX";
            this.maNSXDataGridViewTextBoxColumn.HeaderText = "Mã NSX";
            this.maNSXDataGridViewTextBoxColumn.Name = "maNSXDataGridViewTextBoxColumn";
            this.maNSXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "Mã MH";
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            this.maMHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "Giá Nhập";
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TổngTiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaynhapDataGridViewTextBoxColumn
            // 
            this.ngaynhapDataGridViewTextBoxColumn.DataPropertyName = "Ngaynhap";
            this.ngaynhapDataGridViewTextBoxColumn.HeaderText = "Ngày Nhập";
            this.ngaynhapDataGridViewTextBoxColumn.Name = "ngaynhapDataGridViewTextBoxColumn";
            this.ngaynhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hDonMuaBindingSource
            // 
            this.hDonMuaBindingSource.DataMember = "HDonMua";
            this.hDonMuaBindingSource.DataSource = this.qLDienThDataSet9;
            // 
            // qLDienThDataSet9
            // 
            this.qLDienThDataSet9.DataSetName = "QLDienThDataSet9";
            this.qLDienThDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(279, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 46);
            this.label1.TabIndex = 134;
            this.label1.Text = "Nhập Hàng";
            // 
            // hDonMuaTableAdapter
            // 
            this.hDonMuaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaodienPhanmem.Properties.Resources.c3_233x300;
            this.pictureBox1.Location = new System.Drawing.Point(846, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1244, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewnhaphang);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapHang";
            this.Text = "Chi tiết hợp đồng mua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietHopDongMua_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhaphang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDonMuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripThem;
        private System.Windows.Forms.ToolStripButton toolStripLuu;
        private System.Windows.Forms.ToolStripButton toolStripThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewnhaphang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox masktxtngaynhap;
        private System.Windows.Forms.ComboBox cmbmahang;
        private QLDienThDataSet9 qLDienThDataSet9;
        private System.Windows.Forms.BindingSource hDonMuaBindingSource;
        private QLDienThDataSet9TableAdapters.HDonMuaTableAdapter hDonMuaTableAdapter;
        private System.Windows.Forms.TextBox txtmansx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttenmathang;
        private System.Windows.Forms.ToolStripButton toolStripin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;

    }
}