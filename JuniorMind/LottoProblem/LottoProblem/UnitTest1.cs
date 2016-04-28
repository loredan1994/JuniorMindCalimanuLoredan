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
        public double GetProbabilities(int favorableCases, int PossibleCases, int totalNumbers)
        {
            double probabilities = favorableCases / PossibleCases;
            return probabilities;
        }
    }
    
}
