
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaCuTrenuri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verificaredistanta()
        {
            float primatestare = Calatorie(25);
            Assert.AreEqual(12,5,primatestare);
        }
        public float Calatorie(float distanta)
        {


            return distanta / 2;
        }
    }
}