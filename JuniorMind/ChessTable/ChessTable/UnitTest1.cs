using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingForTwoLines()
        {
            Assert.AreEqual(49, (GetNumberOfSquares(2)));
        }
        public int GetNumberOfSquares(int squares)
        {
            return 0;
        }
    }
}
