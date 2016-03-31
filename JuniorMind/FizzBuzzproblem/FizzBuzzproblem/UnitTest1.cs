using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzproblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Diviziblewith3()
        {
            Assert.AreEqual("Fizz", ComputeAndDivide(9));
        }
        [TestMethod]
        public void Divisiblewith5()
        {
            Assert.AreEqual("Buzz", ComputeAndDivide(20));
        }
        [TestMethod]
        public void Diviziblewith3and5()
        {
            Assert.AreEqual("FizzBuzz", ComputeAndDivide(15));
        }
        public string ComputeAndDivide(int number)
        {
            string result = string.Empty;
            result = ResultOfTheCalculus(number, result);
            return result;
        }

        private static string ResultOfTheCalculus(int number, string result)
        {
            if (number % 3 == 0) result = "Fizz";

            if (number % 5 == 0) result = "Buzz";

            if ((number % 3 == 0) && (number % 5 == 0)) result = "FizzBuzz";
            return result;
        }
    }

    }

