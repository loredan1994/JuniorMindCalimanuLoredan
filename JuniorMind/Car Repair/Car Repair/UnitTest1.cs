using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Repair
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest()
        {
            PriorityLevel[] level = new PriorityLevel[] { PriorityLevel.High, PriorityLevel.Low, PriorityLevel.Medium};
            var expected = new Cars[] { new Cars(PriorityLevel.High, 3), new Cars(PriorityLevel.Medium, 2), new Cars(PriorityLevel.Low, 1) };
            CollectionAssert.AreEqual(expected, SortCars(level));

        }
     
        public Cars[] SortCars(PriorityLevel[] priorities)
        {
            CarTech carTech = new CarTech();
            for (int i = 0; i< priorities.Length; i++)
            {
                carTech.AddNumber();
                carTech.Sort(priorities[i]);
            }
            Cars[] cars = new Cars[priorities.Length];
            for (int i = 0; i< cars.Length;i++)
                cars[i] = carTech.GetNext();
            return cars;
        }
    }
}
