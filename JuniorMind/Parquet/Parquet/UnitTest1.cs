using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet
{
    [TestClass]
    public class ParquetTest
    {
        [TestMethod]
        public void Numberofpieces()
        {
            double FirstTest = ParquetComputation(120, 15);
            Assert.AreEqual(9.2, FirstTest);
        }
       public double ParquetComputation(double NxMroom, double AxBplate)
        {
            return 1.15 * NxMroom / AxBplate ;

        }
    }
}
