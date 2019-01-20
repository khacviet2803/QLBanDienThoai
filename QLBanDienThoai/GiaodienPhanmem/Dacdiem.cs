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
using System.IO;
namespace GiaodienPhanmem
{
    public partial class Dacdiem : Form
    {
        SqlConnection conn = new SqlConnection();
        string manager;
        public Dacdiem(SqlConnection conn1, string m)
        {
            InitializeComponent();
            conn=conn1;
            manager=m;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void Dacdiem_Load(object sender, EventArgs e)
        {
           txtmadd.Enabled =txttendd.Enabled=rtxtthongtinchung.Enabled=rtxtthongsochug.Enabled=rtxtchucnang.Enabled=rtxtcauhinh.Enabled= false;
            txtmadd.Text = madd + "";
            txttendd.Text = tendd + "";
            rtxtthongtinchung.Text = Thongtin + "";
            rtxtchucnang.Text = Chucnang + "";
            rtxtthongsochug.Text = Thongsochung + "";
            rtxtcauhinh.Text = Cauhinh + "";
              conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  Ngdung where Quyen= N'" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (manager == "Khách hàng")
                {
                    toolStripThem.Visible = toolStripSua.Visible =toolStripLuu.Visible= false;
                    reader.Close();
                    conn.Close();
                    return;
                }
                if (manager == "Quản lý")
                {
                    toolStripLuu.Visible = toolStriphuy.Visible = false;
                    reader.Close();
                    conn.Close();
                    return;
                }
            }
            reader.Close();
            conn.Close();
            
        }
        public string madd { get; set; }
        public string tendd{get; set;}
        public string Thongtin{get;set;}
        public string Chucnang{get;set;}
        public string Thongsochung{get;set;}
        public string Cauhinh{get;set;}

        private void toolStriphuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public frmQuanLyMatHang mh;
        

        private void toolStripThem_Click(object sender, EventArgs e)
        {
            txtmadd.Enabled = txttendd.Enabled = rtxtthongtinchung.Enabled = rtxtthongsochug.Enabled = rtxtchucnang.Enabled = rtxtcauhinh.Enabled = true;
           toolStripSua.Enabled = false;
           toolStripLuu.Visible = toolStriphuy.Visible = true;

            txtmadd.Clear();
            txttendd.Clear();
            rtxtthongtinchung.Clear();
            rtxtchucnang.Clear();
            rtxtthongsochug.Clear();
            rtxtcauhinh.Clear();
            txtmadd.Focus();
           
        }

        private void toolStripSua_Click(object sender, EventArgs e)
        {
             txttendd.Enabled = rtxtthongtinchung.Enabled = rtxtthongsochug.Enabled = rtxtchucnang.Enabled = rtxtcauhinh.Enabled = true;
             toolStripLuu.Visible = toolStriphuy.Visible = true;//hien nut
            txttendd.Clear();
            rtxtthongtinchung.Clear();
            rtxtchucnang.Clear();
            rtxtthongsochug.Clear();
            rtxtcauhinh.Clear();
            txttendd.Focus();
           
        }

        private void toolStripLuu_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (txtmadd.Enabled == true)
            {
                SqlCommand cmd = new SqlCommand("insert into DDiem values ('" + txtmadd.Text + "','" + txttendd.Text + "','" + rtxtthongtinchung.Text + "','" + rtxtchucnang.Text + "','" + rtxtthongsochug.Text + "','" + rtxtcauhinh.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");
            }
            else
            {
                 SqlCommand cmd = new SqlCommand("update DDiem set TenDD=N'"  + txttendd.Text + "',Thongtinchung=N'" + rtxtthongtinchung.Text + "',Chucnangcoban=N'" + rtxtchucnang.Text + "',Thongsochung=N'" + rtxtthongsochug.Text + "',CauHinh=N'" + rtxtcauhinh.Text + "'where MaDD='"+txtmadd.Text+"'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            } 
           
        }

        private void txtmadd_Leave(object sender, EventArgs e)
        {
            if (txtmadd.Text.Length == 0)
            {
                errorProvider1.SetError(txtmadd, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txttendd_Leave(object sender, EventArgs e)
        {
            if (txttendd.Text.Length == 0)
            {
                errorProvider1.SetError(txttendd, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void rtxtthongtinchung_Leave(object sender, EventArgs e)
        {
            if (rtxtthongtinchung.Text.Length == 0)
            {
                errorProvider1.SetError(rtxtthongtinchung, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void rtxtchucnang_Leave(object sender, EventArgs e)
        {
            if (rtxtchucnang.Text.Length == 0)
            {
                errorProvider1.SetError(rtxtchucnang, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void rtxtthongsochug_Leave(object sender, EventArgs e)
        {
            if (rtxtthongsochug.Text.Length == 0)
            {
                errorProvider1.SetError(rtxtthongsochug, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void rtxtcauhinh_Leave(object sender, EventArgs e)
        {
            if (rtxtcauhinh.Text.Length == 0)
            {
                errorProvider1.SetError(rtxtcauhinh, "Không được trống");

            }
            else
            {
                errorProvider1.Clear();

            }
        }
    }
}
