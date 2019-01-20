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
    public partial class frmQuanLyKhachHang : Form
    {
        DataTable dt_KH = new DataTable();
        public SqlConnection con;
        string manager;
        DataSet ds_QLKH = new DataSet();
        public frmQuanLyKhachHang(SqlConnection con1, string m)
        {
            InitializeComponent();
            con = con1;
            manager = m;
            Connect c = new Connect();
            con = c.GetConnect();
        }
       
        int k;
        public string MaTuTang()
        {
            SqlDataAdapter da_Ma = new SqlDataAdapter("select * from KHang", con);
            DataTable dtm = new DataTable();
            da_Ma.Fill(dtm);
            string s = "";
            if (dtm.Rows.Count <= 0)
                s = "KH01";
            else
            {

                s = "KH";
                k = dtm.Rows.Count + 1;
                if (k < 9)
                    s = s + "0";
                s = s + k.ToString();
            }
            return s;
        }
        public void DataBingding(DataTable dt_KH)
        {
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtMail.DataBindings.Clear();

            txtMaKH.DataBindings.Add("Text", dt_KH, "MaKH");
            txtTenKH.DataBindings.Add("Text", dt_KH, "TenKH");
            txtDiaChi.DataBindings.Add("Text", dt_KH, "DiaChi");
            txtSDT.DataBindings.Add("Text", dt_KH, "DienThoai");
            txtMail.DataBindings.Add("Text", dt_KH, "Email");

        }
        public void LoadGrd()
        {
            SqlDataAdapter da_KH = new SqlDataAdapter("select * from KHang", con);
            da_KH.Fill(ds_QLKH, "KHang");
            dvwQLKH.DataSource = ds_QLKH.Tables["KHang"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["KHang"].Columns[0];
            ds_QLKH.Tables["KHang"].PrimaryKey = key;
        }
        private void loaddulieuKH()
        {
            SqlDataAdapter da_khoa = new SqlDataAdapter("select * from KHang", con);
            da_khoa.Fill(ds_QLKH, "KHang");
            dvwQLKH.DataSource = ds_QLKH.Tables["KHang"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLKH.Tables["KHang"].Columns[0];
            ds_QLKH .Tables["KHang"].PrimaryKey = key;
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from  Ngdung where Quyen= N'" + manager + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (manager == "Khách hàng")
                {
                    tipThem.Visible = tipXoa.Visible = tipSua.Visible =  tipLuu.Visible = false;
                    reader.Close();
                    con.Close();
                    return;
                }
                if (manager == "Quản lý")
                {
                    tipThem.Visible = tipXoa.Visible = tipSua.Visible = tipThoat.Visible = true;
                     reader.Close();
                    con.Close();
                    return;
                }

            }


        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dvwQLKH.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'qLDienThDataSet13.KHang' table. You can move, or remove it, as needed.
            this.kHangTableAdapter2.Fill(this.qLDienThDataSet13.KHang);
            //// TODO: This line of code loads data into the 'qLDienThDataSet12.KHang' table. You can move, or remove it, as needed.
            //this.kHangTableAdapter.Fill(this.qLDienThDataSet12.KHang);
            dvwQLKH.AllowUserToAddRows = false;
            loaddulieuKH();
            Tomaudongtrongdatagridview();
            tipLuu.Enabled = false;
            txtMaKH.Enabled = txtTenKH.Enabled = txtMail.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = false;
            DataBingding(ds_QLKH.Tables["KHang"]);

        }

        private void tipThem_Click(object sender, EventArgs e)
        {
            tipXoa.Enabled = false;
            tipSua.Enabled = false;
            tipLuu.Enabled = true;
            txtMaKH.Enabled = txtTenKH.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = txtMail.Enabled = true;
            tipLuu.Visible = tipThoat.Visible = true;

            txtMaKH.Clear();
            txtTenKH.Clear();
            txtMail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMaKH.Text = MaTuTang();
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtMail.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtMaKH.ReadOnly = true;
            txtTenKH.Focus();
        }

        private void frmQuanLyKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng form???", "Câu hỏi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void tipSua_Click(object sender, EventArgs e)
        {
            tipLuu.Enabled = true;
            tipXoa.Enabled = false;
            txtTenKH.Enabled = true;
            txtMaKH.Enabled = false;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMail.Enabled = true;
        }

        private void tipThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
         System.Windows.Forms.DialogResult.Yes)
            {
                //+ Nếu đồng ý

                DataTable dt_ncc = new DataTable();
                SqlDataAdapter da_cc = new SqlDataAdapter("select * from HDonBan where MaKH= '" + txtMaKH.Text + "'", con);
                da_cc.Fill(dt_ncc);
                if (dt_ncc.Rows.Count > 0)
                {


                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");

                    return;
                }
                DataRow update_New = ds_QLKH.Tables["KHang"].Rows.Find(txtMaKH.Text);
                //B3
                if (update_New != null)
                {
                    update_New.Delete();
                }
                //B5
                SqlDataAdapter da = new SqlDataAdapter("select * from KHang", con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                //B6
                da.Update(ds_QLKH, "KHang");
                MessageBox.Show("Thành công");
            }

        }

        private void tipLuu_Click(object sender, EventArgs e)
        {
             if (txtMaKH.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập mã Khách hàng");
                    txtMaKH.Focus();
                    return;
                }
                if (txtTenKH.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập tên Khách hàng");
                    txtTenKH.Focus();
                    return;
                }
                if (txtDiaChi.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập địa chỉ Khách hàng");
                    txtDiaChi.Focus();
                    return;
                }
                if (txtSDT.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập số điện thoại Khách hàng");
                    txtSDT.Focus();
                    return;
                }
                if (txtMail.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập email Khách hàng");
                    txtMail.Focus();
                    return;
                }
                try
                {
             
                //them
                if (txtMaKH.Enabled)
                {
                    DataRow insert_New = ds_QLKH.Tables["KHang"].NewRow();
                    //B3
                    insert_New["MaKH"] = txtMaKH.Text;
                    insert_New["TenKH"] = txtTenKH.Text;
                    insert_New["DiaChi"] = txtDiaChi.Text;
                    insert_New["DienThoai"] = txtSDT.Text;
                    insert_New["Email"] = txtMail.Text;
                    //B4
                    ds_QLKH.Tables["KHang"].Rows.Add(insert_New);
                }
                else
                {
                    // Sửa
                    //B2
                    DataRow update_New = ds_QLKH.Tables["KHang"].Rows.Find(txtMaKH.Text);
                    //B3
                    if (update_New != null)
                    {

                        update_New["TenKH"] = txtTenKH.Text;
                        update_New["DiaChi"] = txtDiaChi.Text;
                        update_New["DienThoai"] = txtSDT.Text;
                        update_New["Email"] = txtMail.Text;

                    }
                }
                //B1
                SqlDataAdapter da_QLKH = new SqlDataAdapter("select * from KHang", con);
                //b5
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_QLKH);
                //B6
                da_QLKH.Update(ds_QLKH, "KHang");
                DataBingding(ds_QLKH.Tables["KHang"]);
                MessageBox.Show("Thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Mã bị trùng");
            }
            tipLuu.Enabled = false;
            tipSua.Enabled = tipXoa.Enabled = true;

            txtDiaChi.Enabled = txtMail.Enabled = txtMaKH.Enabled = txtSDT.Enabled = txtTenKH.Enabled = false;
        }
       
        private void dvwQLKH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dvwQLKH.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 10)
            {
                errorProvider1.SetError(txtSDT, "Cho phép nhập 10 số");
               
            }
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0)
            {
                errorProvider1.SetError(txtMaKH, "Không được trống");
               
            }
            else
            {
                errorProvider1.Clear();
               
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Length == 0)
            {
                errorProvider1.SetError(txtTenKH, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length == 0)
            {
                errorProvider1.SetError(txtSDT, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length == 0)
            {
                errorProvider1.SetError(txtDiaChi, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text.Length == 0)
            {
                errorProvider1.SetError(txtMail, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

      
    }
}
