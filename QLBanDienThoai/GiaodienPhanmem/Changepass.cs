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
    public partial class Changepass : Form
    {
        public string user;
        public string pass;
        SqlConnection conn;
        public Changepass(string user1, string pass1, SqlConnection conn1)
        {
            InitializeComponent();
            user = user1;
            pass = pass1;
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text.Length == 0 || txtconfirmpass.Text.Length == 0)
                lblerror.Text = "Thay đổi mật khẩu không thành công! Hãy thử lại!";
            else if (error1.Text.Length != 0 || error2.Text.Length != 0 || error3.Text.Length != 0)
                lblerror.Text = "Thay đổi mật khẩu không thành công! Hãy kiểm tra lại!";
            else
            {
                string sq = "update Ngdung set Password=@pass where Username=@user";
                SqlCommand cmd = new SqlCommand(sq, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", txtconfirmpass.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                lblerror.Text = "Thay đổi mật khẩu thành công!";
            }
        }

        private void Changepass_Load(object sender, EventArgs e)
        {
            txtname.Text = user;
            txtnewpass.Focus();
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {
            if (txtnewpass.Text.Length > 15 || txtnewpass.Text.Length < 6)
                error1.Text = "Mật khẩu phải dài 6 đến 15 ký tự!";
            else if (txtnewpass.Text.Length == 0)
                error1.Text = "Không được rỗng";
            else if (Regex.IsMatch(txtnewpass.Text, @" +$"))
                error1.Text = "Không có khoảng trắng!";
            else error1.Text = "";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text != pass && (txtpass.Text.Length > 15 || txtpass.Text.Length < 6))
                error3.Text = "Mật khẩu không đúng!";
            else error3.Text = "";
        }

        private void txtconfirmpass_TextChanged(object sender, EventArgs e)
        {

            if (string.Compare(txtconfirmpass.Text, txtnewpass.Text) == 0)
                error2.Text = "";
            else error2.Text = "Mật khẩu không trùng khớp!";
        
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
        
    }
}
