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
    public partial class frmQuanLyMatHang : Form
    {
        DataSet QLMatHang = new DataSet();
         public bool bname = false;
        public bool bm = false;
        public bool bb = false;
        public bool bsl = false;
        string path;
        SqlConnection conn = new SqlConnection();
        string manager;
        public frmQuanLyMatHang(SqlConnection conn1, string m)
        {
            InitializeComponent();
            path = Environment.CurrentDirectory.Replace(@"F:\lt_window\Giao_dien_phan_mem_update26_11\GiaodienPhanmem\GiaodienPhanmem\bin\Debug", "");
            conn = conn1;
            manager = m;
            Connect c = new Connect();
            conn = c.GetConnect();
        }
        public void LoadDaTaInto_Combobox()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from NhaNSX", conn);
            adp.Fill(QLMatHang, "NhaNSX");
            cmbmansx.DataSource = QLMatHang.Tables["NhaNSX"];
            cmbmansx.DisplayMember = "MaNSX";
            cmbmansx.ValueMember = "MANSX";
            cmbmansx.DataBindings.Clear();
          }

        public void Loaddulieumathang()
        {
            SqlDataAdapter da_khoa = new SqlDataAdapter("select * from MHang", conn);
            da_khoa.Fill(QLMatHang, "MHang");
            dataGridViewHanghoa.DataSource = QLMatHang.Tables["MHang"];
            DataColumn[] key = new DataColumn[1];
            key[0] = QLMatHang.Tables["MHang"].Columns[0];
            QLMatHang.Tables["MHang"].PrimaryKey = key;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  Ngdung where Quyen= N'" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (manager == "Khách hàng")
                {
                    toolStripThem.Visible = toolStripXoa.Visible = toolStripSua.Visible = toolStripLuu.Visible =toolStripHuy.Visible=btnloadhinh.Visible=btnluuhinh.Visible=  false;
                    txtsl.Visible = txtgianhap.Visible = masktxtngaythang.Visible = lblnhap.Visible=lblSLton.Visible=lblngaythang.Visible=lbltien.Visible=false;
                    ContextMenuItemxoa.Visible = ContextMenuItemsua.Visible = false; panelchemathang.Visible = true;
                   reader.Close();
                    conn.Close();
                    return;
                }
                if (manager == "Quản lý")
                {
                   toolStripLuu.Visible =false;
                   toolStripSua.Visible = toolStripXoa.Visible =ContextMenuItemxoa.Visible = ContextMenuItemsua.Visible = true;
                    reader.Close();
                    conn.Close();
                    return;
                }

            }
            reader.Close();
            conn.Close();
        }

        public void Databinging(DataTable pDT)
        {
            txtmahang.DataBindings.Clear();
            txtTenHang.DataBindings.Clear();
            cmbmansx.DataBindings.Clear();
            txttenNSX.DataBindings.Clear();
            txtmadd.DataBindings.Clear();
            txtsl.DataBindings.Clear();
            txtgianhap.DataBindings.Clear();
            txtgiaxuat.DataBindings.Clear();
             masktxtngaythang.DataBindings.Clear();
        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewHanghoa.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        public void ThongKeMatHang_Load(object sender, EventArgs e)
        {
            this.dataGridViewHanghoa.SelectionChanged -= new System.EventHandler(this.dataGridViewHanghoa_SelectionChanged);
            
            // TODO: This line of code loads data into the 'qLDienThDataSet8.MHang' table. You can move, or remove it, as needed.
            this.mHangTableAdapter1.Fill(this.qLDienThDataSet8.MHang);
            // TODO: This line of code loads data into the 'qLDienThDataSet6.DDiem' table. You can move, or remove it, as needed.
            this.dDiemTableAdapter.Fill(this.qLDienThDataSet6.DDiem);
            //do ma nha sx vao combobox
            Loaddulieumathang(); dataGridViewHanghoa.AllowUserToAddRows = false; //LoadDaTaInto_Combobox();
            Tomaudongtrongdatagridview();
             SqlDataAdapter da = new SqlDataAdapter("select * from DDiem", conn);
            da.Fill(QLMatHang, "DDiem");
            DataColumn[] key = new DataColumn[1];
            key[0] = QLMatHang.Tables["DDiem"].Columns[0];
            QLMatHang.Tables["DDiem"].PrimaryKey = key;
            txtmahang.Enabled = txtTenHang.Enabled = cmbmansx.Enabled = txttenNSX.Enabled = txtmadd.Enabled = txtsl.Enabled = txtgianhap.Enabled = txtgiaxuat.Enabled = masktxtngaythang.Enabled = false;
         
        }
        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtslton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridViewHanghoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewHanghoa.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;

        }

        string madd;
        private void dataGridViewHanghoa_Click(object sender, EventArgs e)
        {
            toolStripXoa.Enabled = true;
            toolStripSua.Enabled = true;
            txtmahang.Enabled = txtTenHang.Enabled = cmbmansx.Enabled = txttenNSX.Enabled = txtmadd.Enabled = txtgianhap.Enabled = txtgiaxuat.Enabled = false;
           
            if (dataGridViewHanghoa.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridViewHanghoa.SelectedRows)
                {
                    madd = row.Cells[5].Value.ToString();
                    txtmahang.Text = row.Cells[1].Value.ToString();
                    txtTenHang.Text = row.Cells[2].Value.ToString();
                    cmbmansx.Text = row.Cells[3].Value.ToString();
                    txttenNSX.Text = row.Cells[4].Value.ToString();
                    txtmadd.Text = row.Cells[5].Value.ToString();
                    txtsl.Text = row.Cells[6].Value.ToString();
                    txtgianhap.Text = row.Cells[7].Value.ToString();
                    txtgiaxuat.Text = row.Cells[8].Value.ToString();
                    masktxtngaythang.Text = row.Cells[9].Value.ToString();
                 }
                string selectString = "select * from DDiem where MaDD='" + madd + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectString, conn);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                dataGridViewDacdiem.DataSource = dt1;
                dataGridViewDacdiem.AllowUserToAddRows = false;
                Tomaudongtrongdatagridview();
                cmbmansx.DataBindings.Clear();
                txttenNSX.DataBindings.Clear();
            }
        }
        private void dataGridViewDacdiem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDacdiem.Rows.Count > 0)
            {

                txtmadd.Text = dataGridViewDacdiem.CurrentRow.Cells["maDDDataGridViewTextBoxColumn"].Value.ToString();

            }
            
        }

        string mahang, madacdiem;
        private void toolStripThem_Click(object sender, EventArgs e)
        {
            txtmadd.Enabled = txttenNSX.Enabled = false;
            txtmahang.Enabled = txtTenHang.Enabled  =  txtgianhap.Enabled = txtgiaxuat.Enabled = txtsl.Enabled = masktxtngaythang.Enabled = true;
           LoadDaTaInto_Combobox();
            cmbmansx.Enabled = true;
            cmbmansx.Focus();
            txtmahang.Clear();
            txtTenHang.Clear();
            txttenNSX.Clear();
            txtmadd.Clear();
            txtsl.Clear();
            txtgianhap.Clear();
            txtgiaxuat.Clear();
            masktxtngaythang.Clear();
             foreach (DataGridViewRow row in dataGridViewHanghoa.SelectedRows)
                mahang = row.Cells[1].Value.ToString();
            if (txtmahang.Text == mahang)
            {
                txtsl.Enabled = true;
                masktxtngaythang.Enabled = true;
            }
             Databinging(QLMatHang.Tables["MHang"]);

        }

        private void cmbmansx_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mansx = cmbmansx.SelectedValue.ToString();
            SqlDataAdapter daNSX = new SqlDataAdapter("select * from MHang where  MaNSX='" + mansx + "'", conn);
            daNSX.Fill(dt);
            txttenNSX.DataBindings.Add("Text", dt, "TenNSX");
            dataGridViewHanghoa.DataSource = dt;//do vao datagridview nhung ten sp co ma nsx = 
            txttenNSX.DataBindings.Clear();
            }

        private void dataGridViewHanghoa_SizeChanged(object sender, EventArgs e)
        {

            toolStripSua.Visible = toolStripXoa.Visible = true;
        }

        private void toolStriphuy_Click(object sender, EventArgs e)
        {
            this.mHangBindingSource1.CancelEdit();
             cmbmansx.DataBindings.Clear();
            xuly(false);
        }
        void xuly(bool f)
        {
            txtmahang.Enabled = txtTenHang.Enabled = cmbmansx.Enabled = txttenNSX.Enabled = txtmadd.Enabled =txtsl.Enabled= txtgianhap.Enabled = txtgiaxuat.Enabled =masktxtngaythang.Enabled= f;
            Databinging(QLMatHang.Tables["MHang"]);

        }
        int soluong = 0;
        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            //B1
                foreach (DataGridViewRow row in dataGridViewHanghoa.SelectedRows)
                {
                    mahang = row.Cells[1].Value.ToString();
                    soluong = int.Parse(row.Cells[6].Value.ToString());
                    madacdiem = row.Cells[5].Value.ToString();
                }
                if (txtmahang.Text != mahang)
                {
                    if (txtmahang.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập mã hàng");
                        txtmahang.Focus();
                        return;
                    }
                    if (txtTenHang.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập tên mặt hàng");
                        txtTenHang.Focus();
                        return;
                    }

                    if (txtmadd.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập mã đặc điểm");
                        txtmadd.Focus();
                        return;
                    }
                    if (txtsl.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập số lượng");
                        txtsl.Focus();
                        return;
                    }
                    if (txtgianhap.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập giá nhập");
                        txtgianhap.Focus();
                        return;
                    }
                    if (txtgiaxuat.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập giá xuất");
                        txtgiaxuat.Focus();
                        return;
                    }
                    if (masktxtngaythang.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập ngày tháng nhập");
                        masktxtngaythang.Focus();
                        return;
                    }
                }
                else
                {
                    if (txtsl.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập số lượng");
                        txtsl.Focus();
                        return;
                    }
                    if (masktxtngaythang.Text == string.Empty)
                    {
                        MessageBox.Show("Chưa nhập ngày tháng nhập");
                        masktxtngaythang.Focus();
                        return;
                    }
                }

                //them
                if (txtmahang.Enabled == true)
                {
                    if (txtmahang.Text != mahang)
                    {
                          DataRow insert_New = QLMatHang.Tables["MHang"].NewRow();
                        //B3
                        insert_New["MaMH"] = txtmahang.Text;
                        insert_New["TenMH"] = txtTenHang.Text;
                        insert_New["MaNSX"] = cmbmansx.Text;
                        insert_New["TenNSX"] = txttenNSX.Text;
                        insert_New["MaDD"] = txtmadd.Text;
                        insert_New["SoLuongTon"] = int.Parse(txtsl.Text);
                        insert_New["GiaNhap"] = int.Parse(txtgianhap.Text);
                        insert_New["GiaXuat"] = int.Parse(txtgiaxuat.Text);
                        insert_New["NgayThang"] = DateTime.Parse(masktxtngaythang.Text);
                        //B4
                        QLMatHang.Tables["MHang"].Rows.Add(insert_New);
                    }
                }
                else
                {

                    if (txtTenHang.Enabled == false)
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string updateString = "update MHang set SoLuongTon=" + (int.Parse(txtsl.Text) + soluong) + ",NgayThang='" + masktxtngaythang.Text + "' where MaMH='" + txtmahang.Text + "'";
                        SqlCommand up = new SqlCommand(updateString, conn);
                        up.ExecuteNonQuery();

                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                    }
                    else
                    {
                        // Sửa
                        ////B2
                        DataRow update_New = QLMatHang.Tables["MHang"].Rows.Find(mahang);
                        //B3
                        if (update_New != null)
                        {

                            update_New["TenMH"] = txtTenHang.Text;
                            update_New["MaNSX"] = cmbmansx.Text;
                            update_New["TenNSX"] = txttenNSX.Text;
                            update_New["MaDD"] = txtmadd.Text;
                            update_New["SoLuongTon"] = int.Parse(txtsl.Text);
                            update_New["GiaNhap"] = int.Parse(txtgianhap.Text);
                            update_New["GiaXuat"] = int.Parse(txtgiaxuat.Text);
                            update_New["NgayThang"] =DateTime.Parse( masktxtngaythang.Text);
                        }
                   
                    }
                }

                //B1
                SqlDataAdapter da_mh = new SqlDataAdapter("select * from MHang", conn);

                //b5
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_mh);
                //B6
                da_mh.Update(QLMatHang, "MHang");
                Databinging(QLMatHang.Tables["MHang"]);
                MessageBox.Show("Thành công");
             toolStripLuu.Enabled = false;
             toolStripSua.Visible = toolStripXoa.Visible = true; 
            toolStripLuu.Enabled = true;
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            toolStripLuu.Visible = toolStripHuy.Visible = true;//hien nut
            txtTenHang.Enabled = txtsl.Enabled = txtgianhap.Enabled = txtgiaxuat.Enabled = masktxtngaythang.Enabled = true;
            txtmahang.Enabled = txtmadd.Enabled = cmbmansx.Enabled = txttenNSX.Enabled = false;

        }

        private void txtmadd_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mad = txtmadd.Text.ToString();
            SqlDataAdapter daNSX = new SqlDataAdapter("select * from DDiem where MaDD='" + mad + "'", conn);
            daNSX.Fill(dt);
            dataGridViewDacdiem.DataSource = dt;//do vao datagridview nhung ten sp co ma dd = 
            txtmadd.DataBindings.Clear();
        }
        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dacdiem frm = new Dacdiem(conn, manager);
            frm.madd = dataGridViewDacdiem.CurrentRow.Cells["maDDDataGridViewTextBoxColumn"].Value.ToString();
            frm.tendd = dataGridViewDacdiem.CurrentRow.Cells["tenDDDataGridViewTextBoxColumn"].Value.ToString();
            frm.Thongtin = dataGridViewDacdiem.CurrentRow.Cells["thongtinchungDataGridViewTextBoxColumn"].Value.ToString();
            frm.Chucnang = dataGridViewDacdiem.CurrentRow.Cells["chucnangcobanDataGridViewTextBoxColumn"].Value.ToString();
            frm.Thongsochung = dataGridViewDacdiem.CurrentRow.Cells["thongsochungDataGridViewTextBoxColumn"].Value.ToString();
            frm.Cauhinh = dataGridViewDacdiem.CurrentRow.Cells["cauHinhDataGridViewTextBoxColumn"].Value.ToString();
            paneldd.Controls.Clear();
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            paneldd.Controls.Add(frm);
            paneldd.Show();
       }
        private void MenuItemcapnhat_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from DDiem", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewDacdiem.DataSource = dt;

        }
        private void ContextMenuItemxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            { /// + Nếu đồng ý
                DataTable dt_mh = new DataTable();
                SqlDataAdapter da_mh = new SqlDataAdapter("select * from MHang where MaDD= '" + txtmadd.Text + "'", conn);
                da_mh.Fill(dt_mh);
                if (dt_mh.Rows.Count > 0)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");
                    return;
                }
                //B2
                DataTable dt_dd = new DataTable();
                SqlDataAdapter da_dd = new SqlDataAdapter("select * from DDiem", conn);
                da_dd.Fill(dt_dd);
                DataColumn[] key = new DataColumn[1];
                key[0] = dt_dd.Columns[0];
                dt_dd.PrimaryKey = key;
                DataRow update_New = dt_dd.Rows.Find(txtmadd.Text);
                //B3
                if (update_New != null)
                {
                    update_New.Delete();
                }
                //B5
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_dd);
                //B6
                da_dd.Update(dt_dd);
                MessageBox.Show("Thành công");
            }

        }
        private void ContextMenuItemsua_Click(object sender, EventArgs e)
        {
            Dacdiem frm = new Dacdiem(conn,manager);
            // Sửa
            frm.madd = dataGridViewDacdiem.CurrentRow.Cells["maDDDataGridViewTextBoxColumn"].Value.ToString();
            paneldd.Controls.Clear();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            paneldd.Controls.Add(frm);
            paneldd.Show();
        }
        private void MenuStripcapnhathanghoa_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from MHang", conn);
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            dataGridViewHanghoa.DataSource = dtt;
            txtTenHang.Enabled = txtsl.Enabled = txtgianhap.Enabled = txtgiaxuat.Enabled = masktxtngaythang.Enabled = txtmahang.Enabled = txtmadd.Enabled = cmbmansx.Enabled = txttenNSX.Enabled = false;

        }
       
        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) 
                == System.Windows.Forms.DialogResult.Yes)
            {
                //+ Nếu đồng ý nhi ben nha cung ung ak

                DataTable dt_mathang = new DataTable();
                SqlDataAdapter da_dd = new SqlDataAdapter("select * from NhaNSX where MaNSX= '" + cmbmansx.Text + "'", conn);
                da_dd.Fill(dt_mathang);
                if (dt_mathang.Rows.Count > 0)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");
                    return;
                }
                //B2
                DataRow update_New = QLMatHang.Tables["MHang"].Rows.Find(txtmahang.Text);
                 //B3
                if (update_New != null)
                {
                    
                        update_New.Delete();
                   
                }
                //B5
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_dd);
                //B6
                da_dd.Update(QLMatHang, "MHang");
                MessageBox.Show("Xóa thành công");
            }

        }
       
        private void btnxemhinh_Click(object sender, EventArgs e)
        {
            txtduongdan.Visible = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG Files(*.jpeg)|*.JPEG|PNG Files (*.png)|*.PNG| GIF Files (*.gif)|*.GIF|All File(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = open.FileName;
                txtduongdan.Text = open.FileName;
            }

            }


        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTenHang.Text, "[a-zA-Z]+$"))
            {
                errorProvider1.SetError(txtTenHang, "Cho phép ký tự");
                bname = false;
            }
           
            else
            {
                errorProvider1.Clear();
                bname = true;
            }
        }

        private void txtmahang_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtmahang.Text, "[a-zA-Z]+$"))
            {
                errorProvider1.SetError(txtmahang, "Cho phép ký tự");

            }
           
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
             if (Regex.IsMatch(txtsl.Text, "[^0-9-]+"))
            {
                errorProvider1.SetError(txtsl, "Cho phép nhập số, không có khoảng trắng");
                bsl = false;
            }
            else if (txtsl.Text.Length == 0)
            {
               
                bsl = false;
                txtsl.Text = "";

            }
            else if (txtsl.Text.Length > 10)
            {
                errorProvider1.SetError(txtsl, "Cho phép nhập 10 số");
                bsl = false;
            }
            else
            {
                errorProvider1.Clear();
                bsl = true;

        }
    }

        private void txtgianhap_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtgianhap.Text, "[^0-9-]+"))
            {
                errorProvider1.SetError(txtgianhap, "Cho phép nhập số, không có khoảng trắng");
                bm = false;
            }
            else if (txtgianhap.Text.Length == 0)
            {
                
                bm = false;
                txtgianhap.Text = "";

            }
           
            else
            {
                errorProvider1.Clear();
                bm = true;
            }
        }

        private void txtgiaxuat_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtgiaxuat.Text, "[^0-9-]+"))
            {
                errorProvider1.SetError(txtgiaxuat, "Cho phép nhập số, không có khoảng trắng");
                bb = false;
            }
            else if (txtgiaxuat.Text.Length == 0)
            {
              
                bb = false;
                txtgiaxuat.Text = "";

            }
            
            else
            {
                errorProvider1.Clear();
                bb = true;
            }
        }

        public string ma,ten;
        private void dataGridViewHanghoa_SelectionChanged(object sender, EventArgs e)
        {
             ma = dataGridViewHanghoa.CurrentRow.Cells[1].Value.ToString();
            ten=dataGridViewHanghoa.CurrentRow.Cells[2].Value.ToString();
            SqlDataAdapter da = new SqlDataAdapter("select * from Hinh", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);//tất cả hình
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
           DataRow r = dt.Rows.Find(new string[] { ma });
            if (r != null)
            {
                picture.Image = Image.FromFile(r[1].ToString());
                lblten.Text = ten;
            }
        
        }

        private void frmQuanLyMatHang_Shown(object sender, EventArgs e)
        {
            this.dataGridViewHanghoa.SelectionChanged += new System.EventHandler(this.dataGridViewHanghoa_SelectionChanged);
        }

        private void frmQuanLyMatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void cmbmansx_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mansx = cmbmansx.SelectedValue.ToString();
            SqlDataAdapter daNSX = new SqlDataAdapter("select * from NhaNSX where  MaNSX='" + mansx + "'", conn);
            daNSX.Fill(dt);
            txttenNSX.DataBindings.Add("Text", dt, "TenNSX");
            txttenNSX.DataBindings.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluuhinh_Click(object sender, EventArgs e)
        {
           if (conn.State == ConnectionState.Closed)
                conn.Open();
            string lenh = "insert into Hinh values ('" + txtmahang.Text + "','" + txtduongdan.Text + "')";
            SqlCommand cmd = new SqlCommand(lenh, conn);
            cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
           
           MessageBox.Show("Thành công");
        }

        private void txtsl_Leave(object sender, EventArgs e)
        {
            if (txtsl.Text.Length == 0)
            {
                errorProvider1.SetError(txtsl, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtmahang_Leave(object sender, EventArgs e)
        {
            if (txtmahang.Text.Length == 0)
            {
                errorProvider1.SetError(txtmahang, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtTenHang_Leave(object sender, EventArgs e)
        {
            if (txtTenHang.Text.Length == 0)
            {
                errorProvider1.SetError(txtTenHang, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtgiaxuat_Leave(object sender, EventArgs e)
        {
            if (txtgiaxuat.Text.Length == 0)
            {
                errorProvider1.SetError(txtgiaxuat, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtgianhap_Leave(object sender, EventArgs e)
        {
            if (txtgianhap.Text.Length == 0)
            {
                errorProvider1.SetError(txtgianhap, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void masktxtngaythang_Leave(object sender, EventArgs e)
        {
            if (masktxtngaythang.Text.Length == 0)
            {
                errorProvider1.SetError(masktxtngaythang, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

       
      
        }
}
 