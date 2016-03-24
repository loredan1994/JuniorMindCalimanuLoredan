using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ciupercilealbe
{
    [TestClass]
    public class CiupercileRosii
    {
        [TestMethod]
        public void CiuperciTest()
        {
            int primatestare = CiupercileRosi(4,8) ;
            Assert.AreEqual(32, primatestare);
        }
        int CiupercileRosi(int multiplicitatea, int numarciupercialbe)
        {
            int numarciupercirosii = multiplicitatea * numarciupercialbe ;
            return numarciupercirosii;
        }

    }
}
