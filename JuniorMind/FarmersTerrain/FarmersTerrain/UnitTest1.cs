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
            Assert.AreEqual(588, ComputationOfTheSquareSurface(770,800000));        }
        int ComputationOfTheSquareSurface(int lengthbougth ,int totalsurfaceaterbuying)
        {
           double delta =Math.Sqrt(Math.Pow(lengthbougth,2)+4*totalsurfaceaterbuying);
            return  (int)(-lengthbougth + delta) / 2;
        }
    }
}
