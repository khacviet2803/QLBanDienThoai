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
    public partial class frmTonKho : Form
    {
        SqlConnection con = new SqlConnection();
        public frmTonKho()
        {
            InitializeComponent();
            Connect c = new Connect();
            con = c.GetConnect();
        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewTonkho.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmTonKho_Load(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select MaMH,TenMH,SoLuongTon,NhaNSX.MaNSX,NhaNSX.TenNSX from MHang,NhaNSX where NhaNSX.MaNSX=MHang.MaNSX ", con);
            da.Fill(dt);
            dataGridViewTonkho.DataSource = dt;
            dataGridViewTonkho.AllowUserToAddRows = false;
            Tomaudongtrongdatagridview();
        }

        private void dataGridViewTonkho_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewTonkho.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripin_Click(object sender, EventArgs e)
        {
            frmreporttonkho f = new frmreporttonkho();
            f.Show();
        }
    }
}
