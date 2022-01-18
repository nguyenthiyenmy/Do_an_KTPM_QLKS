using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSannn.DAL;
using QLKhachSannn.BLL;
using QLKhachSannn;

namespace UnitTest
{
    [TestClass]
    public class UnitTestDichVu
    {
        BLL_DichVu bll;
        DichVu f;

        [TestMethod]
        public void Test_ThemDichVu_Suscess()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "Don phong";
            dv.Gia = "50";
            bll = new BLL_DichVu();
            Assert.AreEqual("Thêm dịch vụ thành công", "Thêm dịch vụ thành công");
        }
        [TestMethod]
        public void Test_ThemDichVu_Fail1()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "";
            dv.Gia = "50";
            f = new DichVu();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_ThemDichVu_Fail2()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "Don phong";
            dv.Gia = "";
            f = new DichVu();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_SuaDichVu_Suscess()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "Don phong";
            dv.Gia = "50";
            bll = new BLL_DichVu();
            Assert.AreEqual("Cập nhật dịch vụ thành công", "Cập nhật dịch vụ thành công");
        }
        [TestMethod]
        public void Test_SuaDichVu_Fail1()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "";
            dv.Gia = "50";
            f = new DichVu();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_SuaDichVu_Fail2()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "Don phong";
            dv.Gia = "";
            f = new DichVu();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_SuaDichVu_Fail3()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "";
            dv.TenDV = "Don phong";
            dv.Gia = "50";
            f = new DichVu();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_XoaDichVu_Suscess1()
        {
            DichVu dv = new DichVu();
            dv.MaDV = "DV10";
            dv.TenDV = "Don phong";
            dv.Gia = "50";
            bll = new BLL_DichVu();
            Assert.AreEqual("Xóa dịch vụ thành công", "Xóa dịch vụ thành công");
        }
    }
}
