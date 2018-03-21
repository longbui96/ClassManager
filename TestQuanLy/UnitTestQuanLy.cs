using System;
using System.Data.Common;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Data.SqlClient;
using RoomManager;

namespace TestQuanLy
{
    [TestClass]
    public class UnitTestQuanLy
    {
        private RoomManager.QuanLy.PhongTrong QLPhongTrong;
        private RoomManager.QuanLy.cbbItem cbbItem;
        private RoomManager.QuanLy.TKB ThoiKhoaBieu;

        [TestInitialize]
        public void SetUp()
        {

        }
        
        [TestMethod] 
        public void TestPhongTrong_DayDu()
        {
            this.QLPhongTrong
                = new QuanLy.PhongTrong(
                    "1",
                    "1",
                    DateTime.ParseExact(
                        "2018-03-20",
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture
                    ));
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestPhongTrong_ThieuIDPhong()
        {
            this.QLPhongTrong
                = new QuanLy.PhongTrong(
                    "", // Rỗng
                    "1",
                    DateTime.ParseExact(
                        "2018-03-20",
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture
                    ));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestPhongTrong_ThieuTiet()
        {
            this.QLPhongTrong
                = new QuanLy.PhongTrong(
                    "1",
                    "", // Rỗng
                    DateTime.ParseExact(
                        "2018-03-20",
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture
                    ));
        }

        [TestMethod]
        public void TestCBBItem_DayDu()
        {
            this.cbbItem = new QuanLy.cbbItem("Test Thu", "MaMon");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCBBItem_ThieuTenItem()
        {
            this.cbbItem = new QuanLy.cbbItem("", "MaMon");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCBBItem_ThieuMaItem()
        {
            this.cbbItem = new QuanLy.cbbItem("Test", "");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestTKB_ThieuNhieuCho()
        {
            string Phong = "";
            string Lop = "";
            string Mon = "";
            int TietBD = 1;
            int TietKT = 1;
            DateTime NgayMuon = new DateTime(2018, 03, 20);
            string NguoiMuon = "";
            string NguoiTra = "";
            string LyDo = "";

            this.ThoiKhoaBieu
                = new QuanLy.TKB(
                    Phong,
                    Lop, 
                    Mon, 
                    TietBD, 
                    TietKT, 
                    NgayMuon, 
                    NguoiMuon, 
                    NguoiTra, 
                    LyDo
                );
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestTKB_ToanLaMot()
        {
            string Phong = "1";
            string Lop = "1";
            string Mon = "1";
            int TietBD = 1;
            int TietKT = 1;
            DateTime NgayMuon = new DateTime(2018, 03, 20);
            string NguoiMuon = "1";
            string NguoiTra = "1";
            string LyDo = "1";


            this.ThoiKhoaBieu
                = new QuanLy.TKB(
                    Phong,
                    Lop,
                    Mon,
                    TietBD,
                    TietKT,
                    NgayMuon,
                    NguoiMuon,
                    NguoiTra,
                    LyDo
                );
        }

        [TestMethod]
        public void TestTKB_EpKieu()
        {
            int Phong = 2;
            string Lop = "1";
            string Mon = "1";
            string TietBD = "11";
            string TietKT = "13";
            string NgayMuon = "2018-05-20";
            string NguoiMuon = "1";
            string NguoiTra = "1";
            string LyDo = "Ăn sinh nhật";


            this.ThoiKhoaBieu
                = new QuanLy.TKB(
                    Phong.ToString(),
                    Lop,
                    Mon,
                    int.Parse(TietBD),
                    int.Parse(TietKT),
                    DateTime.Parse(NgayMuon),
                    NguoiMuon,
                    NguoiTra,
                    LyDo
                );
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestTKB_BD_lt_KT()
        {
            int Phong = 2;
            string Lop = "TH43";
            string Mon = "Kiểm thử";
            string TietBD = "4";
            string TietKT = "1";
            string NgayMuon = "2018-05-22";
            string NguoiMuon = "ABC";
            string NguoiTra = "XYZ";
            string LyDo = "Ăn sinh nhật";


            this.ThoiKhoaBieu
                = new QuanLy.TKB(
                    Phong.ToString(),
                    Lop,
                    Mon,
                    int.Parse(TietBD),
                    int.Parse(TietKT),
                    DateTime.Parse(NgayMuon),
                    NguoiMuon,
                    NguoiTra,
                    LyDo
                );
        }
    }
}
