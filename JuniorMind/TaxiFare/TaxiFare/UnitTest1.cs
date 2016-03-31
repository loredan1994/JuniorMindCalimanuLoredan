using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DayTimeFareForShortDistances()
        {
            Assert.AreEqual(5,CalculateTaxiFare(1, 8));
        }
        [TestMethod]
        public void DayTimeFareForMiddleDistances()
        {
            Assert.AreEqual(168, CalculateTaxiFare(21, 8));
        }
        [TestMethod]
        public void DayTimeFareForLongDistances()
        {
            Assert.AreEqual(600, CalculateTaxiFare(100, 8));
        }
        [TestMethod]
        public void NightTimeFareForShortDistances()
        {
            Assert.AreEqual(7, CalculateTaxiFare(1, 21));
        }
        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            decimal[] daytimeprice = { 5, 8, 6 };
            decimal pricePerKm = GetPricePerKilometer(distanceInKm,daytimeprice);
            return distanceInKm * pricePerKm;
        }

        private decimal GetPricePerKilometer(int distanceInKm,decimal[] prices)
        {

            if (IsLongDistance(distanceInKm))
                return prices[2];
            if (IsMediumDistance(distanceInKm))
                return prices[1];
            return prices[0];
        }

        private bool IsLongDistance(int distanceInKm)
        {
            return distanceInKm > 60;
        }

        private bool IsMediumDistance(int distanceInKm)
        {
            return distanceInKm > 20;
        }
    }
}
