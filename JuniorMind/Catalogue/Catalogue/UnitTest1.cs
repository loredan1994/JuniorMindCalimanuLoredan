using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Catalogue
{
    [TestClass]
    public class UnitTest
    {
        private Catalogue testCatalogue;

        private void initAllData()
        {
            testCatalogue = new Catalogue(3);

            Student student1 = new Student() { FirstName = "Daniel", LastName = "Popescu", YearOfStudy = 3 };
            Student student2 = new Student() { FirstName = "George", LastName = "Georgescu", YearOfStudy = 2 };
            Student student3 = new Student() { FirstName = "Alexandru", LastName = "Teodoroiu", YearOfStudy = 2 };

            StudentStatus status1 = new StudentStatus(student1);
            setValuesForStatus(status1, 0, 7, SchoolObject.ComputerScience);
            setValuesForStatus(status1, 1, 6, SchoolObject.History);
            setValuesForStatus(status1, 2, 5, SchoolObject.Maths);

            StudentStatus status2 = new StudentStatus(student2);
            setValuesForStatus(status2, 0, 10, SchoolObject.Maths);
            setValuesForStatus(status2, 1, 6, SchoolObject.ComputerScience);
            setValuesForStatus(status2, 2, 8, SchoolObject.History);

            StudentStatus status3 = new StudentStatus(student3);
            setValuesForStatus(status3, 0, 7, SchoolObject.History);
            setValuesForStatus(status3, 1, 4, SchoolObject.Maths);
            setValuesForStatus(status3, 2, 10, SchoolObject.ComputerScience);

            // st1 media 8
            // st2 media 7
            // st0 media 6

            testCatalogue.Statuses[0] = status1;
            testCatalogue.Statuses[1] = status2;
            testCatalogue.Statuses[2] = status3;

        }

        private static void setValuesForStatus(StudentStatus status, int index, double grade, SchoolObject schoolObject)
        {
            status.Results[index] = new SchoolResult() { Grade = grade, Object = schoolObject };
        }

        [TestMethod]
        public void OrderStudentsAlphabetically()
        {
            initAllData();

            Student[] students = getStudentsFromCatalogue();

            for (int i = 0; i < students.Length - 1; ++i)
            {
                Student studentBefore = students[i];
                for (int j = i + 1; j < students.Length; ++j)
                {
                    Student studentAfter = students[j];
                    if (studentBefore.LastName.CompareTo(studentAfter.LastName) > 0)
                    {
                        Student aux = students[i];
                        students[i] = students[j];
                        students[j] = aux;
                    }
                }
            }

            Assert.AreEqual("Georgescu" + "Popescu" + "Teodoroiu", students[0].LastName + students[1].LastName + students[2].LastName);
        }

        private Student[] getStudentsFromCatalogue()
        {
            Student[] students = new Student[testCatalogue.Statuses.Length];

            for (int index = 0; index < testCatalogue.Statuses.Length; ++index)
                students[index] = testCatalogue.Statuses[index].Student;
            return students;
        }

        [TestMethod]
        public void OrderStudentsBasedOnAverage()
        {
            initAllData();

            for (int i = 0; i < testCatalogue.Statuses.Length - 1; ++i)
            {
                for (int j = i + 1; j < testCatalogue.Statuses.Length; ++j)
                {
                    StudentStatus before = testCatalogue.Statuses[j - 1];
                    StudentStatus after = testCatalogue.Statuses[j];
                    if (getAverageForStatus(before) < getAverageForStatus(after))
                    {
                        StudentStatus aux = testCatalogue.Statuses[j - 1];
                        testCatalogue.Statuses[j - 1] = testCatalogue.Statuses[j];
                        testCatalogue.Statuses[j] = aux;
                    }
                }
            }

            Assert.AreEqual("George" + "Alexandru" + "Daniel",
                testCatalogue.Statuses[0].Student.FirstName +
                testCatalogue.Statuses[1].Student.FirstName +
                testCatalogue.Statuses[2].Student.FirstName);
        }

        private double getAverageForStatus(StudentStatus status)
        {
            double sum = 0;

            foreach (var result in status.Results)
                sum += result.Grade;
            return sum / 3;


        }

        [TestMethod]
        public void SearchStudentWithGivenAverage()
        {
            initAllData();

            StringBuilder result = new StringBuilder();

            foreach (var status in testCatalogue.Statuses)
            {
                if (getAverageForStatus(status) == 7)
                    result.Append(status.Student.ToString());
            }

            Assert.AreEqual(testCatalogue.Statuses[2].Student.ToString(), result.ToString());
        }

        [TestMethod]
        public void GetStudentsWithMost10s()
        {
            initAllData();

            int maxNumberOf10 = 0;

            foreach (var status in testCatalogue.Statuses)
            {
                int currentNumberOf10s = getNumberOf10s(status);

                if (maxNumberOf10 < currentNumberOf10s)
                    maxNumberOf10 = currentNumberOf10s;
            }

            Student[] studentsWith10s = new Student[testCatalogue.Statuses.Length];
            int index = 0;
            foreach (var status in testCatalogue.Statuses)
            {
                if (getNumberOf10s(status) == maxNumberOf10)
                    studentsWith10s[index++] = status.Student;
            }

            StringBuilder result = new StringBuilder();
            foreach (var student in studentsWith10s)
                if (student != null)
                    result.Append(student.ToString());

            Assert.AreEqual(testCatalogue.Statuses[1].Student.ToString() + testCatalogue.Statuses[2].Student.ToString(), result.ToString());
        }

        private static int getNumberOf10s(StudentStatus status)
        {
            int currentNumberOf10s = 0;
            foreach (var result in status.Results)
            {
                if (result.Grade == 10)
                    currentNumberOf10s++;
            }
            return currentNumberOf10s;
        }

        [TestMethod]
        public void GetStudentWithLowestAverage()
        {
            initAllData();

            int index = 0;
            Student[] studentsWithLowestAverage = new Student[testCatalogue.Statuses.Length];
            double lowestAverage = 10;

            foreach (var status in testCatalogue.Statuses)
            {
                double currentAverage = getAverageForStatus(status);
                if (lowestAverage > currentAverage)
                    lowestAverage = currentAverage;
            }

            foreach (var status in testCatalogue.Statuses)
            {
                if (lowestAverage == getAverageForStatus(status))
                    studentsWithLowestAverage[index++] = status.Student;
            }

            StringBuilder result = new StringBuilder();
            foreach (var student in studentsWithLowestAverage)
                if (student != null)
                    result.Append(student.ToString());

            Assert.AreEqual(testCatalogue.Statuses[0].Student.ToString(), result.ToString());
        }
    }

}
