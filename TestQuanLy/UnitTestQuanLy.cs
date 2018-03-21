using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomManager;

namespace TestQuanLy
{
    [TestClass]
    public class UnitTestQuanLy
    {
        private RoomManager.QuanLy.PhongTrong QLPhongTrong;

        [TestInitialize]
        public void SetUp()
        {

        }

        [TestMethod]
        public void TestPhongTrong()
        {
            try
            {
                this.QLPhongTrong = new QuanLy.PhongTrong("1", "1", DateTime.ParseExact("2018-03-20", "yyyy-MM-dd", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
