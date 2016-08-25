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

        public Cyclometer(Cyclist[] cyclists)
        {
            this.cyclists = cyclists;
        }

        public double ComputeTotalDistance()
        {
            double distance = 0;
            for (int i = 0; i <cyclists.Length; i++)
                distance += cyclists[i].CalculateDistanceForACyclist();
            return Math.Round(distance, 2);
        }
        public double CalculateMaximumSpeedOfOneCyclist()
        {
            int[] fastestcyclist = new int[0];
            for (int i = 0; i < cyclists.Length; i++)
            {
              fastestcyclist = fastestcyclist[0].CalculateAverageSpeed() > cyclists[i].CalculateAverageSpeed() ? fastestcyclist : cyclists[i];
            }
            return fastestcyclist;
        }
    }
}
