using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemThuBanHang
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDangNhap f = new fmDangNhap();
            f.ShowDialog();
            quảnLýToolStripMenuItem.Enabled = thôngTinToolStripMenuItem.Enabled = thốngKêToolStripMenuItem.Enabled = true;
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
