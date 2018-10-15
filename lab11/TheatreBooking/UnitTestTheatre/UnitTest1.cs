using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheatreBookingLib;

namespace UnitTestTheatre
{
    [TestClass]
    public class UnitTest1
    {
        private Theatre _testTheatre;

        [TestInitialize]
        public void TestInitialize()
        {
            _testTheatre = new Theatre("name","address");
        }

        [TestMethod]
        public void TestGetTheatrename()
        {
            Assert.AreEqual("name", _testTheatre.TheatreName);
        }

        [TestMethod]
        public void TestGetTheatreAddress()
        {
            Assert.AreEqual("address", _testTheatre.TheatreAddress);
        }

        [TestMethod]
        public void TestPleaseBookSeats0()
        {
            Assert.AreEqual("invalid order number", _testTheatre.PleaseBookSeats(0));
        }

        [TestMethod]
        public void TestPleaseBookSeatsNegative()
        {
            Assert.AreEqual("invalid order number", _testTheatre.PleaseBookSeats(-1));
        }

        [TestMethod]
        public void TestPleaseBookSeats61()
        {
            Assert.AreEqual("No enough vacant seats", _testTheatre.PleaseBookSeats(61));
        }

        [TestMethod]
        public void TestPleaseBookSeats1()
        {
            string booked = _testTheatre.PleaseBookSeats(1);
            string lastBooked = _testTheatre.DetailsOfLastBooking;
            Assert.AreEqual(lastBooked, booked);
        }

        [TestMethod]
        public void TestPleaseBookSeats60()
        {
            string booked = _testTheatre.PleaseBookSeats(60);
            string lastBookedDetails = _testTheatre.DetailsOfLastBooking;
            Assert.AreEqual(lastBookedDetails, booked);
        }

        [TestMethod]
        public void TestCurrentVacantSeats()
        {
            _testTheatre.PleaseBookSeats(1);
            int currentSeatNumber = _testTheatre.CurrentVancantSeat;
            Assert.AreEqual(59, currentSeatNumber);
        }

        [TestMethod]
        public void TestCurrentVacantSeatsAllBooked()
        {
            _testTheatre.PleaseBookSeats(60);
            int currentSeatNumber = _testTheatre.CurrentVancantSeat;
            Assert.AreEqual(0, currentSeatNumber);
        }

        [TestMethod]
        public void TestIsCompletelyVacant()
        {
            bool isCompletelyVacant = _testTheatre.IsCompletelyVacant;
            Assert.AreEqual(true, isCompletelyVacant);
        }

        [TestMethod]
        public void TestIsNotCompletelyVacant()
        {
            _testTheatre.PleaseBookSeats(1);
            bool isCompletelyVacant = _testTheatre.IsCompletelyVacant;
            Assert.AreEqual(false, isCompletelyVacant);
        }
    }
}
