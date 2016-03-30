using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculation
{
    [TestClass]
    public class CapreHayConsumption
    {

        [TestMethod]
        public void KilogramsofHay()
        {

            float FirstTest = IntermediaryCalculus(2, 4, 3, 3, 4);
            Assert.AreEqual(2, FirstTest);
        }
        float IntermediaryCalculus(int xdays, int qgoats, int ygoats, int wdays, float zhay)
        {
            float numerator = xdays * zhay * wdays;
            float denominator = qgoats * ygoats ;
            float FinalHay = numerator / denominator;
            return FinalHay ;
            
        }

    }
}


