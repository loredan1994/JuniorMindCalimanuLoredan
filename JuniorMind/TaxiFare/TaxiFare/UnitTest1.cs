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
            Assert.AreEqual(5,CalculateTaxiFare(8, 1));
        }
        decimal CalculateTaxiFare(int hour, int distanceInKm)
        {
            return 0;
        }
    }
}
