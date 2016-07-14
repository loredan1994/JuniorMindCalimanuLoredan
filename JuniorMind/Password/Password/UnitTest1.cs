﻿using System;
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
        static Random password = new Random();
        public string PasswordGenerator(Password password)
        {
            return string.Empty;
        }
        public char GenerateCharacter( char minValue, char maxValue)
        {
            return (char)password.Next(minValue, maxValue);
        }
        public char GenerateSymbol ()
        {
            string symbol = "!@#$%^&*()-+=[]';:'><.?/";
            int random = password.Next(0, symbol.Length - 1);
            return symbol[random];
        }
    }
}
