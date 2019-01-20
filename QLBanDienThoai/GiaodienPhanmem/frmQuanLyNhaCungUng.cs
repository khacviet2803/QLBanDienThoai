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
using System.Text.RegularExpressions;
namespace GiaodienPhanmem
{
    public partial class frmQuanLyNhaCungUng : Form
    {
        DataTable dt = new DataTable();
        string manager; 
        public bool bten = false;
        public bool bdt = true;
        public bool bemail = true;
        public bool bdiachi = true;
        public SqlConnection conn;
        DataSet dsQLDT = new DataSet();
        public frmQuanLyNhaCungUng(SqlConnection conn1, string m)
        {
            InitializeComponent();
            conn = conn1;
            manager = m;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void ThongKeNhaCungUng_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng form???", "Câu hỏi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        public void Loaddulieunhasx()
        {
            SqlDataAdapter da_khoa = new SqlDataAdapter("select * from NhaNSX", conn);
            da_khoa.Fill(dsQLDT, "NhaNSX");
            dataGridViewNhacungung.DataSource = dsQLDT.Tables["NhaNSX"];
            DataColumn[] key = new DataColumn[1];
            key[0] = dsQLDT.Tables["NhaNSX"].Columns[0];
            dsQLDT.Tables["NhaNSX"].PrimaryKey = key;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  Ngdung where Quyen= N'" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (manager == "Khách hàng")
                {
                    toolStripThem.Visible = toolStripXoa.Visible = toolStripSua.Visible = toolStripLuu.Visible = false;
                    reader.Close();
                    conn.Close();
                    return;
                }
                if (manager == "Quản lý")
                {
                    toolStripXoa.Visible = toolStripSua.Visible = toolStripLuu.Visible = toolStriphuy.Visible = false;
                    reader.Close();
                    conn.Close();
                    return;
                }
                
            }
            
        }
        public void Databinging(DataTable pDT)
        {
            txtma.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtMail.DataBindings.Clear();
            txtSoDT.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtSanPhamCungCap.DataBindings.Clear();

            txtma.DataBindings.Add("Text", pDT, "MaNSX");
            txtTen.DataBindings.Add("Text", pDT, "TenNSX");
            txtMail.DataBindings.Add("Text", pDT, "Email");
            txtSoDT.DataBindings.Add("Text", pDT, "DienThoai");
            txtdiachi.DataBindings.Add("Text", pDT, "Diachi");

        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewNhacungung.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void ThongKeNhaCungUng_Load(object sender, EventArgs e)
        {
            toolStripXoa.Visible = false;
            toolStripSua.Visible = false;
            // TODO: This line of code loads data into the 'qLDienThDataSet1.NhaNSX' table. You can move, or remove it, as needed.
            this.nhaNSXTableAdapter2.Fill(this.qLDienThDataSet1.NhaNSX);
            dataGridViewNhacungung.AllowUserToAddRows = false;
            Loaddulieunhasx();
            Tomaudongtrongdatagridview();
            txtma.Enabled = txtTen.Enabled = txtMail.Enabled = txtSoDT.Enabled = txtdiachi.Enabled = txtSanPhamCungCap.Enabled = false;
            Databinging(dsQLDT.Tables["NhaNSX"]);
        }
        private void dataGridViewNhacungung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewNhacungung.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;
        }

        private void dataGridViewNhacungung_Click(object sender, EventArgs e)
        {
            toolStripXoa.Enabled = true;
            toolStripSua.Enabled = true;
            txtma.Enabled =txtTen.Enabled= txtdiachi.Enabled = txtMail.Enabled = txtSoDT.Enabled = false;
            txtSanPhamCungCap.Clear();
            txtSanPhamCungCap.Text = string.Empty;
            string mancc;
            if (dataGridViewNhacungung.Rows.Count > 0)
            {
                String tenmh = string.Empty;

                foreach (DataGridViewRow row in dataGridViewNhacungung.SelectedRows)
                {
                    mancc = row.Cells[1].Value.ToString();
                    string selectstring = "select *  from MHang where MHang.MaNSX='" + mancc + "' ";
                    SqlDataAdapter adp = new SqlDataAdapter(selectstring, conn);
                    adp.Fill(dt);

                    foreach (DataRow row1 in dt.Rows)
                    {
                        tenmh += row1["TenMH"].ToString() + "\r\n";
                    }
                    txtSanPhamCungCap.Text = tenmh;
                    dt.Rows.Clear();
                }
            }
        }

        private void toolStripThem_Click(object sender, EventArgs e)
        {
            toolStripXoa.Enabled = false;
            toolStripSua.Enabled = false;
            txtma.Enabled = txtTen.Enabled = txtSoDT.Enabled = txtdiachi.Enabled = txtMail.Enabled = true;
            toolStripLuu.Visible = toolStriphuy.Visible = true;

            txtma.Clear();
            txtTen.Clear();
            txtMail.Clear();
            txtSoDT.Clear();
            txtdiachi.Clear();
            txtSanPhamCungCap.Clear();

            txtma.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtMail.DataBindings.Clear();
            txtSoDT.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtSanPhamCungCap.DataBindings.Clear();
            txtma.Focus();
        }

        private void dataGridViewNhacungung_SizeChanged(object sender, EventArgs e)
        {
            if(dataGridViewNhacungung.Rows.Count>5)
            toolStripSua.Visible = toolStripXoa.Visible = true;
       
        }

