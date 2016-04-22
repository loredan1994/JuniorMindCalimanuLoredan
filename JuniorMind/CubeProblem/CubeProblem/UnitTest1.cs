using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForNumberOne()
        {
            Assert.AreEqual(192, SeeIfMultiplier(1));
        }
        [TestMethod]
        public void TestMethodForNumberTwo()
        {
            Assert.AreEqual(442, SeeIfMultiplier(2));
        }
        [TestMethod]
        public void TestMethodForNumberThree()
        {
            Assert.AreEqual(692, SeeIfMultiplier(3));

        }
        [TestMethod]
        public void TestMethodForNumberFour()
        {
            Assert.AreEqual(942, SeeIfMultiplier(4));
        }
        public int SeeIfMultiplier(int number)
        {
            int i = 0;
            int cube = 0;
            int multiplication = 0;
            while(multiplication != number)
            {
                i++;
                cube = i * i * i;
                if((cube % 1000 == 888))
                {
                    multiplication++;
                }
            }
            return i;
        }
    }
}
