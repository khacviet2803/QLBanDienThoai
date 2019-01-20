using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GiaodienPhanmem
{
    public partial class frmNhapHang : Form
    {
        DataSet QLNhaphang = new DataSet();
        SqlConnection conn = new SqlConnection();
        public frmNhapHang()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void ChiTietHopDongMua_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng form???", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        int k;
         public string MaTuTang()
        {
            SqlDataAdapter da_Ma = new SqlDataAdapter("select * from HDonMua", conn);
            DataTable dtm = new DataTable();
            da_Ma.Fill(dtm);
            string s = "";
            if (dtm.Rows.Count <= 0)
                s = "HDM01";
            else
            {

                s = "HDM";
                k = dtm.Rows.Count + 1;
                 if (k < 9)
                    s = s + "0";
                s = s + k.ToString();
            }
            return s;
        }
       
        public void LoadDaTaInto_Combobox()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from MHang", conn);
            adp.Fill(QLNhaphang, "MHang");
            cmbmahang.DataSource = QLNhaphang.Tables["MHang"];
            cmbmahang.DisplayMember = "MaMH";
            cmbmahang.ValueMember = "MaMH";
            cmbmahang.DataBindings.Clear();
        }
        private void toolStripThem_Click(object sender, EventArgs e)
        {
            cmbmahang.Enabled=true;
            txtMaDH.Enabled= txtmansx.Enabled=txtSL.Enabled = txtTT.Enabled = txtGiaNhap.Enabled = masktxtngaynhap.Enabled = false;
            txtMaDH.Clear(); txtmansx.Clear(); txttenmathang.Clear();txtGiaNhap.Clear(); txtSL.Clear(); txtTT.Clear(); masktxtngaynhap.Clear();
            txtMaDH.Text = MaTuTang();
            cmbmahang.Focus();
            Databinging(QLNhaphang.Tables["HDonMua"]);
            LoadDaTaInto_Combobox();
        }
        private void loaddulieunhap()
        {
             SqlDataAdapter da_khoa = new SqlDataAdapter("select * from HDonMua", conn);
            da_khoa.Fill(QLNhaphang, "HDonMua");
            dataGridViewnhaphang.DataSource = QLNhaphang.Tables["HDonMua"];
            DataColumn[] key = new DataColumn[1];
            key[0] = QLNhaphang.Tables["HDonMua"].Columns[0];
            QLNhaphang.Tables["HDonMua"].PrimaryKey = key;
           
        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewnhaphang.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Enabled = txtmansx.Enabled =cmbmahang.Enabled=txttenmathang.Enabled= txtSL.Enabled = txtTT.Enabled = txtGiaNhap.Enabled = masktxtngaynhap.Enabled = false;
           // TODO: This line of code loads data into the 'qLDienThDataSet9.HDonMua' table. You can move, or remove it, as needed.
            this.hDonMuaTableAdapter.Fill(this.qLDienThDataSet9.HDonMua);
          loaddulieunhap();
            Databinging(QLNhaphang.Tables["HDonMua"]);
            Tomaudongtrongdatagridview();
        }

        private void cmbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
             string mahang = cmbmahang.SelectedValue.ToString();
            SqlDataAdapter danhap = new SqlDataAdapter("select * from MHang where  MaMH='" + mahang + "'", conn);
            danhap.Fill(dt);
             txtmansx.DataBindings.Add("Text", dt, "MaNSX");
             txtSL.DataBindings.Add("Text", dt, "SoLuongTon");
             txtGiaNhap.DataBindings.Add("Text", dt, "GiaNhap");
             masktxtngaynhap.DataBindings.Add("Text", dt, "NgayThang");
             txttenmathang.DataBindings.Add("Text",dt,"TenMH");
            txtmansx.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtGiaNhap.DataBindings.Clear();
            txttenmathang.DataBindings.Clear();
            masktxtngaynhap.DataBindings.Clear();
        }

        private void dataGridViewnhaphang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewnhaphang.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;

        }
        private void Databinging(DataTable p)
        {
           txtMaDH.DataBindings.Clear();
            cmbmahang.DataBindings.Clear();
            txtmansx.DataBindings.Clear();
            txttenmathang.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtGiaNhap.DataBindings.Clear();
            txtTT.DataBindings.Clear();
            masktxtngaynhap.DataBindings.Clear();
           
        }
        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmansx.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa chọn mã mặt hàng");
                    cmbmahang.Focus();
                }
                DataRow nhap = QLNhaphang.Tables["HDonMua"].NewRow();
                nhap["MaHDM"] = txtMaDH.Text;
                nhap["MaNSX"] = txtmansx.Text;
                nhap["MaMH"] = cmbmahang.Text;
                nhap["SoLuong"] = int.Parse(txtSL.Text);
                nhap["GiaNhap"] = int.Parse(txtGiaNhap.Text);
                nhap["TongTien"] = float.Parse(txtSL.Text) * int.Parse(txtGiaNhap.Text);
                nhap["Ngaynhap"] = DateTime.Parse(masktxtngaynhap.Text);
                QLNhaphang.Tables["HDonMua"].Rows.Add(nhap);
                SqlDataAdapter da_mh = new SqlDataAdapter("select * from HDonMua", conn);

                //b5
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_mh);
                //B6
                da_mh.Update(QLNhaphang, "HDonMua");
                Databinging(QLNhaphang.Tables["HDonMua"]);
                MessageBox.Show("Thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Mã bị trùng ");
            }
        }

        private void dataGridViewnhaphang_SelectionChanged(object sender, EventArgs e)
        {
             txtMaDH.Enabled = txtmansx.Enabled = cmbmahang.Enabled = txtSL.Enabled =txtGiaNhap.Enabled = txtTT.Enabled = masktxtngaynhap.Enabled = false;

             if (dataGridViewnhaphang.Rows.Count > 0)
             {

                 foreach (DataGridViewRow row in dataGridViewnhaphang.SelectedRows)
                 {
                     txtMaDH.Text = row.Cells[1].Value.ToString();
                     txtmansx.Text = row.Cells[2].Value.ToString();
                     cmbmahang.Text = row.Cells[3].Value.ToString();
                     txtSL.Text = row.Cells[4].Value.ToString();
                     txtGiaNhap.Text = row.Cells[5].Value.ToString();
                     txtTT.Text = row.Cells[6].Value.ToString();
                     masktxtngaynhap.Text = DateTime.Parse(row.Cells[7].Value.ToString()).ToString();
                 }
             }
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripin_Click(object sender, EventArgs e)
        {
            report f = new report();
            f.Show();
        }

      
    }
}
