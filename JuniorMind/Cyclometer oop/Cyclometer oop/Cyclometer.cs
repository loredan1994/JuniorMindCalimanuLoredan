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
        public Cyclist GetCyclistWithHighestSpeed()
        {
            Cyclist fastestCyclist = cyclists[0];

            for (int i = 1; i < cyclists.Length; i++)
                if (fastestCyclist.GetMaximumSpeed() < cyclists[i].GetMaximumSpeed())
                    fastestCyclist = cyclists[i];
            return fastestCyclist;

        }

    }

    }
