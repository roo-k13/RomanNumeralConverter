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
            
            for (int i = 0; i < list.Count; i++)
            {
                string result = RomanNumeralConverter.Convert(i);
                Assert.AreEqual(result, list[i]);
            }
        }

        [TestMethod]
        public void TestConverter()
        {
            Assert.AreEqual(RomanNumeralConverter.Convert("I"   ), 1);
            Assert.AreEqual(RomanNumeralConverter.Convert("II"  ), 2);
            Assert.AreEqual(RomanNumeralConverter.Convert("III" ), 3);
            Assert.AreEqual(RomanNumeralConverter.Convert("IV"  ), 4);
            Assert.AreEqual(RomanNumeralConverter.Convert("V"   ), 5);
            Assert.AreEqual(RomanNumeralConverter.Convert("VI"  ), 6);
            Assert.AreEqual(RomanNumeralConverter.Convert("VII" ), 7);
            Assert.AreEqual(RomanNumeralConverter.Convert("VIII"), 8);
            Assert.AreEqual(RomanNumeralConverter.Convert("IV"  ), 9);
            Assert.AreEqual(RomanNumeralConverter.Convert("X"   ), 10);
        }
    }
}