using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomManager;

namespace TestQuanLy
{
    [TestClass]
    public class UnitTestQuanLy
    {
        private RoomManager.Muon rm_muon;
        [TestInitialize]
        public void SetUp()
        {
            this.rm_muon = new RoomManager.Muon();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
