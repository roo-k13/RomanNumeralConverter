using System.Text.RegularExpressions;

namespace Library
{
    public static partial class RomanNumeralConverter
    {
        private static readonly Dictionary<char, int> _romanToNumberDictionary;
        private static readonly Dictionary<int, char> _numberToRomanDictionary;

        static RomanNumeralConverter()
        {
            _romanToNumberDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            _numberToRomanDictionary = new Dictionary<int, char>
            {
                { 1 , 'I'},
                { 5 , 'V'},
                { 10, 'X'},
                { 50, 'L'},
                { 100, 'C'},
                { 500, 'D'},
                { 1000, 'M'}
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
            if (RomanNumeralStringRegex().IsMatch(input))
                throw new ArgumentException($"The string provided is not valid: '{input}'");

            int result = 0;

            foreach (char character in input)
                foreach (char numeral in _romanToNumberDictionary.Keys)
                    if (character == numeral)
                        result += _romanToNumberDictionary[numeral];

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
