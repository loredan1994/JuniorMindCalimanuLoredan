using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
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
        public struct Cyclometer
        {
            public int second;
            public int noOfRotations;
            public Cyclometer(int second, int noOfRotations)
            {
                this.second = second;
                this.noOfRotations = noOfRotations;
            }
        }
        public struct Cyclist
        {
            public string name;
            public int diameter;
            public Cyclometer[] cyclometer;
            public Cyclist(string name, int diameter, Cyclometer[] cyclometer)
            {
                this.name = name;
                this.diameter = diameter;
                this.cyclometer = cyclometer;
            }
        }
        public struct CylistNameAndSecond
        {
            public string name;
            public int second;
            public CylistNameAndSecond(string name, int second)
            {
                this.name = name;
                this.second = second;

            }
        }
        public double ComputeTheDistanceOfACyclist(Cyclist cyclist)
        {
            double distance = 0;
            for (int i = 0; i < cyclist.cyclometer.Length; i++)
                distance += Math.PI * cyclist.diameter * cyclist.cyclometer[i].noOfRotations;

            return Math.Round(distance, 2);
        }
        public double ComputeTotalDistance(Cyclist[] cyclists)
        {
            double distance = 0;
            for (int i = 0; i < cyclists.Length; i++)
                distance += ComputeTheDistanceOfACyclist(cyclists[i]);
            return Math.Round(distance, 2);
        }
        public double CalculateAverageSpeed(Cyclist cyclist)
        {
            return Math.Round(ComputeTheDistanceOfACyclist(cyclist) / cyclist.cyclometer.Length, 2);
        }
        public Cyclist CalculateMaximumSpeed(Cyclist[] cyclists)
        {
            Cyclist fastestCyclist = cyclists[0];
            for (int j = 0; j < cyclists.Length; j++)
            {
                fastestCyclist = CalculateAverageSpeed(fastestCyclist) > CalculateAverageSpeed(cyclists[j])
                    ? fastestCyclist : cyclists[j];
            }
            return fastestCyclist;
        }
        public Cyclometer ReturnMaxNoOfRotForOneCyclist(Cyclist cyclist)
        {
            Cyclometer maxNoOfRot = new Cyclometer(cyclist.cyclometer[0].noOfRotations, cyclist.cyclometer[0].second);
            for (int i = 0; i < cyclist.cyclometer.Length; i++)
            {
                if (cyclist.cyclometer[i].noOfRotations > maxNoOfRot.noOfRotations)
                    maxNoOfRot = new Cyclometer(cyclist.cyclometer[i].noOfRotations, cyclist.cyclometer[i].second);
            }
            return maxNoOfRot;
        }
        public CylistNameAndSecond ReturnMaxSpeed(Cyclist[] cyclists)
        {
            CylistNameAndSecond fastest = new CylistNameAndSecond(cyclists[0].name, cyclists[0].cyclometer[0].second);
            int maxSpeed = 0;
            for (int j = 0; j < cyclists.Length; j++)
            {
                Cyclometer maxNumberOfRotations = ReturnMaxNoOfRotForOneCyclist(cyclists[j]);
                int speed = cyclists[j].diameter * maxNumberOfRotations.noOfRotations;
                if (speed > maxSpeed)
                {
                    maxSpeed = speed;
                    fastest = new CylistNameAndSecond(cyclists[j].name, maxNumberOfRotations.second);
                }
            }
            return fastest;
        }
        [TestMethod]
        public void TestMaxNumberOfRotations()
        {
            var cyclist = new Cyclist("Vasile", 2, new Cyclometer[] { new Cyclometer(2, 1), new Cyclometer(6, 2), new Cyclometer(3, 3) });
            Assert.AreEqual(cyclist.cyclometer[2], ReturnMaxNoOfRotForOneCyclist(cyclist));
        }

    }
}
