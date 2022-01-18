using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QLKhachSannn;
using QLKhachSannn.BLL;
using QLKhachSannn.DAL;

namespace UnitTest
{
    [TestClass]
    public class UnitTestDangNhap
    {
        BLL_DangNhap bll;
        DangNhap f;
        [TestMethod]
        public void Test_DangNhap_Success()
        {
            NhanVien nv = new NhanVien();
            nv.Gmail = "huy@gmail.com";
            nv.MatKhau = "1995huy";
            bll = new BLL_DangNhap();
            f = new DangNhap();
            Assert.AreEqual("Đăng nhập thành công", "Đăng nhập thành công");
        }
        [TestMethod]
        public void Test_DangNhap_Fail1()
        {
            NhanVien nv = new NhanVien();
            nv.Gmail = "nhom14";
            nv.MatKhau = "1995huy";
            bll = new BLL_DangNhap();
            f = new DangNhap();
            Assert.AreEqual("Đăng nhập sai tài khoản!!!", "Đăng nhập sai tài khoản!!!");
        }
        [TestMethod]
        public void Test_DangNhap_Fail2()
        {
            NhanVien nv = new NhanVien();
            nv.Gmail = "";
            nv.MatKhau = "1995huy";
            bll = new BLL_DangNhap();
            f = new DangNhap();
            Assert.AreEqual("Hãy nhập tên đăng nhập", "Hãy nhập tên đăng nhập");
        }
        [TestMethod]
        public void Test_DangNhap_Fail3()
        {
            NhanVien nv = new NhanVien();
            nv.Gmail = "huy@gmail.com";
            nv.MatKhau = "";
            bll = new BLL_DangNhap();
            f = new DangNhap();
            Assert.AreEqual("Hãy nhập mật khẩu", "Hãy nhập mật khẩu");
        }
        [TestMethod]
        public void Test_DangNhap_Fail4()
        {
            NhanVien nv = new NhanVien();
            nv.Gmail = "huy@gmail.com";
            nv.MatKhau = "1234567";
            bll = new BLL_DangNhap();
            f = new DangNhap();
            Assert.AreEqual("Đăng nhập sai tài khoản!!!", "Đăng nhập sai tài khoản!!!");
        }

    }
}
