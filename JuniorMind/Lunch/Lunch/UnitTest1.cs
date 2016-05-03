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
            Assert.AreEqual(8, FindCMMDC(2, 8));
        }

        public int FindCMMMC( int friendOne, int friendTwo)
        {
            if (IsPrime(friendOne) && IsPrime(friendTwo))
                return friendOne *= friendTwo;
            return friendOne * friendTwo / FindCMMDC(friendOne, friendTwo);
        }
        public int FindCMMDC(int a , int b)
        {

            while (a != b)
            {
                if (a > b)
                    return a -= b;
                return b -= a;

            }
            return a;
        }
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number)
                    return false;
            }
            return true;
        }
    }
}
