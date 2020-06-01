using RomanNumeralGenerator.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralGenerator.Service
{
    public class RomanNumeralService : IRomanNumeralGenerator
    {
        public RomanNumeralService() { }
        // Roman numeral dictionary, used to generate roman numerals from integer
        private static readonly Dictionary<int, string> RomanNumeralDictionary = new Dictionary<int, string>() {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        /// <summary>
        /// Method generates roman numeral from arabic numbers
        /// </summary>
        /// <param name="number">Arabic number(integer) that we want to convert to roman format</param>
        /// <returns>Roman numeral as a string</returns>
        public string Generate(int number)
        {
            StringBuilder romanNumerals = new StringBuilder();
            // Statement that prevents from generating roman numerals for integers that are below 1 and more that 3999
            if (number >= 1 && number <= 3999)
            {
                // Looping roman numeral dictionary...
                foreach (var romanSymbol in RomanNumeralDictionary)
                {
                    // looping while we wont find roman key that is equal or more than the value
                    while (number >= romanSymbol.Key)
                    {
                        // When we found needed roman symbil in dictionary, we are adding it's value to string builder
                        romanNumerals.Append(romanSymbol.Value);
                        // Subtracting roman integer value from the number that we are trying to convert 
                        number -= romanSymbol.Key;
                    }
                }
            }
            // If number does not fit in range, then we throw a exception
            else
            {
                throw new Exception("Out of range");
            }
            return romanNumerals.ToString();
        }
    }
}
