using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debtproblem
{
    [TestClass]
    public class UnitTest1
    {
        private double dayOfPenalityFirstCase;
        private double daysOfPenalityMiddleCase;
        private double daysOfPenalityLongCase;

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
        public double CalculateSumOfDebt(int rental, int daysToPay)
        {
            daysofpenality(rental);
            double sumOfDebt, sumOfDebt2, sumOfDebt3;
            Calculationoftotaldebt(rental, out sumOfDebt, out sumOfDebt2, out sumOfDebt3);

            if ((daysToPay >= 1) && (daysToPay <= 10)) return sumOfDebt;
            if ((daysToPay >= 11) && (daysToPay <= 30)) return sumOfDebt2;
            if ((daysToPay >= 31) && (daysToPay <= 40)) return sumOfDebt3;
            return 0;
        }

        private void Calculationoftotaldebt(int rental, out double sumOfDebt, out double sumOfDebt2, out double sumOfDebt3)
        {
            sumOfDebt = rental + dayOfPenalityFirstCase;
            sumOfDebt2 = rental + daysOfPenalityMiddleCase;
            sumOfDebt3 = rental + daysOfPenalityLongCase;
        }

        private void daysofpenality(int rental)
        {
            double[] prices = { 0.002, 0.05, 0.1 };
            dayOfPenalityFirstCase = prices[0] * rental;
            daysOfPenalityMiddleCase = prices[1] * rental;
            daysOfPenalityLongCase = prices[2] * rental;
        }



    }
}
