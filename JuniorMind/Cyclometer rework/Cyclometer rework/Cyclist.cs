using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclometer_rework
{
    class Cyclist
    {
        private int diameter;
        private string name;
        private int cyclometer;
        private int noOfRotations;
        private string cyclists;
        public Cyclist(string name, int diameter, int noOfRotations, int cyclist)
        {
            this.cyclists = cyclists ;
            this.name = name;
            this.diameter = diameter;
            this.noOfRotations = noOfRotations;

        }
        public double ComputeTheDistanceOfACyclist(Cyclist cyclist)
        {
            double distance = 0;
            for (int i = 0; i < name.Length; i++)
                distance += Math.PI * diameter * noOfRotations;

            return Math.Round(distance, 2);
        }
        private double ComputeTotalDistance(Cyclist cyclists)
        {
            double distance = 0;
            for (int i = 0; i < cyclists.Length; i++)
                distance += ComputeTheDistanceOfACyclist(cyclists[i]);
            return Math.Round(distance, 2);
        }
        public  double CalculateAverageSpeed(Cyclist cyclist)
        {
            return Math.Round(ComputeTheDistanceOfACyclist(cyclist) / cyclist.cyclometer, 2);
        }
        


    }
}
