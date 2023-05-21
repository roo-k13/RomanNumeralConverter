using Library;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {

        private readonly Dictionary<string, int> _romanToNumberDictionary = new()
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


            Assert.AreEqual(1    , _romanToNumberDictionary["I" ]);
            Assert.AreEqual(4    , _romanToNumberDictionary["IV"]);
            Assert.AreEqual(5    , _romanToNumberDictionary["V" ]);
            Assert.AreEqual(9    , _romanToNumberDictionary["IX"]);
            Assert.AreEqual(10   , _romanToNumberDictionary["X" ]);
            Assert.AreEqual(40   , _romanToNumberDictionary["XL"]);
            Assert.AreEqual(50   , _romanToNumberDictionary["L" ]);
            Assert.AreEqual(90   , _romanToNumberDictionary["XC"]);
            Assert.AreEqual(100  , _romanToNumberDictionary["C" ]);
            Assert.AreEqual(400  , _romanToNumberDictionary["CD"]);
            Assert.AreEqual(500  , _romanToNumberDictionary["D" ]);
            Assert.AreEqual(900  , _romanToNumberDictionary["CM"]);
            Assert.AreEqual(1000 , _romanToNumberDictionary["M" ]);
        }

        [TestMethod]
        public void TestRomanToNumberConverter()
        {
            //TODO: START CHECKING FOR NUMBERS THAT ARE NOT ON THE LIST

            foreach (KeyValuePair<string, int> testCase in _romanToNumberDictionary)
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