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
    public partial class Main :Form
    {
        public string id;
        public string pass;
        public string name;
        public string manager;
        public SqlConnection conn;
       
        public Main(string pass1, string name1,string manager1,SqlConnection conn1)
        {
            InitializeComponent();
            pass = pass1;
            name = name1;
            manager = manager1;
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
        }
        public void nhung(Form f)
        {
            
            panel_nd.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;//quan trọng là dòng này thiếu là chít
            f.Visible = true;
            f.Dock = DockStyle.Fill;
             panel_nd.Controls.Add(f);//thêm form mới vào panel
            panel_nd.Show();
        }
       
      
         private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time:" + DateTime.Now.ToLocalTime().ToString();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            toolStripLabelacount.Text = "Người dùng: " + name;
            toolStripLabelquyen.Text = "Quyền: " + manager;
            Menustriphome.Visible = MenustripQuanly.Visible = MenustripThanhToan.Visible = MenustripThongke.Visible = MenustripBaocao.Visible = MenustripLienHe.Visible=false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Ngdung where Quyen= N'"  + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
             if (manager == "Khách hàng")
                {
                    Menustriphome.Visible = MenuItemdoimk.Visible = MenustripQuanly.Visible= MenustripThanhToan.Visible = MenustripLienHe.Visible = true;
                   MenuItemQLyNgDung.Visible = MenuItemNhap.Visible = false;
                   
                }
                else 
                {
                    Menustriphome.Visible = MenustripQuanly.Visible = MenustripThanhToan.Visible = MenustripThongke.Visible = MenustripBaocao.Visible = true;
                }

            }
            reader.Close();
            conn.Close();
  
        }
        private void toolStripMenudoimk_Click(object sender, EventArgs e)
        {
            Changepass c = new Changepass(name, pass, conn);
            nhung(c);
        }
        private void MenuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemQLyNgDung_Click(object sender, EventArgs e)
        {
            frmNguoidung f = new frmNguoidung();
            nhung(f);
        }

        private void MenuItemNhap_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            nhung (f);
        }

        private void MenuItemXuat_Click(object sender, EventArgs e)
        {
            frmDatHang f = new frmDatHang(conn,manager);
            nhung(f);
        }

        private void MenustripThongke_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            nhung(f);

        }

        private void MenuItemHangton_Click(object sender, EventArgs e)
        {
            frmTonKho f = new frmTonKho();
            nhung(f);
        }

        private void MenuItemDoanhthu_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            nhung(f);
        }

        private void MenustripLienHe_Click(object sender, EventArgs e)
        {
            frmQLngdung f = new frmQLngdung();
            nhung(f);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang f = new frmQuanLyKhachHang(conn,manager);
            nhung(f);
        }

        private void MenuItemSanPham_Click(object sender, EventArgs e)
        {
            frmQuanLyMatHang f = new frmQuanLyMatHang(conn, manager);
            nhung(f);
        }

        private void MenuItemNhaCungCap_Click(object sender, EventArgs e)
        {

            frmQuanLyNhaCungUng f = new frmQuanLyNhaCungUng(conn, manager);
            nhung(f);
        }

       
      

       

   
       
             
    }
}