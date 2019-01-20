namespace GiaodienPhanmem
{
    partial class frmQuanLyNhaCungUng
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhaCungUng));
            this.label8 = new System.Windows.Forms.Label();
            this.txtSanPhamCungCap = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblloi = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.dataGridViewNhacungung = new System.Windows.Forms.DataGridView();
            this.nhaNSXBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet1 = new GiaodienPhanmem.QLDienThDataSet1();
            this.nhaNSXBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDienThDataSet = new GiaodienPhanmem.QLDienThDataSet();
            this.nhaNSXTableAdapter1 = new GiaodienPhanmem.QLDienThDataSetTableAdapters.NhaNSXTableAdapter();
            this.toolStripmenu = new System.Windows.Forms.ToolStrip();
            this.toolStripThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStriphuy = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nhaNSXTableAdapter2 = new GiaodienPhanmem.QLDienThDataSet1TableAdapters.NhaNSXTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nhaNSXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Costt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhacungung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet)).BeginInit();
            this.toolStripmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(322, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Sản Phẩm Cung Cấp:";
            // 
            // txtSanPhamCungCap
            // 
            this.txtSanPhamCungCap.AllowDrop = true;
            this.txtSanPhamCungCap.Location = new System.Drawing.Point(448, 5);
            this.txtSanPhamCungCap.Multiline = true;
            this.txtSanPhamCungCap.Name = "txtSanPhamCungCap";
            this.txtSanPhamCungCap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSanPhamCungCap.Size = new System.Drawing.Size(312, 81);
            this.txtSanPhamCungCap.TabIndex = 6;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(112, 76);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(168, 20);
            this.txtSoDT.TabIndex = 55;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            this.txtSoDT.Leave += new System.EventHandler(this.txtSoDT_Leave);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số Điện Thọai:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(112, 108);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(168, 20);
            this.txtMail.TabIndex = 56;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(386, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Nhà Cung Ứng:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(112, 44);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(168, 20);
            this.txtTen.TabIndex = 54;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(8, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tên Nhà Cung Ứng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblloi);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSanPhamCungCap);
            this.panel1.Controls.Add(this.txtSoDT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 167);
            this.panel1.TabIndex = 24;
            // 
            // lblloi
            // 
            this.lblloi.AutoSize = true;
            this.lblloi.Location = new System.Drawing.Point(8, 141);
            this.lblloi.Name = "lblloi";
            this.lblloi.Size = new System.Drawing.Size(0, 13);
            this.lblloi.TabIndex = 58;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(112, 8);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(168, 20);
            this.txtma.TabIndex = 53;
            this.txtma.Leave += new System.EventHandler(this.txtma_Leave);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(448, 92);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdiachi.Size = new System.Drawing.Size(312, 43);
            this.txtdiachi.TabIndex = 57;
            this.txtdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            this.txtdiachi.Leave += new System.EventHandler(this.txtdiachi_Leave);
            // 
            // dataGridViewNhacungung
            // 
            this.dataGridViewNhacungung.AutoGenerateColumns = false;
            this.dataGridViewNhacungung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhacungung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNhacungung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNhacungung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhacungung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Costt,
            this.DataGridViewTextBoxColumnMa,
            this.DataGridViewTextBoxColumnTen,
            this.DataGridViewTextBoxColumnDiaChi,
            this.DataGridViewTextBoxColumnDT,
            this.DataGridViewTextBoxColumnEmail});
            this.dataGridViewNhacungung.DataSource = this.nhaNSXBindingSource2;
            this.dataGridViewNhacungung.EnableHeadersVisualStyles = false;
            this.dataGridViewNhacungung.Location = new System.Drawing.Point(12, 248);
            this.dataGridViewNhacungung.Name = "dataGridViewNhacungung";
            this.dataGridViewNhacungung.ReadOnly = true;
            this.dataGridViewNhacungung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridViewNhacungung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhacungung.Size = new System.Drawing.Size(764, 150);
            this.dataGridViewNhacungung.TabIndex = 125;
            this.dataGridViewNhacungung.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewNhacungung_RowPrePaint);
            this.dataGridViewNhacungung.SizeChanged += new System.EventHandler(this.dataGridViewNhacungung_SizeChanged);
            this.dataGridViewNhacungung.Click += new System.EventHandler(this.dataGridViewNhacungung_Click);
            // 
            // nhaNSXBindingSource2
            // 
            this.nhaNSXBindingSource2.DataMember = "NhaNSX";
            this.nhaNSXBindingSource2.DataSource = this.qLDienThDataSet1;
            // 
            // qLDienThDataSet1
            // 
            this.qLDienThDataSet1.DataSetName = "QLDienThDataSet1";
            this.qLDienThDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaNSXBindingSource1
            // 
            this.nhaNSXBindingSource1.DataMember = "NhaNSX";
            this.nhaNSXBindingSource1.DataSource = this.qLDienThDataSet;
            // 
            // qLDienThDataSet
            // 
            this.qLDienThDataSet.DataSetName = "QLDienThDataSet";
            this.qLDienThDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaNSXTableAdapter1
            // 
            this.nhaNSXTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStripmenu
            // 
            this.toolStripmenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripThem,
            this.toolStripXoa,
            this.toolStripSua,
            this.toolStripLuu,
            this.toolStriphuy});
            this.toolStripmenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripmenu.Name = "toolStripmenu";
            this.toolStripmenu.Size = new System.Drawing.Size(1230, 31);
            this.toolStripmenu.TabIndex = 126;
            this.toolStripmenu.Text = "toolStrip1";
            // 
            // toolStripThem
            // 
            this.toolStripThem.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripThem.Image")));
            this.toolStripThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThem.Name = "toolStripThem";
            this.toolStripThem.Size = new System.Drawing.Size(58, 28);
            this.toolStripThem.Text = "&Thêm";
            this.toolStripThem.Click += new System.EventHandler(this.toolStripThem_Click);
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
            // toolStriphuy
            // 
            this.toolStriphuy.ForeColor = System.Drawing.Color.Maroon;
            this.toolStriphuy.Image = ((System.Drawing.Image)(resources.GetObject("toolStriphuy.Image")));
            this.toolStriphuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStriphuy.Name = "toolStriphuy";
            this.toolStriphuy.Size = new System.Drawing.Size(58, 28);
            this.toolStriphuy.Text = "&Thoát";
            this.toolStriphuy.Click += new System.EventHandler(this.toolStriphuy_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(405, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 41);
            this.label2.TabIndex = 127;
            this.label2.Text = "Nhà Cung Ứng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nhaNSXTableAdapter2
            // 
            this.nhaNSXTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaodienPhanmem.Properties.Resources.silver_apple_logo_apple_picture1;
            this.pictureBox1.Location = new System.Drawing.Point(868, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // nhaNSXBindingSource
            // 
            this.nhaNSXBindingSource.DataMember = "NhaNSX";
            // 
            // Costt
            // 
            this.Costt.HeaderText = "STT";
            this.Costt.Name = "Costt";
            this.Costt.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnMa
            // 
            this.DataGridViewTextBoxColumnMa.DataPropertyName = "MaNSX";
            this.DataGridViewTextBoxColumnMa.HeaderText = "Mã Nhà Cung Ứng";
            this.DataGridViewTextBoxColumnMa.Name = "DataGridViewTextBoxColumnMa";
            this.DataGridViewTextBoxColumnMa.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnTen
            // 
            this.DataGridViewTextBoxColumnTen.DataPropertyName = "TenNSX";
            this.DataGridViewTextBoxColumnTen.HeaderText = "Tên Nhà Cung Ứng";
            this.DataGridViewTextBoxColumnTen.Name = "DataGridViewTextBoxColumnTen";
            this.DataGridViewTextBoxColumnTen.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnDiaChi
            // 
            this.DataGridViewTextBoxColumnDiaChi.DataPropertyName = "Diachi";
            this.DataGridViewTextBoxColumnDiaChi.HeaderText = "Địa Chỉ";
            this.DataGridViewTextBoxColumnDiaChi.Name = "DataGridViewTextBoxColumnDiaChi";
            this.DataGridViewTextBoxColumnDiaChi.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnDT
            // 
            this.DataGridViewTextBoxColumnDT.DataPropertyName = "DienThoai";
            this.DataGridViewTextBoxColumnDT.HeaderText = "Điện Thoại";
            this.DataGridViewTextBoxColumnDT.Name = "DataGridViewTextBoxColumnDT";
            this.DataGridViewTextBoxColumnDT.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumnEmail
            // 
            this.DataGridViewTextBoxColumnEmail.DataPropertyName = "Email";
            this.DataGridViewTextBoxColumnEmail.HeaderText = "Email";
            this.DataGridViewTextBoxColumnEmail.Name = "DataGridViewTextBoxColumnEmail";
            this.DataGridViewTextBoxColumnEmail.ReadOnly = true;
            // 
            // frmQuanLyNhaCungUng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1230, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStripmenu);
            this.Controls.Add(this.dataGridViewNhacungung);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyNhaCungUng";
            this.Text = "Thống kê nhà cung ứng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongKeNhaCungUng_FormClosing);
            this.Load += new System.EventHandler(this.ThongKeNhaCungUng_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhacungung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDienThDataSet)).EndInit();
            this.toolStripmenu.ResumeLayout(false);
            this.toolStripmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaNSXBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSanPhamCungCap;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.DataGridView dataGridViewNhacungung;
        private System.Windows.Forms.BindingSource nhaNSXBindingSource;
        private QLDienThDataSet qLDienThDataSet;
        private System.Windows.Forms.BindingSource nhaNSXBindingSource1;
        private QLDienThDataSetTableAdapters.NhaNSXTableAdapter nhaNSXTableAdapter1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.ToolStrip toolStripmenu;
        private System.Windows.Forms.ToolStripButton toolStripThem;
        private System.Windows.Forms.ToolStripButton toolStripXoa;
        private System.Windows.Forms.ToolStripButton toolStripSua;
        private System.Windows.Forms.ToolStripButton toolStripLuu;
        private System.Windows.Forms.ToolStripButton toolStriphuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private QLDienThDataSet1 qLDienThDataSet1;
        private System.Windows.Forms.BindingSource nhaNSXBindingSource2;
        private QLDienThDataSet1TableAdapters.NhaNSXTableAdapter nhaNSXTableAdapter2;
        private System.Windows.Forms.Label lblloi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnEmail;
    }
}