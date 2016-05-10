using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoOperationsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0 }, ToBinary(2));
        }
        [TestMethod]
        public void ConversionSecondTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, ToBinary(3));
        }
        [TestMethod]
        public void ConversionBigNumber()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 1, 1 }, ToBinary(63));
        }
        [TestMethod]
        public void ConversionWithZeroAndOneMixed()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 0, 0, 0, 1, 1, 1 }, ToBinary(583));
        }
        [TestMethod]
        public void TestTheGetPosition()
        {
            Assert.AreEqual(0, GetPosition(1, new byte[] { 1, 0, 3 }));
        }
        [TestMethod]
        public void TestGetPositionNew()
        {
            Assert.AreEqual(2, GetPosition(8, new byte[] { 1, 2, 3, 4, 6, 8, 7, 5, 9, 10 }));
        }
        [TestMethod]
        public void TestForAnd()
        {
            CollectionAssert.AreEqual(new byte[] { 0 }, ValidateAnd(ToBinary(1), ToBinary(2)));
            

        }
        [TestMethod]
        public void TestForAndNew()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, ValidateAnd(ToBinary(7), ToBinary(2)));
        }
        [TestMethod]
        public void TestForNotOperator ()
        {
            CollectionAssert.AreEqual(new byte [] {1}, ValidateNot(new byte[]{0}));
        }
        [TestMethod]
        public void TestForNotOpertion()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, ValidateNot(new byte[] { 0, 0 }));
        }
        [TestMethod]
        public void TestForNotOp()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, ValidateNot(new byte[] { 1, 0 }));
        }
        [TestMethod]
        public void TestForOrOperation()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1 }, ValidateOR(new byte[] {0 , 0 , 0, 1 }, new byte[] { 1, 1, 1, 0 }));
        }
        [TestMethod]
        public void TestForOrOperand()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ValidateOR(new byte[] { 0, 1, 0 }, new byte[] { 1, 0, 1 }));
        }
        [TestMethod]
        public void TestForXOROperator()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0 }, ValidateXOR(new byte[] { 1, 1, 1 }, new byte[] { 1, 1, 1 }));
        }
        [TestMethod]
        public void TestForXOROperand()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1 }, ValidateXOR(new byte[] { 1, 1, 1 }, new byte[] { 0 , 1, 1 }));
        }
        public byte[] ToBinary(int number)
        {
            int rest = 0;
            byte[] result = new byte[0];
            while (number != 0)
            {
                rest = number % 2;
                number /= 2;
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = (byte)rest;
                
            }
            Array.Reverse(result);
            return result;
        }
        byte GetPosition(int position, byte[] array)
        {
            if (position >= array.Length)
                return 0;
            return array[array.Length - 1 - position];
        }
        byte[] ValidateAnd(byte[] firstByte, byte[] secondByte)
        {
            byte[] result = new byte[firstByte.Length];

            for (int i = 0; i < firstByte.Length; i++)
            {

                if (GetPosition(i, firstByte) == 1 && GetPosition(i, secondByte) == 1)

                    result[i] = 1;
                else  result[i] = 0;


            }
            return result;
        }
        byte[] ValidateNot(byte[] firstByte)
        {
            for (int i=0; i < firstByte.Length; i++)
            {
                if(firstByte[i] == 1) firstByte[i] -= 1;
                else
                if (firstByte[i] == 0) firstByte[i] += 1;
             }
            return firstByte;
        }
        byte[] ValidateOR(byte[] firstByte, byte[] secondByte)
        {
            byte[] result = new byte[firstByte.Length];

            for (int i = 0; i < firstByte.Length; i++)
            {

                if (GetPosition(i, firstByte) == 0 && GetPosition(i, secondByte) == 0)

                    result[i] = 0;
                else result[i] = 1;


            }
            return result;
        }
        byte[] ValidateXOR(byte[] firstByte , byte[] secondByte)
        {
            byte[] result = new byte[firstByte.Length];
            for (int i=0; i<firstByte.Length; i++)
            {
                if (GetPosition(i, firstByte) == 0 && GetPosition(i, secondByte) == 0 || GetPosition(i, firstByte) == 1 && GetPosition(i, secondByte) == 1)
                    result[i] = 0;
                else
                    result[i] = 1;
            }
            return result;
        }
    }
}