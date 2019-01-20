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
    public partial class frmThongKe : Form
    {
        public SqlConnection conn;
        public frmThongKe()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
        }
        private void LoadcmbNhacungung()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhaNSX", conn);
            da.Fill(dt);
            cmbnhacungung.DataSource = dt;
            cmbnhacungung.DisplayMember = "MaNSX";
            cmbnhacungung.ValueMember = "MaNSX";
        }
        private void LoadcmbKhachhang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from KHang", conn);
            da.Fill(dt);
            cmbkhachhang.DataSource = dt;
            cmbkhachhang.DisplayMember = "MaKH";
            cmbkhachhang.ValueMember = "MaKH";
        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridView1.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            LoadcmbKhachhang();
            LoadcmbNhacungung();
            
        }
         private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbnhacungung_SelectedIndexChanged(object sender, EventArgs e)
        {
            comakh.Visible = coTenKH.Visible =coSL.Visible= false;
            DataTable dt = new DataTable();
            string mansx = cmbnhacungung.SelectedValue.ToString();
            SqlDataAdapter daNSX = new SqlDataAdapter("select MaMH,TenMH,SoLuongTon,MaNSX,TenNSX from MHang where  MaNSX='" + mansx + "'", conn);
            daNSX.Fill(dt);
           dataGridView1.DataSource = dt;//do vao datagridview nhung ten sp co ma nsx = 
           Tomaudongtrongdatagridview();
        }

        private void cmbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            colMaNSX.Visible = colTenNSX.Visible = false;
            DataTable dt = new DataTable();
            string makh = cmbkhachhang.SelectedValue.ToString();
            SqlDataAdapter daNSX = new SqlDataAdapter("select MHang.MaMH,MHang.TenMH,KHang.MaKH,KHang.TenKH,SoLuong from MHang,KHang,HDonBan where MHang.MaMH=HDonBan.MaMH And KHang.MaKH=HDonBan.MaKH And  HDonBan.MaKH='" + makh + "'", conn);
            daNSX.Fill(dt);
            dataGridView1.DataSource = dt;
            Tomaudongtrongdatagridview();
        }
    }
}
