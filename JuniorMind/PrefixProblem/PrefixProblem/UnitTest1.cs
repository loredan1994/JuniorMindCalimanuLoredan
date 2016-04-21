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
        public string FindIfItsPrefix(string firstWord , string secondWord)
        {
            return string.Empty;
        }
    }
}
