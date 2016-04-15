using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           string firsttest = IntToRoman(10);
            Assert.AreEqual("X", firsttest) ;
        }
        [TestMethod]
        public void TestMethod2()
        {
            string firsttest1 = IntToRoman(15);
            Assert.AreEqual("XV", firsttest1);
        }
        [TestMethod]
        public void secondtest()
        {
            string secondtest = IntToRoman(100);
            Assert.AreEqual("C", secondtest);
        }
        [TestMethod]
        public void thirdtest()
        {
            string secondtest = IntToRoman(1100);
            Assert.AreEqual("MC", secondtest);
        }
        public string IntToRoman(int num)
        {
            string[] thou = { "", "M", "MM", "MMM" };
            string[] hun = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string roman = "";
            roman= thou[(int)(num / 1000) % 10] + hun[(int)(num / 100) % 10] + ten[(int)(num / 10) % 10] + ones[num % 10] ;
            return roman;
            
        }
    }

}
