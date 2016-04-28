using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0.0000000715,GetProbabilities(6, 6, 49));
        }
        [TestMethod]
        public void ComputeFactorial()
        {
            Assert.AreEqual(24, GetFactorial(4));
        }
        public double GetProbabilities(int favorableCases, int PossibleCases, int totalNumbers)
        {
            double probabilities = favorableCases / PossibleCases;
            return probabilities;
        }
         public double combinationsOfNumbers(int favorableCases , int PossibleCases)
        {
            double combinations = GetFactorial(favorableCases) / GetFactorial(favorableCases - PossibleCases) * GetFactorial(PossibleCases);
            return combinations;
        }
        public int GetFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;

            }

            return result;

        }
    }
    
}
