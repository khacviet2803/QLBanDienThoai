namespace GiaodienPhanmem
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.dateTimengayban = new System.Windows.Forms.DateTimePicker();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewBanHang = new System.Windows.Forms.DataGridView();
            this.contextmenucapnhat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripcapnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripcapnhatsua = new System.Windows.Forms.ToolStripMenuItem();
            this.hDonBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet15 = new GiaodienPhanmem.QLDienThDataSet15();
            this.hDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet14 = new GiaodienPhanmem.QLDienThDataSet14();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStritpThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripin = new System.Windows.Forms.ToolStripButton();
            this.toolStripThoat = new System.Windows.Forms.ToolStripButton();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbmakh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbmamh = new System.Windows.Forms.ComboBox();
            this.hDonBanTableAdapter = new GiaodienPhanmem.QLDienThDataSet14TableAdapters.HDonBanTableAdapter();
            this.hDonBanTableAdapter1 = new GiaodienPhanmem.QLDienThDataSet15TableAdapters.HDonBanTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.costt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCuoiTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanHang)).BeginInit();
            this.contextmenucapnhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDonBanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDonBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet14)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimengayban
            // 
            this.dateTimengayban.CustomFormat = "dd/MM/yyyy";
            this.dateTimengayban.Enabled = false;
            this.dateTimengayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimengayban.Location = new System.Drawing.Point(460, 149);
            this.dateTimengayban.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimengayban.MaxDate = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dateTimengayban.MinDate = new System.DateTime(1999, 12, 29, 0, 0, 0, 0);
            this.dateTimengayban.Name = "dateTimengayban";
            this.dateTimengayban.Size = new System.Drawing.Size(149, 20);
            this.dateTimengayban.TabIndex = 36;
            this.dateTimengayban.Value = new System.DateTime(2015, 12, 13, 17, 58, 1, 0);
            this.dateTimengayban.ValueChanged += new System.EventHandler(this.dateTimengayban_ValueChanged);
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.Location = new System.Drawing.Point(460, 114);
            this.txtthanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.Size = new System.Drawing.Size(151, 20);
            this.txtthanhtoan.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(374, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Thanh Toán:";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(460, 81);
            this.txtTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(151, 20);
            this.txtTT.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(374, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tổng Tiền:";
            // 
            // txttenmh
            // 
            this.txttenmh.Location = new System.Drawing.Point(189, 81);
            this.txttenmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(136, 20);
            this.txttenmh.TabIndex = 31;
            // 
            // txttenKH
            // 
            this.txttenKH.Location = new System.Drawing.Point(190, 146);
            this.txttenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(136, 20);
            this.txttenKH.TabIndex = 29;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(188, 15);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(136, 20);
            this.txtMaDH.TabIndex = 28;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(460, 18);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(151, 20);
            this.txtSL.TabIndex = 4;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(374, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(80, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã ĐH:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(80, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(374, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giá Bán";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(80, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tên Mặt Hàng :";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(374, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ngày Bán:";
            // 
            // dataGridViewBanHang
            // 
            this.dataGridViewBanHang.AutoGenerateColumns = false;
            this.dataGridViewBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBanHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costt,
            this.maHDBDataGridViewTextBoxColumn,
            this.maMHDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.tienDTTDataGridViewTextBoxColumn,
            this.ngayCuoiTTDataGridViewTextBoxColumn});
            this.dataGridViewBanHang.ContextMenuStrip = this.contextmenucapnhat;
            this.dataGridViewBanHang.DataSource = this.hDonBanBindingSource1;
            this.dataGridViewBanHang.Location = new System.Drawing.Point(24, 313);
            this.dataGridViewBanHang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBanHang.Name = "dataGridViewBanHang";
            this.dataGridViewBanHang.ReadOnly = true;
            this.dataGridViewBanHang.RowTemplate.Height = 28;
            this.dataGridViewBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBanHang.Size = new System.Drawing.Size(786, 191);
            this.dataGridViewBanHang.TabIndex = 131;
            this.dataGridViewBanHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewBanHang_RowPrePaint);
            this.dataGridViewBanHang.SelectionChanged += new System.EventHandler(this.dataGridViewBanHang_SelectionChanged);
            // 
            // contextmenucapnhat
            // 
            this.contextmenucapnhat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripcapnhat,
            this.ToolStripcapnhatsua});
            this.contextmenucapnhat.Name = "contextmenucapnhat";
            this.contextmenucapnhat.Size = new System.Drawing.Size(148, 48);
            // 
            // ToolStripcapnhat
            // 
            this.ToolStripcapnhat.Name = "ToolStripcapnhat";
            this.ToolStripcapnhat.Size = new System.Drawing.Size(147, 22);
            this.ToolStripcapnhat.Text = "Cập Nhật Lưu";
            this.ToolStripcapnhat.Click += new System.EventHandler(this.ToolStripcapnhat_Click);
            // 
            // ToolStripcapnhatsua
            // 
            this.ToolStripcapnhatsua.Name = "ToolStripcapnhatsua";
            this.ToolStripcapnhatsua.Size = new System.Drawing.Size(147, 22);
            this.ToolStripcapnhatsua.Text = "Cập Nhật Sửa";
            this.ToolStripcapnhatsua.Click += new System.EventHandler(this.ToolStripcapnhatsua_Click);
            // 
            // hDonBanBindingSource1
            // 
            this.hDonBanBindingSource1.DataMember = "HDonBan";
            this.hDonBanBindingSource1.DataSource = this.qLDienThDataSet15;
            // 
            // qLDienThDataSet15
            // 
            this.qLDienThDataSet15.DataSetName = "QLDienThDataSet15";
            this.qLDienThDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDonBanBindingSource
            // 
            this.hDonBanBindingSource.DataMember = "HDonBan";
            this.hDonBanBindingSource.DataSource = this.qLDienThDataSet14;
            // 
            // qLDienThDataSet14
            // 
            this.qLDienThDataSet14.DataSetName = "QLDienThDataSet14";
            this.qLDienThDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(341, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 41);
            this.label1.TabIndex = 130;
            this.label1.Text = "Xuất Hàng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStritpThem,
            this.toolStripXoa,
            this.toolStripSua,
            this.toolStripLuu,
            this.toolStripin,
            this.toolStripThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1269, 31);
            this.toolStrip1.TabIndex = 129;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStritpThem
            // 
            this.toolStritpThem.ForeColor = System.Drawing.Color.Maroon;
            this.toolStritpThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStritpThem.Image")));
            this.toolStritpThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStritpThem.Name = "toolStritpThem";
            this.toolStritpThem.Size = new System.Drawing.Size(58, 28);
            this.toolStritpThem.Text = "&Thêm";
            this.toolStritpThem.Click += new System.EventHandler(this.toolStritpThem_Click);
            // 
            // toolStripXoa
            // 
            this.toolStripXoa.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripXoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripXoa.Image")));
            this.toolStripXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXoa.Name = "toolStripXoa";
            this.toolStripXoa.Size = new System.Drawing.Size(47, 28);
            this.toolStripXoa.Text = "&Xóa";
            this.toolStripXoa.Click += new System.EventHandler(this.toolStripXoa_Click);
            // 
            // toolStripSua
            // 
            this.toolStripSua.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSua.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSua.Image")));
            this.toolStripSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSua.Name = "toolStripSua";
            this.toolStripSua.Size = new System.Drawing.Size(54, 28);
            this.toolStripSua.Text = "&Sửa";
            this.toolStripSua.Click += new System.EventHandler(this.toolStripSua_Click);
            // 
            // toolStripLuu
            // 
            this.toolStripLuu.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripLuu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLuu.Image")));
            this.toolStripLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLuu.Name = "toolStripLuu";
            this.toolStripLuu.Size = new System.Drawing.Size(47, 28);
            this.toolStripLuu.Text = "&Lưu";
            this.toolStripLuu.Click += new System.EventHandler(this.toolStripLuu_Click);
            // 
            // toolStripin
            // 
            this.toolStripin.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripin.Image = global::GiaodienPhanmem.Properties.Resources.tsbPrint;
            this.toolStripin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripin.Name = "toolStripin";
            this.toolStripin.Size = new System.Drawing.Size(37, 28);
            this.toolStripin.Text = "&In";
            this.toolStripin.Click += new System.EventHandler(this.toolStripin_Click);
            // 
            // toolStripThoat
            // 
            this.toolStripThoat.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripThoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripThoat.Image")));
            this.toolStripThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThoat.Name = "toolStripThoat";
            this.toolStripThoat.Size = new System.Drawing.Size(58, 28);
            this.toolStripThoat.Text = "&Thoát";
            this.toolStripThoat.Click += new System.EventHandler(this.toolStripThoat_Click);
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(460, 52);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(151, 20);
            this.txtgiaban.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbmakh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbmamh);
            this.panel1.Controls.Add(this.dateTimengayban);
            this.panel1.Controls.Add(this.txtthanhtoan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txttenmh);
            this.panel1.Controls.Add(this.txttenKH);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtgiaban);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(58, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 205);
            this.panel1.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(80, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 14);
            this.label11.TabIndex = 40;
            this.label11.Text = "Mã Khách Hàng:";
            // 
            // cmbmakh
            // 
            this.cmbmakh.FormattingEnabled = true;
            this.cmbmakh.Location = new System.Drawing.Point(191, 111);
            this.cmbmakh.Name = "cmbmakh";
            this.cmbmakh.Size = new System.Drawing.Size(135, 21);
            this.cmbmakh.TabIndex = 39;
            this.cmbmakh.SelectedIndexChanged += new System.EventHandler(this.cmbmakh_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(80, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 14);
            this.label10.TabIndex = 38;
            this.label10.Text = "Mã Mặt Hàng :";
            // 
            // cmbmamh
            // 
            this.cmbmamh.FormattingEnabled = true;
            this.cmbmamh.Location = new System.Drawing.Point(189, 49);
            this.cmbmamh.Name = "cmbmamh";
            this.cmbmamh.Size = new System.Drawing.Size(135, 21);
            this.cmbmamh.TabIndex = 37;
            this.cmbmamh.SelectedIndexChanged += new System.EventHandler(this.cmbmamh_SelectedIndexChanged);
            // 
            // hDonBanTableAdapter
            // 
            this.hDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // hDonBanTableAdapter1
            // 
            this.hDonBanTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaodienPhanmem.Properties.Resources.images__21_;
            this.pictureBox1.Location = new System.Drawing.Point(891, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // costt
            // 
            this.costt.HeaderText = "STT";
            this.costt.Name = "costt";
            this.costt.ReadOnly = true;
            // 
            // maHDBDataGridViewTextBoxColumn
            // 
            this.maHDBDataGridViewTextBoxColumn.DataPropertyName = "MaHDB";
            this.maHDBDataGridViewTextBoxColumn.HeaderText = "Mã HDB";
            this.maHDBDataGridViewTextBoxColumn.Name = "maHDBDataGridViewTextBoxColumn";
            this.maHDBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "Mã MH";
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            this.maMHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng Tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tienDTTDataGridViewTextBoxColumn
            // 
            this.tienDTTDataGridViewTextBoxColumn.DataPropertyName = "TienDTT";
            this.tienDTTDataGridViewTextBoxColumn.HeaderText = "Thanh Toán";
            this.tienDTTDataGridViewTextBoxColumn.Name = "tienDTTDataGridViewTextBoxColumn";
            this.tienDTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayCuoiTTDataGridViewTextBoxColumn
            // 
            this.ngayCuoiTTDataGridViewTextBoxColumn.DataPropertyName = "NgayCuoiTT";
            this.ngayCuoiTTDataGridViewTextBoxColumn.HeaderText = "Ngày Bán";
            this.ngayCuoiTTDataGridViewTextBoxColumn.Name = "ngayCuoiTTDataGridViewTextBoxColumn";
            this.ngayCuoiTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1269, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewBanHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatHang";
            this.Text = "Chi tiết hợp đồng bán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietHopDongBan_FormClosing);
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanHang)).EndInit();
            this.contextmenucapnhat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hDonBanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDonBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet14)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimengayban;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenmh;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewBanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripThoat;
        private System.Windows.Forms.ToolStripButton toolStripLuu;
        private System.Windows.Forms.ToolStripButton toolStripSua;
        private System.Windows.Forms.ToolStripButton toolStripXoa;
        private System.Windows.Forms.ToolStripButton toolStritpThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbmakh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbmamh;
        private QLDienThDataSet14 qLDienThDataSet14;
        private System.Windows.Forms.BindingSource hDonBanBindingSource;
        private QLDienThDataSet14TableAdapters.HDonBanTableAdapter hDonBanTableAdapter;
        private QLDienThDataSet15 qLDienThDataSet15;
        private System.Windows.Forms.BindingSource hDonBanBindingSource1;
        private QLDienThDataSet15TableAdapters.HDonBanTableAdapter hDonBanTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextmenucapnhat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripcapnhat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripcapnhatsua;
        private System.Windows.Forms.ToolStripButton toolStripin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCuoiTTDataGridViewTextBoxColumn;


    }
}