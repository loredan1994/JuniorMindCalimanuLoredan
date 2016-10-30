using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 namespace Catalogue

{
    public class Grades : IEnumerable
    {
        private Student[] student = new Student[0];

        public static string[] SortAlphabetically(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (String.Compare(students[j], students[j + 1]) > 0)
                        Swap(ref students[j], ref students[j + 1]);
                }
            }
            return students;
        }
        static void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public GradesEnum GetEnumerator()
        {
            return new GradesEnum(student);
        }
    }
}
