using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Athletrepetitions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double FirstTest = AthletRounds(2);
            Assert.AreEqual(4,FirstTest);
        }
        double AthletRounds(int numberofrepetions)
        {
            return Math.Pow(numberofrepetions, 2);
        }
    }
}
