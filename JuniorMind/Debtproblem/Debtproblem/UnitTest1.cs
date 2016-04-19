using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debtproblem
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(68, CalculateSumOfDebt(60, 40));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(93, CalculateSumOfDebt(90, 20));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(100.048, CalculateSumOfDebt(100, 8));
        }
        [TestMethod]
        public void TestWhenNoDelay()
        {
            Assert.AreEqual(100, CalculateSumOfDebt(100, 0));
        }
        public double CalculateSumOfDebt(int rental, int daysToPay)
        {
            double totalSumofRentForLessDays, totalSumofRentForMiddleDays, totalSumofRentForLongDays;
            CalculusOfTotalSum(rental, daysToPay, out totalSumofRentForLessDays, out totalSumofRentForMiddleDays, out totalSumofRentForLongDays);
            if ((daysToPay >= 1) && (daysToPay <= 10))return totalSumofRentForLessDays;
            if ((daysToPay >= 11) && (daysToPay <= 30))return totalSumofRentForMiddleDays;
            if ((daysToPay >= 40))return totalSumofRentForLongDays;
            return rental;

        }

        private static void CalculusOfTotalSum(int rental, int daysToPay, out double totalSumofRentForLessDays, out double totalSumofRentForMiddleDays, out double totalSumofRentForLongDays)
        {
            double[] pricesProcentage = { 0.002, 0.05, 0.1 };
            double payDay = rental / 30;
            totalSumofRentForLessDays = rental + pricesProcentage[0] * payDay * daysToPay;
            totalSumofRentForMiddleDays = rental + pricesProcentage[1] * payDay * daysToPay;
            totalSumofRentForLongDays = rental + pricesProcentage[2] * payDay * daysToPay;
        }
    }
}
