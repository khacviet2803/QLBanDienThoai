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
using System.Diagnostics;

namespace GiaodienPhanmem
{
    public partial class ConnectSQL : Form
    {
        public ConnectSQL()
        {
            InitializeComponent();
        }
        private void load()
        {
            Process netUtility = new Process();
            netUtility.StartInfo.FileName = "net.exe";
            netUtility.StartInfo.CreateNoWindow = true;
            netUtility.StartInfo.Arguments = "view";
            netUtility.StartInfo.RedirectStandardOutput = true;
            netUtility.StartInfo.UseShellExecute = false;
            netUtility.StartInfo.RedirectStandardError = true;
            netUtility.Start();
            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.StartsWith("\\"))
                {
                    cmbserver.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper() + @"\SQLEXPRESS");
                }
            }
            streamReader.Close();
            netUtility.WaitForExit(1000);
            cmbserver.Items.Add(SystemInformation.ComputerName + @"\SQLEXPRESS");
        }
        private void ConnectSQL_Load(object sender, EventArgs e)
        {
            cmbauther.SelectedIndex = 0;
            btnok.Enabled = true;
           load();
            cmbserver.Text = SystemInformation.ComputerName + @"\SQLEXPRESS";

        }
        private void btntest_Click(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cmbauther .SelectedIndex == 0)
            {
                cmbdata.Items.Clear();
                SqlConnection conn = new SqlConnection("Data Source=" + cmbserver.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", conn);
                //SP_DATABASES là một store procedure có sẵn của sql server để lấy ra tất cả csdl trong sql server
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbdata.Items.Add(reader[0].ToString());
                    }
                    cmbdata.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "DISSUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    conn.Dispose();
                    cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cmbauther.SelectedIndex == 1)
            {
                cmbdata.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + cmbserver.Text + ";Initial Catalog=master;User Id=" + txtuser.Text + ";Password=" + txtpass.Text + ";");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                SqlDataReader reader;

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbdata.Items.Add(reader[0].ToString());
                    }
                    cmbdata.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "DISSUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                    cmd.Dispose();
                }
            }

        }

        private void cmbauther_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbauther.SelectedIndex == 0)
            {
                txtuser.Enabled = false;
                txtpass.Enabled = false;
            }
            else
            {
                txtuser.Enabled = true;
                txtpass.Enabled = true;
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (cmbauther.SelectedIndex == 0)
                Connect.WriteFile(cmbserver.Text, cmbauther.Text, "", "");
            else Connect.WriteFile(cmbserver.Text,cmbdata.Text, txtuser.Text, txtpass.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnok.Enabled = true;
        }

        
    }
}
