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
        public int FindDifferenceOfDays(int FriendOne, int FriendTwo)
        {
            int smallDivider=0;
            while (FriendOne != FriendTwo)
            {
                if(FriendOne>FriendTwo)
                return FriendOne = FriendOne - FriendTwo;
                return FriendTwo = FriendTwo - FriendOne;               
            }
            return smallDivider = FriendOne;
        }
        public int FindCMMMC( int FriendOne, int FriendTwo)
        {
            return FriendOne * FriendTwo / FindDifferenceOfDays(FriendOne, FriendTwo);
        }
    }
}
