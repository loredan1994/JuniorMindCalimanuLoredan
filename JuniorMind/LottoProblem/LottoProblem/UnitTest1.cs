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
            Assert.AreEqual(0.0000000715, GetProbabilities(49, 6, 6), 1e-10);



        }
        [TestMethod]
        public void CathegoryIIforLotto()
        {
            Assert.AreEqual(0.0000184, GetProbabilities(49, 6, 5),1e-5);
        }
        [TestMethod]
        public void CathegoryIIIforLotto()
        {
            Assert.AreEqual(0.000969, GetProbabilities(49, 6, 4), 1e-5);
        }
        [TestMethod]
        public void CathegoryIVforLotto()
        {
            Assert.AreEqual(0.0177, GetProbabilities(49, 6 ,3), 1e-3);
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
