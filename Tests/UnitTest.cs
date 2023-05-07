using Library;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {

        Dictionary<string, int> romanToNumberDictionary = new()
        {
            {"I",  1    },
            {"IV", 4    },
            {"V",  5    },
            {"IX", 9    },
            {"X",  10   },
            {"XL", 40   },
            {"L",  50   },
            {"XC", 90   },
            {"C",  100  },
            {"CD", 400  },
            {"D",  500  },
            {"CM", 900  },
            {"M",  1000 }
        };

        [TestMethod]
        public void RomanToNumberDictionaryTest()
        {


            Assert.AreEqual(1    , romanToNumberDictionary["I" ]);
            Assert.AreEqual(4    , romanToNumberDictionary["IV"]);
            Assert.AreEqual(5    , romanToNumberDictionary["V" ]);
            Assert.AreEqual(9    , romanToNumberDictionary["IX"]);
            Assert.AreEqual(10   , romanToNumberDictionary["X" ]);
            Assert.AreEqual(40   , romanToNumberDictionary["XL"]);
            Assert.AreEqual(50   , romanToNumberDictionary["L" ]);
            Assert.AreEqual(90   , romanToNumberDictionary["XC"]);
            Assert.AreEqual(100  , romanToNumberDictionary["C" ]);
            Assert.AreEqual(400  , romanToNumberDictionary["CD"]);
            Assert.AreEqual(500  , romanToNumberDictionary["D" ]);
            Assert.AreEqual(900  , romanToNumberDictionary["CM"]);
            Assert.AreEqual(1000 , romanToNumberDictionary["M" ]);
        }

        [TestMethod]
        public void TestRomanToNumberConverter()
        {

            foreach (KeyValuePair<string, int> testCase in romanToNumberDictionary)
            {
                int result = RomanNumeralConverter.Convert(testCase.Key);
                int expected = testCase.Value;
                Assert.AreEqual(expected, result, $"Failed for input: {testCase.Key}");
            }
        }

        [TestMethod]
        public void TestNumberToRomanConverter() 
        {
            throw new InvalidOperationException();
        }
    }
}