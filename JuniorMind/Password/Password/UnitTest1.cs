using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassword()
        {
            Password password = new Password(40, 12, 5, 3, 20, true, false);
            Password passwordtest = new Password(40, 12, 5, 3, 20, false, false);
            string Password = PasswordGenerator(password);
            string Passwordtest = PasswordGenerator(passwordtest);
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
            var excludeSimilarities = password.withoutSimilarities ? "l1Io0O" : string.Empty;
            var excludeAmbiguities = password.withoutAmbiguities ? " {}[]()/\'~,;.<> " : string.Empty;
            var Password = StringSimilarities(password.noLowerCaseLetters, 'a', 'z', excludeSimilarities) + StringSimilarities(password.noUpperCaseLetters, 'A', 'Z', excludeSimilarities) + StringSimilarities(password.noOfNumbers, '0', '9', excludeSimilarities) + GennerateSymbolPassword(password.noOfSymbols, excludeAmbiguities);
            return Password;
        }
        public char GenerateCharacter( char minValue, char maxValue)
        {
            return (char)password.Next(minValue, maxValue+1);
        }
        public char GenerateSymbol ()
        {
            string symbol = "!@#$%^&*()-+=[]';:'><.?/";
            int random = password.Next(0, symbol.Length - 1);
            return symbol[random];
        }
        public string GennerateSymbolPassword(int noOfSymbols , string without = "()/\'~,;.<>{}[] ")
        {
            string symbols = string.Empty;
            int count = 0;
            while (noOfSymbols > count)
            {
                char random = GenerateSymbol();
                var excludeAmbiguities = without.Contains(random.ToString());
                if (!excludeAmbiguities)
                {
                    symbols += random;
                    count++;
                }
            }
            return symbols;
        }
        public string StringSimilarities(int noOfChar , char first , char last , string without = "l1Io0O")
        {
            string chars = string.Empty;
            int count = 0;
            while (noOfChar > count)
            {
                char random = GenerateCharacter(first, last);
                var excludeSimilarities = without.Contains(random.ToString());
                if (!excludeSimilarities)
                {
                    chars += random;
                    count++;
                }

            }
            return chars;
        }
        public int CharCounter(string chars, char first, char last) {
            
                int counter = 0;
                foreach (char c in chars)
                    if (first <= c && c <= last)
                        counter++;
            
            return counter;
        }
        public int SymbolCounter ( string symbols)
        {
            int noOfSymbols = 0;
            int counter = 0;
            string pass = GennerateSymbolPassword(noOfSymbols, "()/\'~,;.<>{}[]");
            foreach (char c in symbols)
                counter++;
            return counter;
        }
   }
}

