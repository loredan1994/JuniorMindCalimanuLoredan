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
            double fastestcyclist = new double();
            for (int i = 0; i < cyclists.Length; i++)
            {
                fastestcyclist = fastestcyclist > cyclists[i].CalculateAverageSpeed() ? fastestcyclist : cyclists[i];
            }
            return fastestcyclist;
        }
    }
}
