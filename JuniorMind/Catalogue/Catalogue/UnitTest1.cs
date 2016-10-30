using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalogue
{
    [TestClass]
    public class UnitTest1 : Grades
    {
        [TestMethod]
        public void TestName()
        {
            CollectionAssert.AreEqual(new string[] { "a", "b", "c", "d" }, SortAlphabetically(new string[] { "c", "b", "d", "a" }));
        }
        [TestMethod]
        public void TestAverage()
        {
            
        }
        [TestMethod]
        public void AverageSearch()
        {

        }
        [TestMethod]
        public void SearchMost10()
        {

        }
        [TestMethod]
        public void SearchSmallestAverage()
        {

        }
    }

}
