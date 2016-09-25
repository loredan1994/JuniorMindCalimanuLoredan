using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingWords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var words = new string[] { "lore", "vasile", "este", "numai", "lore", "lore", "este" };
            var expected = new WordSorting[] { new WordSorting("lore", 3), new WordSorting("este", 2), new WordSorting("vasile", 1),new WordSorting("numai",1) };
            CollectionAssert.AreEqual(expected, Sorted(words));
        }
        public WordSorting[] Sorted(string[] text)
        {
            Admin admin = new Admin();

            for (int i = 0; i < text.Length; i++)
                admin.Sort(text[i]);

            WordSorting[] words = new WordSorting[admin.GetNumber()];
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = admin.GetWord();
            }
            return words;
        }
    }
}
