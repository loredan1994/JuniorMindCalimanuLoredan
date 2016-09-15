using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclometer_oop
{
    [TestClass]
    public class Test
    {
       [TestMethod]
       public void DistanceForOneCyclist()
        {
            var cyclist = new Cyclist("A", 4, new int[] { 1, 2, 3, });
            double agent = cyclist.GetDistanceForACyclist();
            Assert.AreEqual(75.39, agent, 1e-2);
        }

        [TestMethod]
        public void DistanceForAllCyclists()
        {
            var andrei= new Cyclist("A", 4, new int[] { 1, 2, 3, });
            var mihai = new Cyclist("M", 4, new int[] { 1, 2, 3, });
            var cyclometer = new Cyclometer(new Cyclist[] { andrei, mihai});

            Assert.AreEqual(150.8, cyclometer.GetTotalDistance());
        }
        [TestMethod]
        public void MaxSpeedOfCyclist()
        {
            var andrei = new Cyclist("A", 4, new int[] { 1, 3, 3, });
            var mihai = new Cyclist("M", 4, new int[] { 1, 2, 3, });
            var cyclometer = new Cyclometer(new Cyclist[] { andrei, mihai });
            Assert.AreEqual(29.32, cyclometer.GetMaximumSpeedOfOneCyclist());

        }
        [TestMethod]
        public void GetBestAverageSpeed()
        {
            var andrei = new Cyclist("A", 4, new int[] { 1, 3, 3, });
            var mihai = new Cyclist("M", 4, new int[] { 1, 2, 3, });
            var cyclometer = new Cyclometer(new Cyclist[] { andrei, mihai });
            Assert.AreEqual(3.00, cyclometer.GetFastestAverageSpeed(), 0.001);
        }
        [TestMethod]
        public void CyclistWithHighestSpeedAndSecond()
        {
            var andrei = new Cyclist("A", 3, new int[] { 2, 4, 4 });
            var bogdan = new Cyclist("B", 5, new int[] { 1, 3, 2 });
            var daniel = new Cyclist("D", 4, new int[] { 1, 3, 2 });
            var mihai = new Cyclist("M", 3, new int[] { 2, 4, 3 });

            var cyclometer = new Cyclometer(new Cyclist[] { andrei, bogdan, daniel, mihai });

            var fastestCyclist = cyclometer.GetCyclistWithHighestSpeed();

            Assert.AreEqual(bogdan, fastestCyclist);

            Assert.AreEqual(15, fastestCyclist.GetMaximumSpeed());

            int maximumSpeed = fastestCyclist.GetMaximumSpeed();

            Assert.AreEqual(2, fastestCyclist.GetSecondInWhichTheSpeedWasReached(maximumSpeed));
        }
    }
}
