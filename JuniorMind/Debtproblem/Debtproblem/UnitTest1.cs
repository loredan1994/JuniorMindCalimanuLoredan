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
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(100.2, CalculateSumOfDebt(100, 8));
        }
        public double CalculateSumOfDebt(int rental, int daysToPay)
        {
            double penaltyFirstDays, penaltyMiddleDays, penaltyLongDays;
            PenalityComputationForDifferentDays(rental, out penaltyFirstDays, out penaltyMiddleDays, out penaltyLongDays);
            
            if ((daysToPay >= 1) && (daysToPay <= 10))
                return rental + penaltyFirstDays;
            if ((daysToPay >= 11) && (daysToPay <= 30))
                return rental + penaltyMiddleDays;

            return rental + penaltyLongDays;
            
        }

      
        private static void PenalityComputationForDifferentDays(int rental, out double penaltyFirstDays, out double penaltyMiddleDays, out double penaltyLongDays)
        {
           
            double[] pricesprocentaje = { 0.002, 0.05, 0.1 };
            penaltyFirstDays = pricesprocentaje[0] * rental;
            penaltyMiddleDays = pricesprocentaje[1] * rental;
            penaltyLongDays = pricesprocentaje[2] * rental;
        }
    }
}