        private void toolStriphuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            toolStripLuu.Visible = toolStriphuy.Visible = true;//hien nut
             txtTen.Enabled = true;
            txtma.Enabled = false;
            txtSoDT.Enabled = true;
            txtdiachi.Enabled = true;
            txtMail.Enabled = true;
        }

        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
          System.Windows.Forms.DialogResult.Yes)
            {
                //+ Nếu đồng ý

                DataTable dt_ncc = new DataTable();
                SqlDataAdapter da_cc = new SqlDataAdapter("select * from MHang where MaNSX= '" + txtma.Text + "'", conn);
                da_cc.Fill(dt_ncc);
                if (dt_ncc.Rows.Count > 0)
                {


                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");
                    
                    return;
                }
                DataRow update_New = dsQLDT.Tables["NhaNSX"].Rows.Find(txtma.Text);
                //B3
                if (update_New != null)
                {
                    update_New.Delete();
                }
                //B5
                SqlDataAdapter da = new SqlDataAdapter("select * from NhaNSX", conn);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                //B6
                da.Update(dsQLDT,"NhaNSX");
                MessageBox.Show("Thành công");
            }

        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {  
               if (txtma.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập mã nhà cung ứng");
                    txtma.Focus();
                    return;
                }
                if (txtTen.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập tên nhà cung ứng");
                    txtTen.Focus();
                    return;
                }
                if (txtdiachi.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập địa chỉ nhà cung ứng");
                    txtdiachi.Focus();
                    return;
                }
                if (txtSoDT.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập số điện thoại nhà cung ứng");
                    txtSoDT.Focus();
                    return;
                }
                if (txtMail.Text == string.Empty)
                {
                    MessageBox.Show("Chưa nhập email nhà cung ứng");
                    txtMail.Focus();
                    return;
                }
                try
                {
                    // them
                    if (txtma.Enabled == true)
                    {
                        DataRow insert_New = dsQLDT.Tables["NhaNSX"].NewRow();
                        //B3
                        insert_New["MaNSX"] = txtma.Text;
                        insert_New["TenNSX"] = txtTen.Text;
                        insert_New["Diachi"] = txtdiachi.Text;
                        insert_New["DienThoai"] = txtSoDT.Text;
                        insert_New["Email"] = txtMail.Text;
                        //B4
                        dsQLDT.Tables["NhaNSX"].Rows.Add(insert_New);
                    }
                    else
                    {

                        // Sửa
                        ////B2
                        DataRow update_New = dsQLDT.Tables["NhaNSX"].Rows.Find(txtma.Text);
                        //B3
                        if (update_New != null)
                        {

                            update_New["TenNSX"] = txtTen.Text;
                            update_New["Diachi"] = txtdiachi.Text;
                            update_New["DienThoai"] = txtSoDT.Text;
                            update_New["Email"] = txtMail.Text;

                        }

                    }


                    //B1
                    SqlDataAdapter da_nhacc = new SqlDataAdapter("select * from NhaNSX", conn);
                    //b5  
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_nhacc);
                    //B6
                    da_nhacc.Update(dsQLDT, "NhaNSX");
                    Databinging(dsQLDT.Tables["NhaNSX"]);
                    MessageBox.Show("Thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã bị trùng");

                }
            toolStripLuu.Enabled = false;
            toolStripSua.Visible = toolStripXoa.Visible = true;
            toolStripLuu.Enabled = true;
        }
    
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTen.Text, "[a-zA-Z]+$"))
            {
                bten = false;
            }
        }

       
      private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
           
            if (txtSoDT.Text.Length > 10)
            {
                errorProvider1.SetError(txtSoDT,"Cho phép nhập 10 số");
                bdt = false;
            }
           
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMail.Text, @"^[A-z0-9_]+([.][A-z0-9_]+)*([@][A-z0-9_]{3,})+([.][A-z0-9_]+)*[.][A-z]{2,4}$"))
            {
               lblloi.Text="Cho phép dùng ký tự";
                bemail = false;
            }
            
        }

       
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtdiachi_Leave(object sender, EventArgs e)
        {
            if (txtdiachi.Text.Length == 0)
            {
                errorProvider1.SetError(txtdiachi, "Không được trống");
                bdiachi = false;

            }
            else
            {
                errorProvider1.Clear();
                bdiachi = true;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text.Length == 0)
            {
                errorProvider1.SetError(txtMail, "Không được trống");
                bemail = false;
            }
            else
            {
                errorProvider1.Clear();
                bemail = true;
            }
        }

        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if (txtSoDT.Text.Length == 0)
            {
                errorProvider1.SetError(txtSoDT, "Không được trống");
                bdt = false;
            }
            else
            {
                errorProvider1.Clear();
                bdt = true;

            }
        }

        private void txtma_Leave(object sender, EventArgs e)
        {
            if (txtma.Text.Length == 0)
            {
                errorProvider1.SetError(txtma, "Không được trống");
                
            }
            else
            {
                errorProvider1.Clear();
               
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                errorProvider1.SetError(txtTen, "Không được trống");
                bten = false;
            }
            else
            {
                errorProvider1.Clear();
                bten = true;
            }
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtdiachi.Text, @"^[A-z0-9_]+([.][A-z0-9_]+)*([@][A-z0-9_]{3,})+([.][A-z0-9_]+)*[.][A-z]{2,4}$"))
            {
               
                bten = false;
            }
        }

       
    }
}
