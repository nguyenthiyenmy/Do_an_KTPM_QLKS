using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSannn.BLL;

namespace QLKhachSannn
{
    public partial class DangNhap : Form
    {
        BLL_DangNhap bll;
        public DangNhap()
        {
            InitializeComponent();
            bll = new BLL_DangNhap();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text == "")
            {
                MessageBox.Show("Hãy nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK);
                txtGmail.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txtMatKhau.Focus();
            }
            else
            {
                if (bll.kiemTraDN(txtGmail.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    fMenu f = new fMenu();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập sai tài khoản!!!", "Thông báo");
                    txtGmail.Focus();
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDKy_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.Show();
        }
    }
}
