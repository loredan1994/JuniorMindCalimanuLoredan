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
            double[] GetPricesProcentage = { 0, 0.02, 0.05, 0.1 };
            double payDay = rental / 30;
            double pricePerDelay = GetPricePerDelay(daysToPay, GetPricesProcentage,payDay);
           
            return rental + pricePerDelay;


        }
        private double[] GetPricesProcentage(int daysToPay)
        {
            double[] GetPricesProcentageDelays = { 0, 0.02 , 0.05, 0.1 };
            return GetPricesProcentageDelays;
        }

        private double GetPricePerDelay(int daysToPay, double[] GetPricesProcentage, double payDay)
        {
            
            if (GetPriceForShortDelays(daysToPay))
                return daysToPay*payDay * GetPricesProcentage[1];
            if (GetPriceForMiddleDelays(daysToPay))
                return daysToPay* payDay *GetPricesProcentage[2];
            if(GetPriceForLongDelays(daysToPay))
            return daysToPay * payDay * GetPricesProcentage[3];
            return daysToPay * payDay * GetPricesProcentage[0];


        }
      

        private bool GetPriceForShortDelays(int daysToPay)
        {
            return(daysToPay >= 1 && daysToPay <= 10);
        }
        private bool GetPriceForMiddleDelays(int daysToPay)
        {
            return (daysToPay >= 11) && (daysToPay <= 30);

        }
        private bool GetPriceForLongDelays(int daysToPay)
        {
            return (daysToPay >= 40);
        }

    }
}
