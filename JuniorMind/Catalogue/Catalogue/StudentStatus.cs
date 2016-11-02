using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{
    public class StudentStatus
    {
        public Student Student { get; set; }

        private SchoolResult[] results;
        public SchoolResult[] Results
        {
            get
            {
                return results;
            }
        }

        public StudentStatus(Student student)
        {
            Student = student;
            this.results = new SchoolResult[3];
        }
    }
}
