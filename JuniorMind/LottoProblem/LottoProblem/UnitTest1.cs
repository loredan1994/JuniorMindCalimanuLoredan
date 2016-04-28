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
            Assert.AreEqual(0.0000000715,GetProbabilities(5, 5, 40), 0.00001);
        }
        [TestMethod]
        public void ComputeFactorial()
        {
            Assert.AreEqual(24, GetFactorial(4));
        }
        [TestMethod]
        public void CalculationOfCombinations()
        {
            Assert.AreEqual(4, combinationsOfNumbers(4, 3));
        }
        [TestMethod]
        public void CathegoryIforLotto()
        {
            Assert.AreEqual(4.29067430521111E-07, GetProbabilities(6, 6, 49), 0.000001);

        }
        [TestMethod]
        public void CathegoryIIforLotto()
        {
            Assert.AreEqual(0.0000000715, GetProbabilities(5, 6, 49), 0.000001);
        }
        [TestMethod]
        public void CathegoryIIIforLotto()
        {
            Assert.AreEqual(0.0000000715, GetProbabilities(4, 6, 49), 0.000001);
        }
        [TestMethod]
        public void CathegoryIVforLotto()
        {
            Assert.AreEqual(0.0000000715, GetProbabilities(3, 6, 49), 0.000001);
        }
        public double GetProbabilities(int favorableCases, int PossibleCases, int totalNumbers)
        {
            double probabilities = (favorableCases * (GetFactorial(totalNumbers - PossibleCases) * GetFactorial(PossibleCases))) / GetFactorial(totalNumbers);
            return probabilities;
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

        public double combinationsOfNumbers(int n, int k)
        {
            return GetFactorial(n) / (GetFactorial(k) * (GetFactorial(n - k)));

        }
    }
    
}
