using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTwoOperationsProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConversionFirstByteTest()
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
        public void LogicalAndOperator()
        {
             CollectionAssert.AreEqual(new byte[] { 0, 0, 1 }, ValidateAnd(ToBinary(5), ToBinary(3)));
        }
        [TestMethod]
        public void LogicalXOROperator()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, ValidateXOR(ToBinary(5), ToBinary(3)));
        }
        [TestMethod]
        public void LogicalOrOperator()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1 }, ValidateOR(ToBinary(8), ToBinary(3)));
        }
        [TestMethod]
        public void RightHandShift()
        {
            CollectionAssert.AreEqual(ToBinary(8 >> 4), RightHandShift((ToBinary(8)), 4));
        }
        [TestMethod]
        public void LeftHandShift()
        {
            CollectionAssert.AreEqual(ToBinary(5 << 3), LeftHandShift((ToBinary(5)), 3));
        }
        [TestMethod]
        public void ConversionToAnyBase()
        {
            CollectionAssert.AreEqual(new byte[] { 2, 0 }, ToAnyBase(32, 16));
        }
        [TestMethod]
        public void ConversionToAnyBaseTestTwo()
        {
            CollectionAssert.AreEqual(new byte[] { 4, 0 }, ToAnyBase(32, 8));
        }
        [TestMethod]
        public void AdderTestBaseTwo()
        {
            CollectionAssert.AreEqual(ToBinary(50+3), Adder(ToBinary(50), ToBinary(3)));
        }
        [TestMethod]
        public void SubstractionBaseTwo()
        {
            CollectionAssert.AreEqual(ToBinary(50-3), Substraction(ToBinary(50), ToBinary(3)));
        }
        public byte[] ToBinary(int number)
        {
            int i = 1;
            byte[] result = new byte[0];
            while (number != 0)
            {
                Array.Resize(ref result,i);
                result[i-1] = (byte)(number % 2);
                i++;
                number /= 2;
                
            }
            
            return InverseBytes(result);
            
        }
        byte GetPosition(byte[] array, int position)
        {
            return (position > array.Length - 1 || position < 0) ? (byte)0 : array[array.Length - 1 - position];
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
        public byte[] ToCompleteBytes(byte[] bytes)
        {
            if (bytes.Length % 2 == 0)
            {
                Array.Resize(ref bytes, bytes.Length + 4 - (bytes.Length % 4));
            }
            return bytes;
        }
        public byte[] OtherLogicalOperations(byte[] firstByte, byte[] secondByte, string OperatorName)
        {
            byte[] result = new byte[Math.Max(firstByte.Length, secondByte.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                switch (OperatorName)
                {
                    case "XOR":
                        result[i] = (GetPosition(firstByte, i) != GetPosition(secondByte, i)) ? (byte)1 : (byte)0;
                        break;
                    case "AND":
                        result[i] = (GetPosition(firstByte, i) == 1 && GetPosition(secondByte, i) == 1) ? (byte)1 : (byte)0;
                        break;
                    case "OR":
                        result[i] = (GetPosition(firstByte, i) == 0 && GetPosition(secondByte, i) == 0) ? (byte)0 : (byte)1;
                        break;
                }
            }
            return InverseBytes(result);

        }
        public byte[] InverseBytes(byte[] bytesIn)
        {
            byte[] output = new byte[bytesIn.Length];
            int k = 1;
            for (int j = 0; j < bytesIn.Length; j++)
            {
                output[j] = bytesIn[bytesIn.Length - k];
                k++;
            }
            return output;
        }
        public byte[] ValidateAnd(byte[] firstByte, byte[] secondByte)
        {
            return OtherLogicalOperations(firstByte, secondByte, "AND");
        }
        public byte[] ValidateOR(byte[] firstByte, byte[] secondByte)
        {
            return OtherLogicalOperations(firstByte, secondByte, "OR");
        }
        public byte[] ValidateXOR(byte[] firstbyte, byte[] secondByte)
        {
            return OtherLogicalOperations(firstbyte, secondByte, "XOR");
        }
        public byte[] RightHandShift(byte[] bytesGiven, int numberOfShiftings)
        {
            Array.Resize(ref bytesGiven, bytesGiven.Length - numberOfShiftings);
            return bytesGiven;
        }
        public byte[] LeftHandShift(byte[] bytesGiven, int numberOfShiftings)
        {
            Array.Resize(ref bytesGiven, bytesGiven.Length + numberOfShiftings);
            return bytesGiven;
        }
        public byte[] ToAnyBase (int number , int givenBase)
        {
            byte[] bytes = new byte[0];
            int i = 1;
            while (number != 0)
            {
                Array.Resize(ref bytes, i);
                bytes[i - 1] = (byte)(number % givenBase);
                i++;
                number /= givenBase;

            }
            return InverseBytes(bytes);
        }
        public byte[] Adder(byte[] firstByte, byte[] secondByte)
        {
            byte[] result = new byte[Math.Max(firstByte.Length, secondByte.Length)];
            int remainer = 0;
            for (int i = 0; i< result.Length; i++)
            {
                int keep = GetPosition(firstByte, i) + GetPosition(secondByte, i) + remainer;
                result[result.Length - 1 - i] = (byte)(keep % 2);
                remainer = keep / 2;
            }
            if (remainer != 0)
            {
                Array.Reverse(result);
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = (byte)1;
                Array.Reverse(result);
            }
            return result;
        }
        public byte[] Substraction(byte[] firstByte,byte[] secondByte)
        {
            byte[] result = new byte[firstByte.Length];
            int remainer = 0;
            for (int i =0; i <result.Length; i++)
            {
                int keep = ( 2 + (GetPosition(firstByte, i) - GetPosition(secondByte, i) - remainer));
                result[result.Length - 1 - i] = (byte)(keep % 2);
                remainer = (keep < 2) ? (byte)1 : (byte)0;
            }
            return result ;
        }
        public byte[] Multiplier(byte[] firstByte, byte[] secondByte)
        {
            byte[] result = new byte[firstByte.Length];
            while (NotEqual(firstByte, new byte[] { 0 }))
            {
                result = Adder(result, secondByte);
                firstByte = Substraction(firstByte, new byte[] { 1 });
            }
            return result;
        }
        [TestMethod]
        public void MultiplierTest()
        {
        }
        public byte[] Division(byte[] firstByte , byte[] secondByte)
        {
            byte[] result = new byte[firstByte.Length];
            return result;
        }
        [TestMethod]
        public void LessThanTest()
        {
            Assert.IsTrue(LessThan(new byte[] {1,1,1},new byte[] { 1 }));
        }
        public bool LessThan(byte[] firstByte , byte[] secondByte)
        {
            byte result = (byte)Math.Max(firstByte.Length, secondByte.Length);
            for (int i = result -1; i>=0; i--)
                if(GetPosition(firstByte,i) != (GetPosition(secondByte, i)))
                {
                    return (((GetPosition(secondByte, i) < (GetPosition(firstByte, i)))));
                    
                }
            return false;
        }
        [TestMethod]
        public void GratherThanTest()
        {
            Assert.IsTrue(GraterThan(new byte[] { 1, 1, 1 }, new byte[] { 1 }));
        }
        public bool GraterThan(byte[] firstbyte , byte[] secondByte)
        {
            return LessThan(firstbyte, secondByte);
        }
        [TestMethod]
        public void NotEqualTest()
        {
            Assert.IsTrue(NotEqual(new byte[] { 1, 1, 1 }, new byte[] { 1 }));
            Assert.IsFalse(NotEqual(new byte[] { 1, 1, 1 }, new byte[] { 1, 1, 1 }));
        }
        public bool NotEqual(byte[] firstByte, byte[] secondByte)
         { 
            if (LessThan(secondByte, firstByte) || LessThan(firstByte, secondByte)) 
                return true; 
            return false; 
         }
        [TestMethod]
        public void EqualTest()
        {
            Assert.IsFalse(Equal(new byte[] { 1, 1, 1 }, new byte[] { 1 }));
            Assert.IsTrue(Equal(new byte[] { 1, 1, 1 }, new byte[] { 1, 1, 1 }));
        }
        public bool Equal(byte[] firstByte, byte[] secondByte)
        {
            if (!LessThan(secondByte, firstByte) && !LessThan(firstByte, secondByte))
                return true;
            return false;
        }


}

}