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
    public partial class frmreporttonkho : Form
    {
        public frmreporttonkho()
        {
            InitializeComponent();
        }

        private void reporttonkho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDienThDataSet5.MHang' table. You can move, or remove it, as needed.
            this.MHangTableAdapter.Fill(this.QLDienThDataSet5.MHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
