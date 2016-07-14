using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public struct Password
        {
            public int passwordLength;
            public int noUpperCaseLetters;
            public int noLowerCaseLetters;
            public int noOfNumbers;
            public int noOfSymbols;
            public bool withoutSimilarities;
            public bool withoutAmbiguities;


            public Password(int passwordLength, int noUpperCaseLetters, int noLowerCaseLetters, int noOfNumbers, int noOfSymbols, bool withoutSimilarities, bool withoutAmbiguities)
            {
                this.passwordLength = passwordLength;
                this.noUpperCaseLetters = noUpperCaseLetters;
                this.noLowerCaseLetters = noLowerCaseLetters;
                this.noOfNumbers = noOfNumbers;
                this.noOfSymbols = noOfSymbols;
                this.withoutSimilarities = withoutSimilarities;
                this.withoutAmbiguities = withoutAmbiguities;

            }
        }
    }
}

