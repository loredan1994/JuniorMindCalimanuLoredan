using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindPrefix()
        {
            Assert.AreEqual("abab", FindIfItsPrefix("ababc", "ababd"));
        }
        [TestMethod]
        public void FindPrefixTest()
        {
            Assert.AreEqual("a", FindIfItsPrefix("a", "ababd"));
        }
        [TestMethod]
        public void FindIfPrefix()
        {
            Assert.AreEqual("do", FindIfItsPrefix("dodoson", "dooson"));
        }
        [TestMethod]
        public void FindIfNoPrefix()
        {
            Assert.AreEqual("", FindIfItsPrefix("lol", "dota"));
        }
        public string FindIfItsPrefix(string firstWord, string secondWord)
        {
            string prefix = string.Empty;
            for (int i=0 ; i < firstWord.Length && i < secondWord.Length ; i++)
            {
                if (firstWord[i] != secondWord[i]) break;
                   prefix += firstWord[i] ;
                
            }
            return prefix;
             
        }
    }
}
