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
            decimal result = test.GetPrice(-5, FeeRate.Hatchback);
            Assert.AreEqual(0, result);
        }
    }
}
