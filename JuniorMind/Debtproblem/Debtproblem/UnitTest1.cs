using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debtproblem
{
    [TestClass]
    public class UnitTest1
    {
        private double dayofpenalityfirstcase;
        private double daysofpenalitymiddlecase;
        private double daysofpenalitylongcase;

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(66, CalculateSumOfDebt(60, 40));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(94.5, CalculateSumOfDebt(90, 20));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(100.2, CalculateSumOfDebt(100, 8));
        }
        public double CalculateSumOfDebt(int rental, int daystopay)
        {
            daysofpenality(rental);
            double sumOfDebt, sumOfDebt2, sumOfDebt3;
            Calculationoftotaldebt(rental, out sumOfDebt, out sumOfDebt2, out sumOfDebt3);

            if ((daystopay >= 1) && (daystopay <= 10)) return sumOfDebt;
            if ((daystopay >= 11) && (daystopay <= 30)) return sumOfDebt2;
            if ((daystopay >= 31) && (daystopay <= 40)) return sumOfDebt3;
            return 0;
        }

        private void Calculationoftotaldebt(int rental, out double sumOfDebt, out double sumOfDebt2, out double sumOfDebt3)
        {
            sumOfDebt = rental + dayofpenalityfirstcase;
            sumOfDebt2 = rental + daysofpenalitymiddlecase;
            sumOfDebt3 = rental + daysofpenalitylongcase;
        }

        private void daysofpenality(int rental)
        {
            double[] prices = { 0.002, 0.05, 0.1 };
            dayofpenalityfirstcase = prices[0] * rental;
            daysofpenalitymiddlecase = prices[1] * rental;
            daysofpenalitylongcase = prices[2] * rental;
        }



    }
}
