using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSannn;
using QLKhachSannn.DAL;
using QLKhachSannn.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestDangKy
    {
        BLL_DangKy bll;
        DangKy f;
        [TestMethod]
        public void Test_DangKy_Success()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "037890";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Đăng ký tài khoản thành công", "Đăng ký tài khoản thành công");
        }
        [TestMethod]
        public void Test_DangKy_Fail_01()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "037890";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Bạn chưa nhập giới tính", "Bạn chưa nhập giới tính");
        }
        [TestMethod]
        public void Test_DangKy_Fail_02()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "037890";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Bạn chưa nhập họ tên", "Bạn chưa nhập họ tên");
        }
        [TestMethod]
        public void Test_DangKy_Fail_03()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "037890";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Bạn chưa nhập ngày sinh", "Bạn chưa nhập ngày sinh");
        }
        [TestMethod]
        public void Test_DangKy_Fail_04()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "";
            tk.SoDienThoai = "037890";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Bạn chưa nhập địa chỉ", "Bạn chưa nhập địa chỉ");
        }
        [TestMethod]
        public void Test_DangKy_Fail_05()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "";
            tk.Gmail = "vana@gmail.com";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Bạn chưa nhập số điện thoại", "Bạn chưa nhập số điện thoại");
        }
        [TestMethod]
        public void Test_DangKy_Fail_06()
        {
            bll = new BLL_DangKy();

            NhanVien tk = new NhanVien();
            tk.MaNV = "NV011";
            tk.TenNV = "Nguyen Van A";
            tk.NgaySinh = "12/21/1998";
            tk.GioiTinh = "Nam";
            tk.DiaChi = "Lam Dong";
            tk.SoDienThoai = "037890";
            tk.Gmail = "";
            tk.MatKhau = "vana2022";
            f = new DangKy();
            Assert.AreEqual("Bạn chưa nhập gmail", "Bạn chưa nhập gmail");
        }
    }
}
