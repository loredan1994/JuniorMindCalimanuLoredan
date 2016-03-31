using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersTerrain
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitialTerrain()
        {
            Assert.AreEqual(770, ComputationOfTheSquareSurface(770));        }
        int ComputationOfTheSquareSurface(int length)
        {
           double delta =Math.Sqrt(Math.Pow(230,2)+4*770000));
            return length = (int)(-230 + delta) / 2;
        }
    }
}
