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
    public partial class frmDatHang : Form
    {
        DataSet QLBanhang = new DataSet();
        SqlConnection conn = new SqlConnection();
        string manager;
        public frmDatHang(SqlConnection con1, string m)
        {
            InitializeComponent();
            conn = con1;
            manager = m;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void ChiTietHopDongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng form???", "Câu hỏi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
       
        public void LoadDaTaInto_Combobox()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from MHang", conn);
            adp.Fill(QLBanhang, "MHang");
            cmbmamh.DataSource = QLBanhang.Tables["MHang"];
            cmbmamh.DisplayMember = "MaMH";
            cmbmamh.ValueMember = "MaMH";
            cmbmamh.DataBindings.Clear();
        }
        public void LoadDaTaInto_Combobox1()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from KHang", conn);
            adp.Fill(QLBanhang, "KHang");
            cmbmakh.DataSource = QLBanhang.Tables["KHang"];
            cmbmakh.DisplayMember = "MaKH";
            cmbmakh.ValueMember = "MaKH";
            cmbmakh.DataBindings.Clear();
        }
        private void cmbmamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mahang = cmbmamh.SelectedValue.ToString();
            SqlDataAdapter danhap = new SqlDataAdapter("select * from MHang where  MaMH='" + mahang + "'", conn);
            danhap.Fill(dt);
            txttenmh.DataBindings.Add("Text", dt, "TenMH");
            txtgiaban.DataBindings.Add("Text", dt, "GiaXuat");
             txttenmh.DataBindings.Clear();
             txtgiaban.DataBindings.Clear();
        }
        private void loaddulieuban()
        {
            SqlDataAdapter da_khoa = new SqlDataAdapter("select * from HDonBan", conn);
            da_khoa.Fill(QLBanhang, "HDonBan");
            dataGridViewBanHang.DataSource = QLBanhang.Tables["HDonBan"];
            DataColumn[] key = new DataColumn[2];
            key[0] = QLBanhang.Tables["HDonBan"].Columns[0];
            key[1] = QLBanhang.Tables["HDonBan"].Columns[1];
            QLBanhang.Tables["HDonBan"].PrimaryKey = key;
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           
            SqlCommand cmd = new SqlCommand("select * from  Ngdung where Quyen= N'" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (manager == "Khách hàng")
                {
                    toolStritpThem.Visible = toolStripXoa.Visible = toolStripSua.Visible = toolStripLuu.Visible = toolStripin.Visible = contextmenucapnhat.Visible  = false;
                    reader.Close();
                    conn.Close();
                    return;
                }
                if (manager == "Quản lý")
                {
                    toolStritpThem.Visible = toolStripXoa.Visible = toolStripSua.Visible =toolStripin.Visible= toolStripThoat.Visible = true;
                    reader.Close();
                    conn.Close();
                    return;
                }

            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void Databinging(DataTable p)
        {
            txtMaDH.DataBindings.Clear();
            cmbmamh.DataBindings.Clear();
            txttenmh.DataBindings.Clear();
            cmbmakh.DataBindings.Clear();
            txttenKH.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtgiaban.DataBindings.Clear();
            txtTT.DataBindings.Clear();
            txtthanhtoan.DataBindings.Clear();
            dateTimengayban.DataBindings.Clear();

        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewBanHang.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmDatHang_Load(object sender, EventArgs e)
        {
           
                 // TODO: This line of code loads data into the 'qLDienThDataSet15.HDonBan' table. You can move, or remove it, as needed.
            this.hDonBanTableAdapter1.Fill(this.qLDienThDataSet15.HDonBan);
            txtMaDH.Enabled=cmbmamh.Enabled=txttenmh.Enabled=cmbmakh.Enabled=txttenKH.Enabled=txtSL.Enabled=txtTT.Enabled=txtgiaban.Enabled=txtthanhtoan.Enabled=dateTimengayban.Enabled=false;
              dataGridViewBanHang.AllowUserToAddRows = false;
              loaddulieuban(); LoadDaTaInto_Combobox();
              LoadDaTaInto_Combobox1();
              Tomaudongtrongdatagridview();
            Databinging(QLBanhang.Tables["HDonBan"]);
            if (DateTime.Parse(dateTimengayban.Text) > DateTime.Now)
            {
                MessageBox.Show("Vượt quá số ngày quy định", "Thông báo");
                return;
            }
  }

        private void cmbmakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string mahang = cmbmakh.SelectedValue.ToString();
            SqlDataAdapter danhap = new SqlDataAdapter("select * from KHang where  MaKH='" + mahang + "'", conn);
            danhap.Fill(dt);
            txttenKH.DataBindings.Add("Text", dt, "TenKH");
            txttenKH.DataBindings.Clear();
        }

        private void dataGridViewBanHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            dataGridViewBanHang.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;

        }

        private void toolStritpThem_Click(object sender, EventArgs e)
        {
           
           txttenmh.Enabled = txttenKH.Enabled = txtgiaban.Enabled=txtTT.Enabled=txtthanhtoan.Enabled=false;
           cmbmakh.Enabled = cmbmamh.Enabled = txtSL.Enabled = txtMaDH.Enabled = true;
           toolStripLuu.Enabled = true;
            txtthanhtoan.Text = "0";
            txtTT.Text = "0";
            cmbmamh.Focus();
            Databinging(QLBanhang.Tables["HDonMua"]);
            txtMaDH.Clear(); txtSL.Clear(); txttenmh.Clear(); txttenKH.Clear(); txtgiaban.Clear();
        }

        private void dataGridViewBanHang_SelectionChanged(object sender, EventArgs e)
        {
            txtMaDH.Enabled = cmbmakh.Enabled = cmbmamh.Enabled = txttenmh.Enabled = txttenKH.Enabled = txtTT.Enabled = txtSL.Enabled = txtgiaban.Enabled=txtthanhtoan.Enabled=false;

            if (dataGridViewBanHang.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridViewBanHang.SelectedRows)
                {
                    txtMaDH.Text = row.Cells[1].Value.ToString();
                    cmbmamh.Text = row.Cells[2].Value.ToString();
                    cmbmakh.Text = row.Cells[3].Value.ToString();
                    txtSL.Text = row.Cells[4].Value.ToString();
                    txtgiaban.Text = row.Cells[5].Value.ToString();
                    txtTT.Text = row.Cells[6].Value.ToString();
                    txtthanhtoan.Text = row.Cells[7].Value.ToString();
                    dateTimengayban.Text = row.Cells[8].Value.ToString();
                }
            }
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            
             if (txtMaDH.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập mã đơn hàng");
                    txtMaDH.Focus();
                }
                if (txttenmh.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa chọn mã mặt hàng");
                    cmbmamh.Focus();
                }
                if (txttenKH.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa chọn mã khách hàng");
                    cmbmakh.Focus();
                }
                if (txtSL.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng");
                    txtSL.Focus();
                }
                if (dateTimengayban.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập ngày tháng");
                    dateTimengayban.Focus();
                }
                try
                {
                    if (txtMaDH.Enabled)
                    {
                        DataRow nhap = QLBanhang.Tables["HDonBan"].NewRow();
                        nhap["MaHDB"] = txtMaDH.Text;
                        nhap["MaMH"] = cmbmamh.Text;
                        nhap["MaKH"] = cmbmakh.Text;
                        nhap["SoLuong"] = int.Parse(txtSL.Text);
                        nhap["GiaBan"] = int.Parse(txtgiaban.Text);
                        nhap["TongTien"] = int.Parse(txtSL.Text) * int.Parse(txtgiaban.Text);
                        nhap["TienDTT"] = int.Parse(txtSL.Text) * int.Parse(txtgiaban.Text);
                        nhap["NgayCuoiTT"] = DateTime.Parse(dateTimengayban.Text);
                        QLBanhang.Tables["HDonBan"].Rows.Add(nhap);
                        SqlDataAdapter da_mh = new SqlDataAdapter("select * from HDonBan", conn);
                        //b5
                        SqlCommandBuilder cmb = new SqlCommandBuilder(da_mh);
                        // B6
                        da_mh.Update(QLBanhang, "HDonBan");

                        txtMaDH.Text = dataGridViewBanHang.CurrentRow.Cells[1].Value.ToString();
                        cmbmamh.Text = dataGridViewBanHang.CurrentRow.Cells[2].Value.ToString();
                        cmbmakh.Text = dataGridViewBanHang.CurrentRow.Cells[3].Value.ToString();
                        txtSL.Text = dataGridViewBanHang.CurrentRow.Cells[4].Value.ToString();
                        txtgiaban.Text = dataGridViewBanHang.CurrentRow.Cells[5].Value.ToString();
                        txtTT.Text = dataGridViewBanHang.CurrentRow.Cells[6].Value.ToString();
                        txtthanhtoan.Text = dataGridViewBanHang.CurrentRow.Cells[7].Value.ToString();
                        dateTimengayban.Text = dataGridViewBanHang.CurrentRow.Cells[8].Value.ToString();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter("select * from HDonBan", conn);
                        da.Fill(dt);
                        dataGridViewBanHang.DataSource = dt;
                        Databinging(QLBanhang.Tables["HDonBan"]);

                    }
                    else
                    {
                        DataRow update_New = QLBanhang.Tables["HDonBan"].Rows.Find(new string[] { txtMaDH.Text, cmbmamh.Text });
                        //B3
                        if (update_New != null)
                        {
                            update_New["MaKH"] = cmbmakh.Text;
                            update_New["SoLuong"] = int.Parse(txtSL.Text);
                            update_New["GiaBan"] = int.Parse(txtgiaban.Text);
                            update_New["TongTien"] = float.Parse(txtSL.Text) * int.Parse(txtgiaban.Text);
                            update_New["TienDTT"] = float.Parse(txtSL.Text) * int.Parse(txtgiaban.Text);
                            update_New["NgayCuoiTT"] = DateTime.Parse(dateTimengayban.Text);

                        }

                    }

                    toolStripLuu.Enabled = false;
                    toolStripSua.Enabled = toolStripXoa.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(e.ToString());
                }
            }
         private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
            txtMaDH.Enabled = cmbmamh.Enabled = txttenmh.Enabled = txttenKH.Enabled = txtgiaban.Enabled = txtTT.Enabled = txtthanhtoan.Enabled = dateTimengayban.Enabled = false;
            cmbmakh.Enabled = txtSL.Enabled =true;
            toolStripLuu.Enabled = true;
        }

        private void ToolStripcapnhat_Click(object sender, EventArgs e)
        {
            //cap nhat so luong tai bang mat hang
            if (dataGridViewBanHang.SelectedRows.Count != 0)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int CurrentIndex = dataGridViewBanHang.CurrentCell.RowIndex;
                string mapn = Convert.ToString(dataGridViewBanHang.Rows[CurrentIndex].Cells[1].Value.ToString());
                string mahang = Convert.ToString(dataGridViewBanHang.Rows[CurrentIndex].Cells[2].Value.ToString());
                int sl = int.Parse(dataGridViewBanHang.Rows[CurrentIndex].Cells[4].Value.ToString());
                string laysl = "select SoLuongTon from MHang where MaMH='" + mahang + "'";
                SqlCommand cm = new SqlCommand(laysl, conn);
                int sluong = (int)cm.ExecuteScalar();

                if (sluong - sl < 0)
                {
                    MessageBox.Show("Không Đủ Hàng!");
                    string deletedStr = "Delete HDonBan where MaHDB=N'" + mapn + "' AND MaMH=N'" + mahang + "'";
                    SqlCommand deletedCmd = new SqlCommand(deletedStr, conn);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from HDonBan", conn);
                    da.Fill(dt);
                    dataGridViewBanHang.DataSource = dt;
                    Databinging(QLBanhang.Tables["HDonBan"]);
                }
                else
                {
                     string them = Convert.ToString(sluong - sl);
                    string insertStr1 = "update MHang set SoLuongTon='" + them + "' where MaMH='" + mahang + "'";
                    SqlCommand insertCmd1 = new SqlCommand(insertStr1, conn);
                    insertCmd1.CommandType = CommandType.Text;
                    insertCmd1.ExecuteNonQuery();
                    string caulenh = "select * from HDonBan";
                    SqlCommand CMD = new SqlCommand(caulenh, conn);
                    SqlDataAdapter da = new SqlDataAdapter(caulenh, conn);

                }
                
                MessageBox.Show("Thành công");
                if (conn.State == ConnectionState.Open)
                {
                  
                    conn.Close();
                }
            }
                
        }

        private void toolStripXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
         System.Windows.Forms.DialogResult.Yes)
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    int CurrentIndex = dataGridViewBanHang.CurrentCell.RowIndex;
                    string mapn = Convert.ToString(dataGridViewBanHang.Rows[CurrentIndex].Cells[1].Value.ToString());
                    string mahang = Convert.ToString(dataGridViewBanHang.Rows[CurrentIndex].Cells[2].Value.ToString());

                    int sl = int.Parse(dataGridViewBanHang.Rows[CurrentIndex].Cells[4].Value.ToString());
                    string laysl = "select SoLuongTon from MHang where MaMH='" + mahang + "'";
                    SqlCommand cm = new SqlCommand(laysl, conn);
                    int sluongcu = (int)cm.ExecuteScalar();

                    string slmoi = Convert.ToString(sluongcu + sl);

                    string deletedStr = "Delete HDonBan where MaHDB=N'" + mapn + "' AND MaMH=N'" + mahang + "'";
                    SqlCommand deletedCmd = new SqlCommand(deletedStr, conn);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();


                    string insertStr1 = "update MHang set SoLuongTon='" + slmoi + "' where MaMH='" + mahang + "'";
                    SqlCommand insertCmd1 = new SqlCommand(insertStr1, conn);
                    insertCmd1.CommandType = CommandType.Text;
                    insertCmd1.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

                      txtMaDH.Text = dataGridViewBanHang.CurrentRow.Cells[1].Value.ToString();
                      cmbmamh.Text = dataGridViewBanHang.CurrentRow.Cells[2].Value.ToString();
                      cmbmakh.Text = dataGridViewBanHang.CurrentRow.Cells[3].Value.ToString();
                      txtSL.Text = dataGridViewBanHang.CurrentRow.Cells[4].Value.ToString();
                      txtgiaban.Text = dataGridViewBanHang.CurrentRow.Cells[5].Value.ToString();
                      txtTT.Text = dataGridViewBanHang.CurrentRow.Cells[6].Value.ToString();
                      txtthanhtoan.Text = dataGridViewBanHang.CurrentRow.Cells[7].Value.ToString();
                      dateTimengayban.Text = dataGridViewBanHang.CurrentRow.Cells[8].Value.ToString();

                      DataTable dt = new DataTable();
                      SqlDataAdapter da = new SqlDataAdapter("select * from HDonBan", conn);
                      da.Fill(dt);
                      dataGridViewBanHang.DataSource = dt;
                      Databinging(QLBanhang.Tables["HDonBan"]);
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }

                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
         
        }

       
        private void toolStripin_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            frmreportdathangcs f = new frmreportdathangcs();
            f.Show();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void ToolStripcapnhatsua_Click(object sender, EventArgs e)
        {
           
            if (dataGridViewBanHang.SelectedRows.Count != 0)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int CurrentIndex = dataGridViewBanHang.CurrentCell.RowIndex;
                string mapn = Convert.ToString(dataGridViewBanHang.Rows[CurrentIndex].Cells[1].Value.ToString());
                string mahang = Convert.ToString(dataGridViewBanHang.Rows[CurrentIndex].Cells[2].Value.ToString());
                int sl = int.Parse(dataGridViewBanHang.Rows[CurrentIndex].Cells[4].Value.ToString());
                string layslcu = "select SoLuong from HDonBan where MaHDB='" + mapn + "'";
                SqlCommand cm = new SqlCommand(layslcu, conn);
                int slcu = (int)cm.ExecuteScalar();

                string layslmoi = "select SoLuongTon from MHang where MaMH='" + mahang + "'";
                SqlCommand cmd = new SqlCommand(layslmoi, conn);
                int sluonght = (int)cmd.ExecuteScalar();
                string capnhat = Convert.ToString(slcu - sl + sluonght);

                if ((slcu - sl) + sluonght < 0)
                {
                    MessageBox.Show("Không Đủ Hàng!");
                   DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from HDonBan", conn);
                    da.Fill(dt);
                    dataGridViewBanHang.DataSource = dt;
                    Databinging(QLBanhang.Tables["HDonBan"]);
                    SqlDataAdapter da_mh = new SqlDataAdapter("select * from HDonBan", conn);
                    //b5
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_mh);
                    //B6
                    da_mh.Update(QLBanhang, "HDonBan");
                    string deletedStr = "Delete HDonBan where MaHDB=N'" + mapn + "' AND MaMH=N'" + mahang + "'";
                    SqlCommand deletedCmd = new SqlCommand(deletedStr, conn);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();
                }     
                 else
                {
                   
                    string updateStr = "Update MHang set SoLuongTon= N'" + capnhat + "'where  MaMH=N'" + mahang + "'";
                    SqlCommand updateCmd = new SqlCommand(updateStr, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();
                    SqlDataAdapter da_mh = new SqlDataAdapter("select * from HDonBan", conn);
                    //b5
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_mh);
                    //B6
                    da_mh.Update(QLBanhang, "HDonBan");
                    Databinging(QLBanhang.Tables["HDonBan"]);
                    MessageBox.Show("Thành công");
                }
              
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
               
               
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

      
        private void dateTimengayban_ValueChanged(object sender, EventArgs e)
        {

            if (DateTime.Parse(dateTimengayban.Text) > DateTime.Now)
            {
                MessageBox.Show("Vượt quá số ngày quy định", "Thông báo");
                return;
            }


        }


     }
}
