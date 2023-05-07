using System.Text.RegularExpressions;

namespace Library
{
    public static partial class RomanNumeralConverter
    {
        private static readonly Dictionary<string, int> _romanToNumberDictionary;

        static RomanNumeralConverter()
        {
            _romanToNumberDictionary = new Dictionary<string, int>
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
        }
        
        /// <summary>
        /// Converts a string with roman numerals to int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Convert(string input)
        {
            if (!RomanNumeralStringRegex().IsMatch(input))
                throw new ArgumentException($"The string provided is not valid: '{input}'");

            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentRoman = input[i].ToString();

                if (i < input.Length - 1)
                {
                    if (input[i].ToString() == "I" && input[i + 1].ToString() == "V")
                    {
                        _romanToNumberDictionary.TryGetValue("IV", out result);
                        i++;
                        break;
                    }
                }

                else
                {
                    foreach (string numeral in _romanToNumberDictionary.Keys)
                    {
                        if (currentRoman == numeral)
                        {
                            result += _romanToNumberDictionary[numeral];
                            break;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Converts an int to a string of roman numerals
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string Convert(int input)
        {
            throw new InvalidOperationException();
        }

        [GeneratedRegex("^(?=[MDCLXVI])M*(C[MD]|D?C*)(X[CL]|L?X*)(I[XV]|V?I*)$")]
        private static partial Regex RomanNumeralStringRegex();
    }
}
