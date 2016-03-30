using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Plaquetteproblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, findPlaquette(6, 6, 4));
        }
        [TestMethod]
        public void PlaquetteSecondTest()
        {
            Assert.AreEqual(16, findPlaquette(8, 8, 2));
        }
        public double findPlaquette(int mlength, int nlength, int acubic)
        {

            double longitudelength = (double)mlength / acubic;
            double  latitudelength = (double)nlength / acubic;
            int cubicPlaquetteneeded = (int)(Math.Ceiling(longitudelength) * (Math.Ceiling(latitudelength)));

            return cubicPlaquetteneeded;
        }

    }


}