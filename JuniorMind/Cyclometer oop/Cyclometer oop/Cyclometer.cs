using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclometer_oop
{   
    class Cyclometer
    {
        private Cyclist[] cyclists;

        public Cyclometer(Cyclist[] cyclists )
        {
            this.cyclists = cyclists;
            
        }
        public struct Performances
        {
            public int second;
            public int rotations;
            public Performances(int second, int rotations)
            {
                this.second = second;
                this.rotations = rotations;
            }
        }
        public struct NameSecond
        {
            public string name;
            public int second;

            public NameSecond(string name, int second)
            {
                this.name = name;
                this.second = second;
            }
        }

        public double GetTotalDistance()
        {
            double distance = 0;
            for (int i = 0; i <cyclists.Length; i++)
                distance += cyclists[i].GetDistanceForACyclist();
            return Math.Round(distance, 2);
        }
        public double GetMaximumSpeedOfOneCyclist()
        {
            double fastestSpeed = cyclists[0].GetAverageSpeed();
            for (int i = 1; i < cyclists.Length; i++)
            {
                double currentAverageSpeed = cyclists[i].GetAverageSpeed();
                if (fastestSpeed < currentAverageSpeed)
                    fastestSpeed = currentAverageSpeed;
            }
            return fastestSpeed;
        }
        public double GetFastestAverageSpeed()
        {
            double bestAverageSpeed = cyclists[0].GetDistanceForACyclist() / GetMaximumSpeedOfOneCyclist();
            double cyclistSpeed = 0;
            double speedster = GetMaximumSpeedOfOneCyclist(); 
            for (int i = 1; i < cyclists.Length; i++)
            {
                cyclistSpeed = cyclists[0].GetDistanceForACyclist() / GetMaximumSpeedOfOneCyclist();
                if (cyclistSpeed > bestAverageSpeed)
                {
                    bestAverageSpeed = cyclistSpeed;
                }
            }
            return bestAverageSpeed;

        }
        
        }

    }
