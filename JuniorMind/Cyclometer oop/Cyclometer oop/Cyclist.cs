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

        public double CalculateDistanceForACyclist( )
        {
            double totalNoOfRot = 0;
            for (int i = 0; i < noOfRotations.Length; i++)
            {
                totalNoOfRot += diameter* Math.PI *noOfRotations[i];
            }
            return totalNoOfRot;
        }

        public double CalculateAverageSpeed()
        {
            return Math.Round(CalculateDistanceForACyclist() / noOfRotations.Length, 2);
        }
        
        
    }
}

