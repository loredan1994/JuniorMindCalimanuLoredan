using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class RedMushroomss
    {
        [TestMethod]
        public void MushroomsTest()
        {
            int Firsttest = RedMushrooms(1,10) ;
            Assert.AreEqual(5, Firsttest);
        }
        int RedMushrooms(int multiplicity, int totalnumberofmushrooms)
        {
            int whitemushrooms = totalnumberofmushrooms / (multiplicity + 1) ;
            int redmushrooms = whitemushrooms * multiplicity;
            return redmushrooms ;
        }

    }
}
