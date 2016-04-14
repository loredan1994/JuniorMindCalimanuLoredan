using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvenMelon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("NO it's odd", CalculateIfTheWatermelonisEven(21));
        }
        [TestMethod]
        public void MyTestMethod2()
        {
            Assert.AreEqual("YES it is even", CalculateIfTheWatermelonisEven(20));
        }
        public string CalculateIfTheWatermelonisEven(int melon)
        {
           

            if ((melon > 2) && (melon % 2 == 0))
            return "YES it is even";

            else return "NO it's odd";
        }
    }
}
