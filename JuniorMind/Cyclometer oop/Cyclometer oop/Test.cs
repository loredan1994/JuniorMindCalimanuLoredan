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
            double agent = cyclist.CalculateDistanceForACyclist();
            Assert.AreEqual(75.39, agent, 1e-2);
        }

        [TestMethod]
        public void DistanceForAllCyclists()
        {
            var andrei= new Cyclist("A", 4, new int[] { 1, 2, 3, });
            var mihai = new Cyclist("M", 4, new int[] { 1, 2, 3, });
            var cyclometer = new Cyclometer(new Cyclist[] { andrei, mihai});

            Assert.AreEqual(150.8, cyclometer.ComputeTotalDistance());
        }
    }
}
