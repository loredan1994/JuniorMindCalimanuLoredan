using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculation
{
    [TestClass]
    public class CapreHayConsumption {

        [TestMethod]
        public void Kilogramedefan()
        {

            float primatestare = Calculintermediar(20, 2, 4, 5, 8);
            Assert.AreEqual(1 , primatestare ) ; 
        }
        float Calculintermediar(float x, float q, float y, float w, float z)
        {
            float numardezile = x / q;
            float numardecapre = y / w;
            float calculintermediar = numardezile * numardecapre;
            return calculintermediar / z;
        }

    }
}


