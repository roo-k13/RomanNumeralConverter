using Library;
using System.Numerics;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMapping()
        {
            List<string> list = new() { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IV", "X" };
            foreach (string romanNumeral in list) 
            {
                BigInteger result = new RomanNumeralConverter(romanNumeral).ConvertedNumber;
                Console.WriteLine($"{romanNumeral} -> {result}");
            }
        }

        [TestMethod]
        public void TestConverter()
        {
            Assert.AreEqual(new RomanNumeralConverter("I"    ).ConvertedNumber, 1L);
            Assert.AreEqual(new RomanNumeralConverter("II"   ).ConvertedNumber, 2L);
            Assert.AreEqual(new RomanNumeralConverter("III"  ).ConvertedNumber, 3L);
            Assert.AreEqual(new RomanNumeralConverter("IV"   ).ConvertedNumber, 4L);
            Assert.AreEqual(new RomanNumeralConverter("V"    ).ConvertedNumber, 5L);
            Assert.AreEqual(new RomanNumeralConverter("VI"   ).ConvertedNumber, 6L);
            Assert.AreEqual(new RomanNumeralConverter("VII"  ).ConvertedNumber, 7L);
            Assert.AreEqual(new RomanNumeralConverter("VIII" ).ConvertedNumber, 8L);
            Assert.AreEqual(new RomanNumeralConverter("IX"   ).ConvertedNumber, 9L);
            Assert.AreEqual(new RomanNumeralConverter("X"    ).ConvertedNumber, 10L);
        }
    }
}