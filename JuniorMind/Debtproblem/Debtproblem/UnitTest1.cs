using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debtproblem
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(68, CalculateSumOfDebt(60, 40));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(93, CalculateSumOfDebt(90, 20));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(100.48, CalculateSumOfDebt(100, 8));
        }
        [TestMethod]
        public void TestWhenNoDelay()
        {
            Assert.AreEqual(100, CalculateSumOfDebt(100, 0));
        }
        public double CalculateSumOfDebt(int rental, int daysToPay)
        {
            double[] pricesProcentage = { 0, 0.02, 0.05, 0.1 };
            double payDay = rental / 30;
            double pricePerDelay = GetPricePerDelay(daysToPay, pricesProcentage,payDay);
           
            return rental + pricePerDelay;


        }
        private double[] pricesProcentage(int daysToPay)
        {
            double[] pricesProcentageDelays = { 0, 0.02 , 0.05, 0.1 };
            return pricesProcentageDelays;
        }

        private double GetPricePerDelay(int daysToPay, double[] pricesProcentage, double payDay)
        {
            
            if (priceForShortDelays(daysToPay))
                return daysToPay*payDay * pricesProcentage[1];
            if (priceForMiddleDelays(daysToPay))
                return daysToPay* payDay *pricesProcentage[2];
            if(priceForLongDelays(daysToPay))
            return daysToPay * payDay * pricesProcentage[3];
            return daysToPay * payDay * pricesProcentage[0];


        }
      

        private bool priceForShortDelays(int daysToPay)
        {
            return(daysToPay >= 1 && daysToPay <= 10);
        }
        private bool priceForMiddleDelays(int daysToPay)
        {
            return (daysToPay >= 11) && (daysToPay <= 30);

        }
        private bool priceForLongDelays(int daysToPay)
        {
            return (daysToPay >= 40);
        }

    }
}
