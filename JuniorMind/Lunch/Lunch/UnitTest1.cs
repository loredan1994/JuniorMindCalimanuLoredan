using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FidingTheDays()
        {
            Assert.AreEqual(12, FindCMMMC(6, 4));
        }
        [TestMethod]
        public void ForEqualNumberOfDays()
        {
            Assert.AreEqual(4, FindCMMMC(4, 4));
        }
        [TestMethod]
        public void WhenfriendTwoIsBiggerThanfriendOne()
        {
            Assert.AreEqual(12, FindCMMMC(4, 6));
        }
        [TestMethod]
        public void WhenWeGotPrimeNumbers()
        {
            Assert.AreEqual(21, FindCMMMC(3, 7));

        }
        [TestMethod]
        public void NewTestMethod()
        {
            Assert.AreEqual(8, FindCMMMC(2, 8));
        }
        public int FindCMMDC(int a, int b)
        {

            int rest;
            rest = a % b;
            while (rest != 0)
            {
                a = b;
                b = rest;
                rest = a % b;
            }
            return b;
        }

        public int FindCMMMC( int friendOne, int friendTwo)
        {
            return (friendOne * friendTwo) / FindCMMDC(friendOne, friendTwo);
        }
    }
}
