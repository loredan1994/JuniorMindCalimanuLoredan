using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclometer_oop
{
    class Cyclist 
    {
        private string name;
        private int diameter;
        private int[] noOfRotations;

        public Cyclist(string name, int diameter, int[] noOfRotations)
        {
            this.name = name;
            this.diameter = diameter;
            this.noOfRotations = noOfRotations;
        }

        public double GetDistanceForACyclist()
        {
            double totalNoOfRot = 0;
            for (int i = 0; i < noOfRotations.Length; i++)
            {
                totalNoOfRot += diameter * Math.PI * noOfRotations[i];
            }
            return totalNoOfRot;
        }

        public double GetAverageSpeed()
        {
            return Math.Round(GetDistanceForACyclist() / noOfRotations.Length, 2);
        }
        public int GetMaximumSpeed()
        {
            int maximumRotations = noOfRotations[0];
            for (int i = 1; i < noOfRotations.Length; i++)
                if (maximumRotations < noOfRotations[i])
                    maximumRotations = noOfRotations[i];

            return maximumRotations * diameter;
        }
        public int GetSecondInWhichTheSpeedWasReached(int speed)
        {
            int numberOfRotations = speed / diameter;

            int position = 1;  

            for (int i = 1; i < noOfRotations.Length; i++)
                if (noOfRotations[i] == numberOfRotations)
                    position = i + 1;

            return position;
        }


    }
    }


