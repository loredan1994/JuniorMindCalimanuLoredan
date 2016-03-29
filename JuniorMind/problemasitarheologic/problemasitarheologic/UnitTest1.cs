using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace problemasitarheologic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Metoda1()
        {
            double primatestare = Arieminima(3, 1, 3, 1, 3, 1);
            Assert.AreEqual(18.000002, primatestare);
        }
        double Arieminima(int xa, int xb, int xc, int ya, int yb, int yc)

        {
            int ab = ((xb - xa) ^ 2 + (yb - ya) ^ 2) ^ 1 / 2;
            int ac = ((xc - xa) ^ 2 + (yc - ya) ^ 2) ^ 1 / 2;
            int bc = ((xc - xb) ^ 2 + (yc - yb) ^ 2) ^ 1 / 2;
            int p = (ab + ac + bc) / 2;
            double ArieHeronpartial = Math.Sqrt((p * ((p - ab) * (p - ac) * (p - bc))));
            return ArieHeronpartial;
           

        }
     
    }
}

