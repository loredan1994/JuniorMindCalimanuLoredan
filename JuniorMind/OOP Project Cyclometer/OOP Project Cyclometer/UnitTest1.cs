using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections;

namespace OOP_Project_Cyclometer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDistanceForOneCyclist()
        {
            var cyclist = new Cyclist("Vasile", 4, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(4, 2) });

            Assert.AreEqual(37.7, ComputeTheDistanceOfACyclist(cyclist));
        }
        [TestMethod]
        public void TestTotalDistance()
        {
            var cyclists = new Cyclist[] {
                                        new Cyclist("Vasile", 4, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(5, 2) }),
                                        new Cyclist("Ion", 3, new Cyclometer[] { new Cyclometer(3, 1), new Cyclometer(4, 2) }),
                                        new Cyclist("Grigore", 2, new Cyclometer[] { new Cyclometer(4, 1), new Cyclometer(3, 2) }) };

            Assert.AreEqual(84.82, ComputeTotalDistance(cyclists));
        }
        [TestMethod]
        public void AverageSpeedCyclist()
        {
            var cyclist = new Cyclist("Vasile", 4, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(5, 2), new Cyclometer(6, 3) });
            Assert.AreEqual(25.13, CalculateAverageSpeed(cyclist), 0.001);
        }
        [TestMethod]
        public void CalculateMaximumSpeed()
        {
            var cyclists = new Cyclist[] {
                                        new Cyclist("Vasile", 4, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(5, 2) }),
                                        new Cyclist("Ion", 3, new Cyclometer[] { new Cyclometer(3, 1), new Cyclometer(4, 2) }),
                                        new Cyclist("Grigore", 2, new Cyclometer[] { new Cyclometer(4, 1), new Cyclometer(3, 2) }) };

            Assert.AreEqual(cyclists[0], CalculateMaximumSpeed(cyclists));
        }
        [TestMethod]
        public void TestMaxNumberOfRotations()
        {
            var cyclist = new Cyclist("Vasile", 2, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(6, 2), new Cyclometer(3, 3) });
            Assert.AreEqual(cyclist.cyclometer[2], ReturnMaxNoOfRotForOneCyclist(cyclist));
        }

    }
}
