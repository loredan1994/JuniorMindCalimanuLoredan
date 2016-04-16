using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TensTest()
        {
           string firsttest = IntToRoman(10);
            Assert.AreEqual("X", firsttest) ;
        }
        [TestMethod]
        public void Tenstest2()
        {
            string firsttest1 = IntToRoman(15);
            Assert.AreEqual("XV", firsttest1);
        }
        [TestMethod]
        public void HundreadsTest()
        {
            string secondtest = IntToRoman(100);
            Assert.AreEqual("C", secondtest);
        }
        [TestMethod]
        public void ThousandsTest()
        {
            string secondtest = IntToRoman(1100);
            Assert.AreEqual("MC", secondtest);
        }
        [TestMethod]
        public void OnesTest()
        {
            string fourthtest = IntToRoman(8);
            Assert.AreEqual("VIII", fourthtest);
        }
        public string IntToRoman(int num)
        {
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreads = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string roman = "";
            roman= thousands[(int)(num / 1000) % 10] + hundreads[(int)(num / 100) % 10] + tens[(int)(num / 10) % 10] + ones[num % 10] ;
            return roman;
            
        }
    }

}
