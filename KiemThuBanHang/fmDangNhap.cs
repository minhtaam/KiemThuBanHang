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
using System.Configuration;

namespace KiemThuBanHang
{
    public partial class fmDangNhap : Form
    {
        frmChinh Ql;
        string cnStr = @"Data Source= .;Initial Catalog=DuLieu;Integrated Security=True";

        SqlConnection kn = new SqlConnection(@"Data Source=.;Initial Catalog=DuLieu;Integrated Security=True");
        SqlCommand cmd;
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void fmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                kn = new SqlConnection(cnStr);
                kn.Open();
                string sql = "SELECT Count(*) FROM [DuLieu].[dbo].[TAIKHOAN] WHERE MaNV = @acc AND MatKhau =@pass ";
                cmd = new SqlCommand(sql, kn);
                cmd.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("MÃ NHÂN VIÊN HOẶC MẬT KHẨU KHÔNG ĐÚNG!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
