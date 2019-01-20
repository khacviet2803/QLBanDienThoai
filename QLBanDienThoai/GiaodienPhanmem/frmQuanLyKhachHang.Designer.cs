namespace GiaodienPhanmem
{
    partial class frmQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachHang));
            this.kHangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet11 = new GiaodienPhanmem.QLDienThDataSet11();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipThem = new System.Windows.Forms.ToolStripButton();
            this.tipXoa = new System.Windows.Forms.ToolStripButton();
            this.tipSua = new System.Windows.Forms.ToolStripButton();
            this.tipLuu = new System.Windows.Forms.ToolStripButton();
            this.tipThoat = new System.Windows.Forms.ToolStripButton();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qLDienThDataSet = new GiaodienPhanmem.QLDienThDataSet();
            this.qLDienThDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaNSXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaNSXTableAdapter = new GiaodienPhanmem.QLDienThDataSetTableAdapters.NhaNSXTableAdapter();
            this.kHangTableAdapter1 = new GiaodienPhanmem.QLDienThDataSet11TableAdapters.KHangTableAdapter();
            this.qLDienThDataSet12 = new GiaodienPhanmem.QLDienThDataSet12();
            this.kHangBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kHangTableAdapter = new GiaodienPhanmem.QLDienThDataSet12TableAdapters.KHangTableAdapter();
            this.kHangBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet13 = new GiaodienPhanmem.QLDienThDataSet13();
            this.kHangTableAdapter2 = new GiaodienPhanmem.QLDienThDataSet13TableAdapters.KHangTableAdapter();
            this.dvwQLKH = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.costt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet11)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvwQLKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kHangBindingSource2
            // 
            this.kHangBindingSource2.DataMember = "KHang";
            this.kHangBindingSource2.DataSource = this.qLDienThDataSet11;
            // 
            // qLDienThDataSet11
            // 
            this.qLDienThDataSet11.DataSetName = "QLDienThDataSet11";
            this.qLDienThDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipThem,
            this.tipXoa,
            this.tipSua,
            this.tipLuu,
            this.tipThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1263, 31);
            this.toolStrip1.TabIndex = 86;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tipThem
            // 
            this.tipThem.ForeColor = System.Drawing.Color.Maroon;
            this.tipThem.Image = ((System.Drawing.Image)(resources.GetObject("tipThem.Image")));
            this.tipThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipThem.Name = "tipThem";
            this.tipThem.Size = new System.Drawing.Size(58, 28);
            this.tipThem.Text = "&Thêm";
            this.tipThem.Click += new System.EventHandler(this.tipThem_Click);
            // 
            // tipXoa
            // 
            this.tipXoa.ForeColor = System.Drawing.Color.Maroon;
            this.tipXoa.Image = ((System.Drawing.Image)(resources.GetObject("tipXoa.Image")));
            this.tipXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipXoa.Name = "tipXoa";
            this.tipXoa.Size = new System.Drawing.Size(47, 28);
            this.tipXoa.Text = "&Xóa";
            this.tipXoa.Click += new System.EventHandler(this.tipXoa_Click);
            // 
            // tipSua
            // 
            this.tipSua.ForeColor = System.Drawing.Color.Maroon;
            this.tipSua.Image = ((System.Drawing.Image)(resources.GetObject("tipSua.Image")));
            this.tipSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipSua.Name = "tipSua";
            this.tipSua.Size = new System.Drawing.Size(54, 28);
            this.tipSua.Text = "&Sửa";
            this.tipSua.Click += new System.EventHandler(this.tipSua_Click);
            // 
            // tipLuu
            // 
            this.tipLuu.ForeColor = System.Drawing.Color.Maroon;
            this.tipLuu.Image = ((System.Drawing.Image)(resources.GetObject("tipLuu.Image")));
            this.tipLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipLuu.Name = "tipLuu";
            this.tipLuu.Size = new System.Drawing.Size(47, 28);
            this.tipLuu.Text = "&Lưu";
            this.tipLuu.Click += new System.EventHandler(this.tipLuu_Click);
            // 
            // tipThoat
            // 
            this.tipThoat.ForeColor = System.Drawing.Color.Maroon;
            this.tipThoat.Image = ((System.Drawing.Image)(resources.GetObject("tipThoat.Image")));
            this.tipThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipThoat.Name = "tipThoat";
            this.tipThoat.Size = new System.Drawing.Size(58, 28);
            this.tipThoat.Text = "&Thoát";
            this.tipThoat.Click += new System.EventHandler(this.tipThoat_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(174, 25);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(133, 20);
            this.txtMaKH.TabIndex = 88;
            this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(398, 58);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(171, 20);
            this.txtMail.TabIndex = 79;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(398, 25);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(171, 20);
            this.txtDiaChi.TabIndex = 78;
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(174, 83);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 20);
            this.txtSDT.TabIndex = 77;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(174, 56);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(133, 20);
            this.txtTenKH.TabIndex = 76;
            this.txtTenKH.Leave += new System.EventHandler(this.txtTenKH_Leave);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(101, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 86;
            this.label8.Text = "Số Điện thoại:";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(343, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 85;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(344, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 84;
            this.label6.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(101, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 82;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(103, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "Họ Tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(87, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(674, 121);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(373, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 45);
            this.label2.TabIndex = 85;
            this.label2.Text = "Khách Hàng";
            // 
            // qLDienThDataSet
            // 
            this.qLDienThDataSet.DataSetName = "QLDienThDataSet";
            this.qLDienThDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDienThDataSetBindingSource
            // 
            this.qLDienThDataSetBindingSource.DataSource = this.qLDienThDataSet;
            this.qLDienThDataSetBindingSource.Position = 0;
            // 
            // nhaNSXBindingSource
            // 
            this.nhaNSXBindingSource.DataMember = "NhaNSX";
            this.nhaNSXBindingSource.DataSource = this.qLDienThDataSetBindingSource;
            // 
            // nhaNSXTableAdapter
            // 
            this.nhaNSXTableAdapter.ClearBeforeFill = true;
            // 
            // kHangTableAdapter1
            // 
            this.kHangTableAdapter1.ClearBeforeFill = true;
            // 
            // qLDienThDataSet12
            // 
            this.qLDienThDataSet12.DataSetName = "QLDienThDataSet12";
            this.qLDienThDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHangBindingSource3
            // 
            this.kHangBindingSource3.DataMember = "KHang";
            this.kHangBindingSource3.DataSource = this.qLDienThDataSet12;
            // 
            // kHangTableAdapter
            // 
            this.kHangTableAdapter.ClearBeforeFill = true;
            // 
            // kHangBindingSource4
            // 
            this.kHangBindingSource4.DataMember = "KHang";
            this.kHangBindingSource4.DataSource = this.qLDienThDataSet13;
            // 
            // qLDienThDataSet13
            // 
            this.qLDienThDataSet13.DataSetName = "QLDienThDataSet13";
            this.qLDienThDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHangTableAdapter2
            // 
            this.kHangTableAdapter2.ClearBeforeFill = true;
            // 
            // dvwQLKH
            // 
            this.dvwQLKH.AutoGenerateColumns = false;
            this.dvwQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvwQLKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvwQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costt,
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dvwQLKH.DataSource = this.kHangBindingSource4;
            this.dvwQLKH.Location = new System.Drawing.Point(12, 252);
            this.dvwQLKH.Name = "dvwQLKH";
            this.dvwQLKH.ReadOnly = true;
            this.dvwQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvwQLKH.Size = new System.Drawing.Size(790, 238);
            this.dvwQLKH.TabIndex = 87;
            this.dvwQLKH.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dvwQLKH_RowPrePaint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaodienPhanmem.Properties.Resources.can_stock_photo_csp12374074;
            this.pictureBox1.Location = new System.Drawing.Point(902, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // kHangBindingSource
            // 
            this.kHangBindingSource.DataMember = "KHang";
            // 
            // kHangBindingSource1
            // 
            this.kHangBindingSource1.DataMember = "KHang";
            // 
            // costt
            // 
            this.costt.HeaderText = "STT";
            this.costt.Name = "costt";
            this.costt.ReadOnly = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            this.dienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1263, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvwQLKH);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "QLKhachhang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet11)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvwQLKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource kHangBindingSource;
        private System.Windows.Forms.ToolStripButton tipThoat;
        private System.Windows.Forms.ToolStripButton tipLuu;
        private System.Windows.Forms.ToolStripButton tipSua;
        private System.Windows.Forms.ToolStripButton tipXoa;
        private System.Windows.Forms.ToolStripButton tipThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource qLDienThDataSetBindingSource;
        private QLDienThDataSet qLDienThDataSet;
        private System.Windows.Forms.BindingSource kHangBindingSource1;
        private System.Windows.Forms.BindingSource nhaNSXBindingSource;
        private QLDienThDataSetTableAdapters.NhaNSXTableAdapter nhaNSXTableAdapter;
        private QLDienThDataSet11 qLDienThDataSet11;
        private System.Windows.Forms.BindingSource kHangBindingSource2;
        private QLDienThDataSet11TableAdapters.KHangTableAdapter kHangTableAdapter1;
        private QLDienThDataSet12 qLDienThDataSet12;
        private System.Windows.Forms.BindingSource kHangBindingSource3;
        private QLDienThDataSet12TableAdapters.KHangTableAdapter kHangTableAdapter;
        private QLDienThDataSet13 qLDienThDataSet13;
        private System.Windows.Forms.BindingSource kHangBindingSource4;
        private QLDienThDataSet13TableAdapters.KHangTableAdapter kHangTableAdapter2;
        private System.Windows.Forms.DataGridView dvwQLKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;

    }
}