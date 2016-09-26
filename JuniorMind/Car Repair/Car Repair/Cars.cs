using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Repair

{
    public enum PriorityLevel
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public class Cars
    {

        private PriorityLevel priority;
        private int number;
        public PriorityLevel Priority
        {
            get
            {
                return priority;
            }
            set
            {
                value = priority;
            }
        }
        public Cars(PriorityLevel priority, int number)
        {
            this.priority = priority;
            this.number = number;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Cars))
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            return number;
        }
        public int CompareTo(Cars other)
        {
            return priority.CompareTo(other.priority);
        }
    }
}
