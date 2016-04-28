using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateAnagramWithSameLetters()
        {
            Assert.AreEqual(1, CalculateAnagram("aaa"));
        }
        [TestMethod]
        public void GetTheRepetitions()
        {
            Assert.AreEqual(3, GetRepetition('a', "aaaccvb"));
        }
        [TestMethod]
        public void ComputeAnagram()
        {
            Assert.AreEqual(5040, CalculateAnagram("abcdefg"));
        }
      
        public double CalculateAnagram(string theWord)
        {
            double result = 1;

            for (int i = 'a'; i <= 'z'; i++)
            {
                result *=GetFactorial(GetRepetition((char)i, theWord));
            }
            return result = GetFactorial(theWord.Length) / result;

        }


        int GetRepetition(char characterGiven, string theWord)
        {
            int wordCounter = 0;

            for (int i = 0; i < theWord.Length; i++)
            {
                if (characterGiven == theWord[i])
                    wordCounter++;
            }
            return wordCounter;
        }

        int GetFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *=i;

            }

            return result;

        }

    }

}