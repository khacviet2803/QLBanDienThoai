namespace GiaodienPhanmem
{
    partial class frmDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewdoanhthu = new System.Windows.Forms.DataGridView();
            this.costt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripThoat = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongsp = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoanhthu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(423, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 97;
            this.label2.Text = "Doanh Thu";
            // 
            // dataGridViewdoanhthu
            // 
            this.dataGridViewdoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewdoanhthu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewdoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costt,
            this.coTenNSX,
            this.coMaMH,
            this.coTenMH,
            this.coSL,
            this.coTien,
            this.congayban});
            this.dataGridViewdoanhthu.Location = new System.Drawing.Point(55, 90);
            this.dataGridViewdoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewdoanhthu.Name = "dataGridViewdoanhthu";
            this.dataGridViewdoanhthu.ReadOnly = true;
            this.dataGridViewdoanhthu.RowTemplate.Height = 28;
            this.dataGridViewdoanhthu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewdoanhthu.Size = new System.Drawing.Size(808, 304);
            this.dataGridViewdoanhthu.TabIndex = 98;
            this.dataGridViewdoanhthu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewdoanhthu_RowPrePaint);
            // 
            // costt
            // 
            this.costt.HeaderText = "STT";
            this.costt.Name = "costt";
            this.costt.ReadOnly = true;
            // 
            // coTenNSX
            // 
            this.coTenNSX.DataPropertyName = "TenNSX";
            this.coTenNSX.HeaderText = "Tên NSX";
            this.coTenNSX.Name = "coTenNSX";
            this.coTenNSX.ReadOnly = true;
            // 
            // coMaMH
            // 
            this.coMaMH.DataPropertyName = "MaMH";
            this.coMaMH.HeaderText = "Mã MH";
            this.coMaMH.Name = "coMaMH";
            this.coMaMH.ReadOnly = true;
            // 
            // coTenMH
            // 
            this.coTenMH.DataPropertyName = "TenMH";
            this.coTenMH.HeaderText = "Tên MH";
            this.coTenMH.Name = "coTenMH";
            this.coTenMH.ReadOnly = true;
            // 
            // coSL
            // 
            this.coSL.DataPropertyName = "SoLuong";
            this.coSL.HeaderText = "Số Lượng";
            this.coSL.Name = "coSL";
            this.coSL.ReadOnly = true;
            // 
            // coTien
            // 
            this.coTien.DataPropertyName = "TongTien";
            this.coTien.HeaderText = "Thanh Toán";
            this.coTien.Name = "coTien";
            this.coTien.ReadOnly = true;
            // 
            // congayban
            // 
            this.congayban.DataPropertyName = "NgayCuoiTT";
            this.congayban.HeaderText = "Ngày Bán";
            this.congayban.Name = "congayban";
            this.congayban.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(511, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "Tổng Tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(636, 465);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(213, 29);
            this.txttongtien.TabIndex = 100;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1294, 25);
            this.toolStrip1.TabIndex = 133;
            this.toolStrip1.Text = "toolStrip1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(106, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 134;
            this.label3.Text = "Tổng Sản Phẩm";
            // 
            // txttongsp
            // 
            this.txttongsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongsp.Location = new System.Drawing.Point(290, 465);
            this.txttongsp.Name = "txttongsp";
            this.txttongsp.ReadOnly = true;
            this.txttongsp.Size = new System.Drawing.Size(133, 29);
            this.txttongsp.TabIndex = 135;
            this.txttongsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GiaodienPhanmem.Properties.Resources.images__12_;
            this.pictureBox2.Location = new System.Drawing.Point(943, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 137;
            this.pictureBox2.TabStop = false;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1294, 546);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txttongsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewdoanhthu);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoanhthu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewdoanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn costt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn coMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn congayban;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}