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
            decimal primatestare = Arieminima(3, 1, 3, 1, 3, 1);
            Assert.AreEqual(18.000002, primatestare);
        }
        decimal Arieminima(int xa, int xb, int xc, int ya, int yb, int yc)

        {
            decimal ab = ((xb - xa) ^ 2 + (yb - ya) ^ 2) ^ 1 / 2;
            decimal ac = ((xc - xa) ^ 2 + (yc - ya) ^ 2) ^ 1 / 2;
            decimal bc = ((xc - xb) ^ 2 + (yc - yb) ^ 2) ^ 1 / 2;
            decimal p = (ab + ac + bc) / 2;
            decimal ArieHeronpartial = (p * ((p - ab) * (p - ac) * (p - bc)));
            decimal ArieHeron = ((ArieHeronpartial))^1/2;
            return ArieHeron;

        }
     
    }
}

