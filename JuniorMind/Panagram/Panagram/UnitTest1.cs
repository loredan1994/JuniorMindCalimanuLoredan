using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfPanagram()
        {
            Assert.AreEqual(true, CheckIfPanagram("The quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void CalculatePanagram()
        {
            Assert.AreEqual(false, CheckIfPanagram("I Do not care"));
        }
        [TestMethod]
        public void PanagramTesting()
        {
            Assert.AreEqual(true, CheckIfPanagram("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
        }
        [TestMethod]
        public void FailedPanagramTesting()
        {
            Assert.AreEqual(false, CheckIfPanagram("cBCDEFGHIJKLMNOPQRSTUVWXYZ"));
        }
        public bool CheckIfPanagram(string statement)
        {
            string makeLowCaseAll = statement.ToLower();
            if (TestIfPanagram(makeLowCaseAll))
                return true;
            return false;
        }
        public bool TestIfPanagram(string panagramStatement)
        {

            for (int i = 'a'; i < 'z'; i++)

            {
                int counter = Count(panagramStatement, i);
                if (counter == 0)
                    return false;

            }

            return true;

        }

        private static int Count(string panagramStatement, int i)
        {
            int counter = 0;

            for (int j = 0; j < panagramStatement.Length; j++)
            {
                if (panagramStatement[j] == i) counter++;
            }

            return counter;
        }
    }
}
