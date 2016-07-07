using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            return ;
        }
        public enum Direction {
            up,
            down,
            right,
            left,
        }
        public struct Cursor
        {
            public int xAxis;
            public int yAxis;
            public Cursor( int xAxis , int yAxis)
            {
                this.xAxis = xAxis;
                this.yAxis = yAxis;
            }
        }
    }
}
