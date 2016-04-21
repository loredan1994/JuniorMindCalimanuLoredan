using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingForTwoSquares()
        {
            Assert.AreEqual(5, (GetNumberOfSquares(2)));
        }
        [TestMethod]
        public void TestingForThreeSquares()
        {
            Assert.AreEqual(14, (GetNumberOfSquares(3)));
        }
        [TestMethod]
        public void TestingForFourSquares()
        {
            Assert.AreEqual(30, (GetNumberOfSquares(4)));
        }
        [TestMethod]
        public void TestingForFiveSquares()
        {
            Assert.AreEqual(55, (GetNumberOfSquares(5)));
        }
        [TestMethod]
        public void TestingForSixSquares()
        {
            Assert.AreEqual(91, (GetNumberOfSquares(6)));
        }
        [TestMethod]
        public void TestingForSevenSquares()
        {
            Assert.AreEqual(140, (GetNumberOfSquares(7)));
        }
        [TestMethod]
        public void TestingForEightSquares()
        {
            Assert.AreEqual(204, (GetNumberOfSquares(8)));
        }
        [TestMethod]
        public void TestingForNineSquares()
        {
            Assert.AreEqual(285, (GetNumberOfSquares(9)));
        }
        [TestMethod]
        public void TestingForTenSquares()
        {
            Assert.AreEqual(385, (GetNumberOfSquares(10)));
        }
        public int GetNumberOfSquares(int squares)
        {
            int computation = 0;
            while (squares > 0)
            {
                computation = computation + (squares* squares);
                squares--;
            }
            return computation;

        }
    }
}
