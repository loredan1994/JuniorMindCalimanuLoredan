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
            double[] pricesProcentage = { 0.002, 0.05, 0.1 };
            double totalSumOfRent;
            CalculusOfTotalSum(rental, daysToPay, out totalSumOfRent);
            if ((daysToPay >= 1) && (daysToPay <= 10))
                return resultInLessDaysCase(rental, pricesProcentage, totalSumOfRent);
            if ((daysToPay >= 11) && (daysToPay <= 30))
                return resultInMiddleDaysCase(rental, pricesProcentage, totalSumOfRent);
            if ((daysToPay >= 40))
                return resultInLongDaysCase(rental, pricesProcentage, totalSumOfRent);
            return rental;

        }

        private static double resultInLongDaysCase(int rental, double[] pricesProcentage, double totalSumOfRent)
        {
            return rental + totalSumOfRent * pricesProcentage[2];
        }

        private static double resultInMiddleDaysCase(int rental, double[] pricesProcentage, double totalSumOfRent)
        {
            return rental + totalSumOfRent * pricesProcentage[1];
        }

        private static double resultInLessDaysCase(int rental, double[] pricesProcentage, double totalSumOfRent)
        {
            return rental + totalSumOfRent * pricesProcentage[0];
        }

        private static void CalculusOfTotalSum(int rental, int daysToPay, out double totalSumOfRent)
        {
            double payDay = rental / 30;
            totalSumOfRent = payDay * daysToPay;
        }         
    }
}
