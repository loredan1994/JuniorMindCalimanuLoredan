using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] number = new int[] { 12, 15, 2, 5, 7, 9 };
            CollectionAssert.AreEqual(new int[] { 2, 5, 7, 9, 12, 15 }, Sort(number));
        }
        public static int[] Sort(int[] number)
        {
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (number[j - 1] > number[j])
                        Swap(ref number[j - 1], ref number[j]);
                }
            }
            return number;

        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
