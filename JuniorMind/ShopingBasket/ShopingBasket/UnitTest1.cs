using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopingBasket
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestTotalPrice()
        {
            var shopingproducts = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 8 ), new ShopingBasket("LaysChips", 5), new ShopingBasket("CoCaCola", 6) };
            Assert.AreEqual(19, TotalPrice(shopingproducts));
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
        public decimal TotalPrice(ShopingBasket[] shopingBasket)
        {
            decimal totalPrice = 0;
            for (int i = 0; i < shopingBasket.Length; i++)
                totalPrice += shopingBasket[i].priceOfProduct;
            return totalPrice;
        }
        public decimal AverageProducts(ShopingBasket[] shopingBasket)
        {
            int numberofProducts = shopingBasket.Length;
            return TotalPrice(shopingBasket) / numberofProducts;
        }
        [TestMethod]
        public void TestAverage()
        {
            var shopingproducts = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 6), new ShopingBasket("LaysChips", 7), new ShopingBasket("CoCaCola", 8) };
            Assert.AreEqual(7, AverageProducts(shopingproducts));
            var shopingproduct = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 9), new ShopingBasket("LaysChips", 10), new ShopingBasket("CoCaCola", 11) };
            Assert.AreEqual(10, AverageProducts(shopingproduct));
        }
        public string CheapestProduct(ShopingBasket[] shopingBasket)
        {
            ShopingBasket chepestProduct = shopingBasket[0];
            int position = 0;
            for (int i = 1; i < shopingBasket.Length; i++)
                if (shopingBasket[i].priceOfProduct < chepestProduct.priceOfProduct)
                {
                    chepestProduct = shopingBasket[i];
                    position = i;
                }
            return shopingBasket[position].nameOfProduct;
        }
        [TestMethod]
        public void TestCheapestProduct()
        {
            var shopingproducts = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 6), new ShopingBasket("LaysChips", 7), new ShopingBasket("CoCaCola", 8) };
            Assert.AreEqual("EnergyDrink", CheapestProduct(shopingproducts));
        }

        private int MostExpensiveProduct(ShopingBasket[] shopingBasket)
        {
            decimal mostExpensive = 0;
            int position = 0;
            for (int i = 0; i < shopingBasket.Length; i++)
                if (shopingBasket[i].priceOfProduct > mostExpensive)
                {
                   mostExpensive = shopingBasket[i].priceOfProduct;
                    position = i;
                }
            return position;
        }
        [TestMethod]
        public void TestMostExpensive()
        {
            var shopingproducts = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 6), new ShopingBasket("LaysChips", 7), new ShopingBasket("CoCaCola", 8) };
            Assert.AreEqual(2, MostExpensiveProduct(shopingproducts));
        }
        public string HightestProduct(ShopingBasket[] shopingBasket)
        {
            ShopingBasket chepestProduct = shopingBasket[0];
            int position = 0;
            for (int i = 1; i < shopingBasket.Length; i++)
                if (shopingBasket[i].priceOfProduct > chepestProduct.priceOfProduct)
                {
                    chepestProduct = shopingBasket[i];
                    position = i;
                }
            return shopingBasket[position].nameOfProduct;
        }
        [TestMethod]
        public void TestHighestProduct()
        {
            var shopingproducts = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 6), new ShopingBasket("LaysChips", 7), new ShopingBasket("CoCaCola", 8) };
            Assert.AreEqual("CoCaCola", HightestProduct(shopingproducts));
        }
        public ShopingBasket[] AddNewProduct(ShopingBasket[] shopingBasket, ShopingBasket addProduct)
        {
            Array.Resize(ref shopingBasket, shopingBasket.Length + 1);
            shopingBasket[shopingBasket.Length - 1] = addProduct;
            return shopingBasket;
        }
        [TestMethod]
        public void TestAddNewProduct()
        {
            var shopingBasket = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 6)};
            var shopingBasketExpected = new ShopingBasket[] { new ShopingBasket("EnergyDrink", 6), new ShopingBasket("Lays", 6)};
            CollectionAssert.AreEqual(shopingBasketExpected, AddNewProduct(shopingBasket, shopingBasketExpected[shopingBasketExpected.Length - 1]));
        }
    }
}
