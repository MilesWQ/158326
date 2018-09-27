using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalLibrary;

namespace UnitTestCarRental
{
    [TestClass]
    public class UnitTest1
    {
        private CarRental test;
      
        [TestInitialize]
        public void TestInitalize()
        {
            test = new CarRental();
        }

        [TestMethod]
        public void TestNegativeDayValue()
        {
            
            Assert.AreEqual(0, test.GetPrice(-5, FeeRate.Hatchback));
        }

        [TestMethod]
        public void TestHatchBackLessThan5Day()
        {
            Assert.AreEqual(200, test.GetPrice(4, FeeRate.Hatchback)); 
        }

        [TestMethod]
        public void TestHatchBack5Day()
        {
            Assert.AreEqual(225, test.GetPrice(5, FeeRate.Hatchback));
        }

        [TestMethod]
        public void TestHatchBack10Day()
        {
            Assert.AreEqual(425, test.GetPrice(10, FeeRate.Hatchback));
        }

        [TestMethod]
        public void TestHatchBack20Day()
        {
            Assert.AreEqual(800, test.GetPrice(20, FeeRate.Hatchback));
        }
    }
}
