using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclists
{
    class Class1
    {
            private struct Cyclometer
            {
                public int second;
                public int noOfRotations;
                public Cyclometer(int second, int noOfRotations)
                {
                    this.second = second;
                    this.noOfRotations = noOfRotations;
                }
            }
            private struct Cyclist
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
            private struct CylistNameAndSecond
            {
                public string name;
                public int second;
                public CylistNameAndSecond(string name, int second)
                {
                    this.name = name;
                    this.second = second;

                }
            }
            private double ComputeTheDistanceOfACyclist(Cyclist cyclist)
            {
                double distance = 0;
                for (int i = 0; i < cyclist.cyclometer.Length; i++)
                    distance += Math.PI * cyclist.diameter * cyclist.cyclometer[i].noOfRotations;

                return Math.Round(distance, 2);
            }
            private double ComputeTotalDistance(Cyclist[] cyclists)
            {
                double distance = 0;
                for (int i = 0; i < cyclists.Length; i++)
                    distance += ComputeTheDistanceOfACyclist(cyclists[i]);
                return Math.Round(distance, 2);
            }
            private double CalculateAverageSpeed(Cyclist cyclist)
            {
                return Math.Round(ComputeTheDistanceOfACyclist(cyclist) / cyclist.cyclometer.Length, 2);
            }
            private Cyclist CalculateMaximumSpeed(Cyclist[] cyclists)
            {
                Cyclist fastestCyclist = cyclists[0];
                for (int j = 0; j < cyclists.Length; j++)
                {
                    fastestCyclist = CalculateAverageSpeed(fastestCyclist) > CalculateAverageSpeed(cyclists[j])
                        ? fastestCyclist : cyclists[j];
                }
                return fastestCyclist;
            }
            private Cyclometer ReturnMaxNoOfRotForOneCyclist(Cyclist cyclist)
            {
                Cyclometer maxNoOfRot = new Cyclometer(cyclist.cyclometer[0].noOfRotations, cyclist.cyclometer[0].second);
                for (int i = 0; i < cyclist.cyclometer.Length; i++)
                {
                    if (cyclist.cyclometer[i].noOfRotations > maxNoOfRot.noOfRotations)
                        maxNoOfRot = new Cyclometer(cyclist.cyclometer[i].noOfRotations, cyclist.cyclometer[i].second);
                }
                return maxNoOfRot;
            }
            private CylistNameAndSecond ReturnMaxSpeed(Cyclist[] cyclists)
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


        }

    }

}
}
