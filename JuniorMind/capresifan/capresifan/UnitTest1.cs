using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculation
{
    [TestClass]
    public class CapreHayConsumption
    {

        [TestMethod]
        public void Kilogramedefan()
        {

            float primatestare = Calculintermediar(2, 4, 3, 3, 4);
            Assert.AreEqual(2, primatestare);
        }
        float Calculintermediar(int x, int q, int y, int w, float z)
        {
            float numarator = x * z * w;
            float numitor = q * y ;
            float finalfan = numarator / numitor;
            return finalfan ;
            
        }

    }
}


