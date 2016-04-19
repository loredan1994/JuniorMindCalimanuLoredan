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
            double payDay = rental / 30;

            if ((daysToPay >= 1) && (daysToPay <= 10))
                return rental + pricesProcentage[0] * payDay * daysToPay;
            if ((daysToPay >= 11) && (daysToPay <= 30))
                return rental + pricesProcentage[1] * payDay * daysToPay;
            if ((daysToPay >= 40))
                return rental + NewMethod(daysToPay, pricesProcentage, payDay);
            else
                return rental;

        }

        private static double NewMethod(int daysToPay, double[] pricesProcentage, double payDay)
        {
            return pricesProcentage[2] * payDay * daysToPay;
        }
    }
}
