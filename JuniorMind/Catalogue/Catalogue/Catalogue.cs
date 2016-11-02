using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{
    public class Catalogue
    {
        private StudentStatus[] statuses;

        public StudentStatus[] Statuses
        {
            get { return statuses; }
        }

        public Catalogue(int numberOfStudents)
        {
            statuses = new StudentStatus[numberOfStudents];
        }
    }
}
