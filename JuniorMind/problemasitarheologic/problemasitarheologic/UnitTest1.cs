using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArheologicalSite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Method1()
        {
            double FirstTest = Heronminimum(6, 2, 8, 2, 9, 2);
            Assert.AreEqual(7, FirstTest);
        }
        double Heronminimum(double xa, double xb, double xc, double ya, double yb, double yc)

        {
            double ab = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
            double ac = Math.Sqrt(Math.Pow((xc - xa),2) + Math.Pow((yc - ya),2));
            double bc = Math.Sqrt(Math.Pow((xc - xb),2) + Math.Pow((yc - yb),2));
            double p = (ab + ac + bc) / 2;
            double HeronSurface = Math.Sqrt((p * ((p - ab) * (p - ac) * (p - bc))));
            return HeronSurface;
           

        }
     
    }
}

