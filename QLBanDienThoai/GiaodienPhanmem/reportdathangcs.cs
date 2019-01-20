using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaodienPhanmem
{
    public partial class frmreportdathangcs : Form
    {
        public frmreportdathangcs()
        {
            InitializeComponent();
        }

        private void reportdathangcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDienThDataSet15.HDonBan' table. You can move, or remove it, as needed.
            this.HDonBanTableAdapter.Fill(this.QLDienThDataSet15.HDonBan);


            this.reportViewer1.RefreshReport();
        }
    }
}
