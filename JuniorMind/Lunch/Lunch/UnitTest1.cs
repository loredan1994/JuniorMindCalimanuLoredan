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
            Assert.AreEqual(21, FindDifferenceOfDays(3, 7));

        }
        public int FindDifferenceOfDays(int friendOne, int friendTwo)
        {
           
             if (IsPrime(friendOne) && IsPrime(friendTwo))
                    return friendTwo * friendOne;
                if (friendOne>friendTwo)
                    return friendOne -= friendTwo;
                if(friendTwo>friendOne)
                   return friendTwo -= friendOne;
            
            return  friendOne;
        }
        public int FindCMMMC( int friendOne, int friendTwo)
        {
            return friendOne * friendTwo / FindDifferenceOfDays(friendOne, friendTwo);
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
