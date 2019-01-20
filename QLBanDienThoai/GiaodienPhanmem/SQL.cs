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
    public partial class SQL : Form
    {
        public string password;
        public string name;
        public string id;
        public string manager;
        public SqlConnection conn;
        public SQL()
        {
            InitializeComponent();
        }
        public int i = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            lblwellcome.Left += i;
            if (lblwellcome.Left >= 870  || lblwellcome.Left <= 0)
                lblwellcome.Left = i;
        }
        private void SQL_Load(object sender, EventArgs e)
        {
             this.Left = 100;
            this.Top = 100;
           
            try
            {
                Connect c = new Connect();
                conn = c.GetConnect();
                conn.Open();
                conn.Close(); 
                panel_connect.Visible = false;
            }
            catch (Exception)
            {
                panel_connect.Visible = true;
                ConnectSQL co = new ConnectSQL();
                nhungc(co);
            }
        }

        private void txtadmin_TextChanged(object sender, EventArgs e)
        {

        }
        public bool check = true;
      
        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                Connect c = new Connect();
                conn = c.GetConnect();
                conn.Open();
                conn.Close();
                panel_connect.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối thất bại! Vui lòng vào Connection Setting để cài đặt lại kết nối ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }

            if (txtaccount.Text.Length == 0 || txtpass.Text.Length == 0)
                MessageBox.Show("User và Pass không được rỗng!");
            else
            {
                string sql = "select * from Ngdung where username=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtaccount.Text);
                
                try
                {
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu không tương thích!\nVui lòng vào Connection Setting để cài đặt lại kết nối ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    check = false;
                }
                if (check == true)
                {
                    conn.Open();
                    cmd.CommandText = "select* from Ngdung where Username=@id";
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool kt = reader.Read(); reader.Close();
                    if (kt)
                    {
                        cmd.CommandText = "select* from Ngdung where Username=@id and PassWord=@pass";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", txtaccount.Text);
                        cmd.Parameters.AddWithValue("@pass", txtpass.Text);
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            name = reader["Username"].ToString();
                            password = reader["Password"].ToString();
                            manager = reader["Quyen"].ToString();
                            reader.Close();
                            conn.Close();
                            Main f2 = new Main(password, name, manager, conn);
                            nhung(f2);
                        }
                        else MessageBox.Show("Sai password!");
                    }
                    else MessageBox.Show("Account không tồn tại");
                      txtaccount.Focus();
                    conn.Close();
                }
            }
        }
         public void nhung(Form f)
        {
            panelmain.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panelmain.Controls.Add(f);//thêm form mới vào panel
            panelmain.Show();
        }

        public void nhungc(Form f)
        {
            panel_connect.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panel_connect.Controls.Add(f);//thêm form mới vào panel
            panel_connect.Show();
        }

            private void pass_KeyDown(object sender, KeyEventArgs e)
          {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void cONNECTSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ConnectSQL co = new ConnectSQL();
            nhungc(co);
        }

        private void panel_connect_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel_connect.Controls.Count == 0)
            {
                try
                {
                    Connect c = new Connect();
                    conn = c.GetConnect();
                    conn.Open(); 
                    conn.Close();
                    panel_connect.Visible = false;
                }
                catch (Exception)
                {
                    panel_connect.Visible = false;
                    MessageBox.Show("Kết nối thất bại! Vui lòng vào Connection Setting để cài đặt lại kết nối ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }

            }
        }

        private void panelmain_MouseHover(object sender, EventArgs e)
        {
            if (panelmain.Controls.Count == 0)
            {
                SQL f = new SQL();
                nhung(f);
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }

             }
    }

