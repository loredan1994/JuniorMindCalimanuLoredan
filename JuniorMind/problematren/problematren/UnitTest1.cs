
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainProblemSolution
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceCheck()
        {
            float FirstTest = Travel(25);
            Assert.AreEqual(12,5,FirstTest);
        }
        public float Travel(float distance)
        {


            return distance / 2;
        }
    }
}