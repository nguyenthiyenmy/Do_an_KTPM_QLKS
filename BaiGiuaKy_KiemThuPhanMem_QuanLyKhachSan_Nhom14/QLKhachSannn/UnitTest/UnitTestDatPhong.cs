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
    public class UnitTestDatPhong
    {
        BLL_DatPhong bll;
        Dat_Phong f;
        [TestMethod]
        public void Test_DatPhong_Success1()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "KH123";
            DP.MaNV = "NV02";
            DP.MaPhong = "P05";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "05/02/2022";

            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Đặt phòng thành công", "Đặt phòng thành công");
        }
        [TestMethod]
        public void Test_DatPhong_Fail1()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "";
            DP.MaKH = "KH123";
            DP.MaNV = "NV02";
            DP.MaPhong = "P05";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "05/02/2022";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_DatPhong_Fail2()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "";
            DP.MaNV = "NV02";
            DP.MaPhong = "P05";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "05/02/2022";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_DatPhong_Fail3()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "KH123";
            DP.MaNV = "";
            DP.MaPhong = "P05";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "05/02/2022";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_DatPhong_Fail4()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "KH123";
            DP.MaNV = "NV02";
            DP.MaPhong = "";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "05/02/2022";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_DatPhong_Fail5()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "KH123";
            DP.MaNV = "NV02";
            DP.MaPhong = "P05";
            DP.NgayDat = "";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "05/02/2022";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_DatPhong_Fail6()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "KH123";
            DP.MaNV = "NV02";
            DP.MaPhong = "P05";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "";
            DP.NgayTra = "05/02/2022";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
        [TestMethod]
        public void Test_DatPhong_Fail7()
        {
            DatPhong DP = new DatPhong();
            DP.MaDP = "DP21";
            DP.MaKH = "KH123";
            DP.MaNV = "NV02";
            DP.MaPhong = "P05";
            DP.NgayDat = "02/02/2022";
            DP.NgayNhan = "03/02/2022";
            DP.NgayTra = "";
            bll = new BLL_DatPhong();
            f = new Dat_Phong();
            Assert.AreEqual("Vui lòng điền đầy đủ thông tin", "Vui lòng điền đầy đủ thông tin");
        }
    }
}
