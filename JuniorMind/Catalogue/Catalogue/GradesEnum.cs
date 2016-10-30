using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{
    public class GradesEnum:IEnumerator
    {
        public Student[] student;
        int position = -1;

        public GradesEnum(Student[] list)
        {
            student = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < student.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return student[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }
}