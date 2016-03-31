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
        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            decimal pricePerKilometer = IsMediumDistance(distanceInKm);
            return pricePerKilometer * distanceInKm;
        }

        private static decimal IsMediumDistance(int distanceInKm)
        {
            return distanceInKm > 20 ? 8 : 5;
        }
    }
}
