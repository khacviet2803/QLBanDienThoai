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
    public partial class frmNguoidung : Form
    {
         DataSet QLNgdung = new DataSet();
         SqlConnection conn = new SqlConnection();
        public frmNguoidung()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
        }
        private void loadnguoidung()
        {
            SqlDataAdapter da_khoa = new SqlDataAdapter("select * from Ngdung", conn);
            da_khoa.Fill(QLNgdung, "Ngdung");
            dataGridViewnguoidung.DataSource = QLNgdung.Tables["Ngdung"];
            DataColumn[] key = new DataColumn[1];
            key[0] = QLNgdung.Tables["Ngdung"].Columns[0];
            QLNgdung.Tables["Ngdung"].PrimaryKey = key;
        }
        public void Databinging(DataTable pDT)
        {
            txtgioitinh.DataBindings.Clear();
            txtten.DataBindings.Clear();
            txtquyen.DataBindings.Clear();
            txtuser.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
           
            txtgioitinh.DataBindings.Add("Text", pDT, "Gioitinh");
            txtten.DataBindings.Add("Text", pDT, "Hoten");
            txtquyen.DataBindings.Add("Text", pDT, "Quyen");
            txtuser.DataBindings.Add("Text", pDT, "Username");
            txtsdt.DataBindings.Add("Text", pDT, "DT");

        }
        void Tomaudongtrongdatagridview()
        {
            foreach (DataGridViewRow drv in dataGridViewnguoidung.Rows)
            {
                if (drv.Index % 2 == 0)
                    drv.DefaultCellStyle.BackColor = Color.White;
                else
                    drv.DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }
        private void frmNguoidung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDienThDataSet10.Ngdung' table. You can move, or remove it, as needed.
            this.ngdungTableAdapter.Fill(this.qLDienThDataSet10.Ngdung);
            txtgioitinh.Enabled = txtquyen.Enabled = txtsdt.Enabled = txtten.Enabled = txtuser.Enabled = false;
            loadnguoidung();
            Databinging(QLNgdung.Tables["Ngdung"]);
            dataGridViewnguoidung.AllowUserToAddRows = false;
            Tomaudongtrongdatagridview();
        }

        private void frmNguoidung_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng form???", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void dataGridViewnguoidung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewnguoidung.Rows[e.RowIndex].Cells["costt"].Value = e.RowIndex + 1;
        }
    }
}
