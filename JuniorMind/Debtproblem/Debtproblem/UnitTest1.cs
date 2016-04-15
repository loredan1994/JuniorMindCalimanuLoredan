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
            Assert.AreEqual(66, CalculateSumOfDebt(60, 40));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(94.5, CalculateSumOfDebt(90, 20));
        }
        public double CalculateSumOfDebt(int rental, int Daystopay)
        {
            double daysofpenality, daysofpenality2, daysofpenality3;
            PenalityDaysComputation(rental, out daysofpenality, out daysofpenality2, out daysofpenality3);
            double sumOfDebt, sumOfDebt2, sumOfDebt3;
            DebtsComputation(rental, daysofpenality, daysofpenality2, daysofpenality3, out sumOfDebt, out sumOfDebt2, out sumOfDebt3);
            if ((Daystopay >= 1) && (Daystopay <= 10)) return sumOfDebt;
            if ((Daystopay >= 11) && (Daystopay <= 30)) return sumOfDebt2;
            if ((Daystopay >= 31) && (Daystopay <= 40)) return sumOfDebt3;
            else return 0;
        }

        private static void DebtsComputation(int rental, double daysofpenality, double daysofpenality2, double daysofpenality3, out double sumOfDebt, out double sumOfDebt2, out double sumOfDebt3)
        {
            sumOfDebt = rental + daysofpenality;
            sumOfDebt2 = rental + daysofpenality2;
            sumOfDebt3 = rental + daysofpenality3;
        }

        private static void PenalityDaysComputation(int rental, out double daysofpenality, out double daysofpenality2, out double daysofpenality3)
        {
            daysofpenality = 0.02 * rental;
            daysofpenality2 = 0.05 * rental;
            daysofpenality3 = 0.1 * rental;
        }
    }
}
