using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcellProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForOneLetter()
        {
            Assert.AreEqual("A", CalculateColumn(1));
        }
        [TestMethod]
        public void ForTwoLetters()
        {
            Assert.AreEqual("AA", CalculateColumn(27));
        }
        [TestMethod]
        public void ForThreeLetters()
        {
            Assert.AreEqual("DHA", CalculateColumn(888));
        
        }
        [TestMethod]
        public void ForFourLetters()
        {
            Assert.AreEqual("SERA", CalculateColumn(29893));
        }
        public string CalculateColumn(int numberGiven)
        {
            int i = 0;
            string result = string.Empty;

            while (numberGiven > 0)
            {
                numberGiven--;
                result += ToChar(numberGiven % 26);
                numberGiven /= 26;
            }
            return result;



        }

        private static char ToChar(int numberGiven)
        {
            return ((char)('A' + numberGiven));
        }
    }
}
