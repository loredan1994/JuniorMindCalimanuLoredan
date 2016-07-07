using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopingBasket
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
         
        }
        public struct ShopingBasket
        {
            public string nameOfProduct;
            public decimal priceOfProduct;
            public ShopingBasket(string nameOfProduct, decimal priceOfProduct)
            {
                this.nameOfProduct = nameOfProduct;
                this.priceOfProduct = priceOfProduct;
            }

        }

    }
}
