using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSannn;
using QLKhachSannn.DAL;
using QLKhachSannn.BLL;

namespace UnitTest
{
    [TestClass]
    public class UnitTestTraCuu
    {
        BLL_Phong bll;
        TraCuu f;
        [TestMethod]
        public void Test_TimMaPhong_Success()
        {
            bll = new BLL_Phong();
            Phong p = new Phong();
            p.MaPhong = "P03";
            f = new TraCuu();
            Assert.AreEqual("Đã tìm thấy!", "Đã tìm thấy!");
        }
        [TestMethod]
        public void Test_TimMaPhong_Fail()
        {

            bll = new BLL_Phong();
            Phong p = new Phong();
            p.MaPhong = "P21";
            f = new TraCuu();
            Assert.AreEqual("Không tìm thấy", "Không tìm thấy");
        }
        [TestMethod]
        public void Test_TimLoaiPhong_Suscess()
        {

            bll = new BLL_Phong();
            Phong p = new Phong();
            p.LoaiPhong = "SUP";
            f = new TraCuu();
            Assert.AreEqual("Đã tìm thấy!", "Đã tìm thấy!");
        }
        [TestMethod]
        public void Test_TimLoaiPhong_Fail()
        {
            bll = new BLL_Phong();
            Phong p = new Phong();
            p.LoaiPhong = "SUT";
            f = new TraCuu();
            Assert.AreEqual("Không tìm thấy!", "Không tìm thấy!");
        }
        [TestMethod]
        public void Test_TimTinhTrangPhong_Suscess()
        {

            bll = new BLL_Phong();
            Phong p = new Phong();
            p.TinhTrang = "Trong";
            f = new TraCuu();
            Assert.AreEqual("Đã tìm thấy!", "Đã tìm thấy!");
        }
        [TestMethod]
        public void Test_TimTinhTrangPhong_Fail()
        {

            bll = new BLL_Phong();
            Phong p = new Phong();
            p.TinhTrang = "Khong";
            f = new TraCuu();
            Assert.AreEqual("Không tìm thấy!", "Không tìm thấy!");
        }
        [TestMethod]
        public void Test_TimGiaPhong_Suscess()
        {
            bll = new BLL_Phong();
            Phong p = new Phong();
            p.Gia = "200000";
            f = new TraCuu();
            Assert.AreEqual("Đã tìm thấy!", "Đã tìm thấy!");
        }
        [TestMethod]
        public void Test_TimGiaPhong_Fail()
        {

            bll = new BLL_Phong();
            Phong p = new Phong();
            p.Gia = "500000";
            f = new TraCuu();
            Assert.AreEqual("Không tìm thấy!", "Không tìm thấy!");
        }
    }
}
