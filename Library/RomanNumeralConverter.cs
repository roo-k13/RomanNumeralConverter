using System.Text.RegularExpressions;

namespace Library
{
    public class RomanNumeralConverter
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

        internal static int Convert(string input)
        {
            Regex regex = new("^(?=[MDCLXVI])M*(C[MD]|D?C*)(X[CL]|L?X*)(I[XV]|V?I*)$");

            if (!regex.IsMatch(input))
                throw new ArgumentException($"The string provided is not valid: '{input}'");

            int result = 0;

            foreach (char character in input)
                foreach (char numeral in _romanToNumberDictionary.Keys)
                    if (character == numeral)
                        result += _romanToNumberDictionary[numeral];

            return result;
        }

        internal string Convert(int input)
        {
            throw new InvalidOperationException();
        }
    }
}
