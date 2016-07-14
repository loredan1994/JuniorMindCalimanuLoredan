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
            Direction[] firstIntersection = new Direction[]
         {
                Direction.up,
                Direction.right,
                Direction.down,
                Direction.left
         } ;
            Assert.AreEqual(new Cursor(0, 0), ReturnPickCase(new Cursor(0,1), firstIntersection));
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
    public Cursor  ReturnPickCase ( Cursor cursor , Direction[] direction )
        {
            int xAxis = 0;
            int yAxis = 0;
            Cursor[] checkPoint = new Cursor[direction.Length];
            for (int i = 0 ; i < direction.Length; i++)
            {
                if (direction[i] == Direction.up)    xAxis++;
                if (direction[i] == Direction.down)  xAxis--;
                if (direction[i] == Direction.left)  yAxis--;
                if (direction[i] == Direction.right) yAxis++;
                for(int j = 0; j< checkPoint.Length; j++)
                {
                    if (IntersectPointCheck(xAxis, yAxis, checkPoint, j)) return checkPoint[j];
                }

                checkPoint[i].xAxis = xAxis;
                checkPoint[i].yAxis = yAxis;
            }
            return checkPoint[0];
            
        }
        public static bool IntersectPointCheck( int xAxis , int yAxis , Cursor[] checkPoint, int  j )
        {
            { 
            return (checkPoint[j].xAxis == xAxis && checkPoint[j].yAxis == yAxis) ;
            }
           

        }

    }
}
