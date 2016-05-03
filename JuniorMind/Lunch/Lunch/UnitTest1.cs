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
        public void WhenFriendTwoIsBiggerThanFriendOne()
        {
            Assert.AreEqual(12, FindCMMMC(4, 6));
        }
        [TestMethod]
        public void WhenWeGotPrimeNumbers()
        {
            Assert.AreEqual(21, FindDifferenceOfDays(3, 7));

        }
        public int FindDifferenceOfDays(int FriendOne, int FriendTwo)
        {
           
            while (FriendOne != FriendTwo)
            {
                if (IsPrime(FriendOne) && IsPrime(FriendTwo))
                    return FriendTwo * FriendOne;
                if (FriendOne>FriendTwo)
                    return FriendOne -= FriendTwo;
                if(FriendTwo>FriendOne)
                    return FriendTwo -= FriendOne;
            }
            return  FriendOne;
        }
        public int FindCMMMC( int FriendOne, int FriendTwo)
        {
            return FriendOne * FriendTwo / FindDifferenceOfDays(FriendOne, FriendTwo);
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
