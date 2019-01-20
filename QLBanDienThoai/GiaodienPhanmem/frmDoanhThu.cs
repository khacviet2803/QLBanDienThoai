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
    public partial class frmDoanhThu : Form
    {
        SqlConnection con = new SqlConnection();
        public frmDoanhThu()
        {
            InitializeComponent();
            Connect c = new Connect();
            con = c.GetConnect();
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewdoanhthu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewdoanhthu.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;
        }
        public void tinhtongsp()
        {
            int sp = dataGridViewdoanhthu.Rows.Count;
            txttongsp.Text = sp.ToString();
        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewdoanhthu.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select MHang.MaMH,MHang.TenMH,HDonBan.SoLuong,NhaNSX.TenNSX,HDonBan.TongTien,HDonBan.NgayCuoiTT from MHang,NhaNSX,HDonBan where NhaNSX.MaNSX=MHang.MaNSX AND MHang.MaMH=HDonBan.MaMH ", con);
            da.Fill(dt);
            dataGridViewdoanhthu.DataSource = dt;
            dataGridViewdoanhthu.AllowUserToAddRows = false;
            tinhtongsp();
            int tong = 0; int tien = dataGridViewdoanhthu.Rows.Count;
            for (int i = 0; i < tien; i++)
            {
                tong += int.Parse(dataGridViewdoanhthu.Rows[i].Cells["coTien"].Value.ToString());
            }
            txttongtien.Text = tong.ToString();
            Tomaudongtrongdatagridview();
        }

      
    }
}
