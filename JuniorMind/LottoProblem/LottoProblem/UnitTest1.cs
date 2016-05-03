using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CathegoryIforSpecialLotto()
        {
            Assert.AreEqual(1.51973836184362E-06, GetProbabilities(40,5,5), 0.000001);
        }
        [TestMethod]
        public void ComputeFactorial()
        {
            Assert.AreEqual(24, GetFactorial(4));
        }
        [TestMethod]
        public void CalculationOfCombinations()
        {
            Assert.AreEqual(4, CombinationsOfNumbers(4, 3));
        }
        [TestMethod]
        public void CalculateCombinationsOfNumbers()
        {
            Assert.AreEqual(252, CombinationsOfNumbers(10, 5));
        }
        [TestMethod]
        public void CathegoryIforLotto()
        {
            Assert.AreEqual(4.29067430521111E-07, GetProbabilities(49,6,6), 0.000001);

        }
        [TestMethod]
        public void CathegoryIIforLotto()
        {
            Assert.AreEqual(1.84498995124078E-05, GetProbabilities(49, 6, 5),0.000001);
        }
        [TestMethod]
        public void CathegoryIIIforLotto()
        {
            Assert.AreEqual(0.000968619724401408, GetProbabilities(49, 6, 4), 0.000001);
        }
        [TestMethod]
        public void CathegoryIVforLotto()
        {
            Assert.AreEqual(0.0176504038668701, GetProbabilities(49, 6 ,3), 0.000001);
        }
        public double GetProbabilities(int numberOfBallsInLottery, int numberOfBallsInATicket, int numberOfMatchingBalls )
        {
            return (CombinationsOfNumbers(numberOfBallsInATicket, numberOfMatchingBalls) * CombinationsOfNumbers(numberOfBallsInLottery - numberOfBallsInATicket, numberOfBallsInATicket - numberOfMatchingBalls)) / CombinationsOfNumbers(numberOfBallsInLottery, numberOfBallsInATicket);
        }

        public double GetFactorial(int number)
        {
            double result = 1;
            while (number != 0)
            {
                result *= number;
                number--;
            }
            return result;
        }

        public double CombinationsOfNumbers(int n, int k)
        {
            return GetFactorial(n) / (GetFactorial(k) * (GetFactorial(n - k)));

        }
    }
    
}
