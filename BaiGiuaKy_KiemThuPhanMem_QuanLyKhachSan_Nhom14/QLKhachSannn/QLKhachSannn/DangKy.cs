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
    public partial class DangKy : Form
    {
        BLL_DangKy bTaiKhoan;
        public DangKy()
        {
            InitializeComponent();
            bTaiKhoan = new BLL_DangKy();
        }
        private void btDangKy_Click(object sender, EventArgs e)
        {

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào họ tên");
                txtHoTen.Focus();
            }
            else if (txtGmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập gmail");
                txtGmail.Focus();
            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtSoDienThoai.Focus();
            }
            else if (txtNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh");
                txtSoDienThoai.Focus();
            }
            else if (txtGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giới tính");
                txtSoDienThoai.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu");
                txtXacNhanMatKhau.Focus();
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu phải giống nhau");
                txtXacNhanMatKhau.Focus();
                txtXacNhanMatKhau.SelectAll();
            }
            else
            if (txtMatKhau.Text.Length <= 6)
            {
                MessageBox.Show("Mật khẩu sai định dạng");
                txtMatKhau.Focus();
                txtMatKhau.SelectAll();
            }
            else
            if (bTaiKhoan.kiemTraTKTonTai(txtGmail.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                txtGmail.Focus();
            }
            else
            {
                NhanVien nd = new NhanVien();
                nd.TenNV = txtHoTen.Text;
                nd.Gmail = txtGmail.Text;
                nd.SoDienThoai = txtSoDienThoai.Text;
                nd.Gmail = txtGmail.Text;
                nd.NgaySinh = txtNgaySinh.Text;
                nd.GioiTinh = txtGioiTinh.Text;
                nd.MatKhau = txtMatKhau.Text;
                bTaiKhoan.ThemTK(nd);
                MessageBox.Show("Đăng ký tài khoản thành công");
            }

        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
