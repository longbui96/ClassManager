using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomManager;

namespace UnitTestPhongHu
{
    [TestClass]
    public class UnitTestPhongHu
    {
        RoomManager.PhongHu.Room room;

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestPhongHu_RoomAmThanh_FullFail()
        {
            string Phong = "";
            string MayChieu = "";
            string AmThanh = "";
            string AnhSang = "";
            string MayLanh = "";
            string RoDungCu = "";
            int SucChua = -2;

            this.room = new PhongHu.Room(Phong, MayChieu, AmThanh, AnhSang, MayLanh, RoDungCu, SucChua);
        }

        [TestMethod]
        public void TestPhongHu_RoomAmThanh_Beautiful()
        {
            string Phong = "PM002";
            string MayChieu = "Tốt";
            string AmThanh = "Tốt";
            string AnhSang = "Tốt";
            string MayLanh = "Tốt";
            string RoDungCu = "Tốt";
            int SucChua = 22;

            this.room = new PhongHu.Room(Phong, MayChieu, AmThanh, AnhSang, MayLanh, RoDungCu, SucChua);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestPhongHu_RoomAmThanh_Mixed()
        {
            string Phong = "PM002";
            string MayChieu = "Bị mất cái ống kính";
            string AmThanh = "Tốt";
            string AnhSang = "Không biết tốt hay không";
            string MayLanh = "Tốt";
            string RoDungCu = "Tốt";
            int SucChua = -100;

            this.room = new PhongHu.Room(Phong, MayChieu, AmThanh, AnhSang, MayLanh, RoDungCu, SucChua);
        }
    }
}
