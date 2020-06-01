using System;
using Xunit;
using Xunit.Sdk;
using RomanNumeralGenerator.Service;
namespace UnitTests
{
    public class IntegerToRomanNumbersTest
    {
        [Fact]
        public void ReturnsRomanNumeralString()
        {
            RomanNumeralService romanNumeralService = new RomanNumeralService();
            // Checking if converter logic works fine, 3999 number in roman format needs to be equal "MMMCMXCIX"
            Assert.Equal("MMMCMXCIX", romanNumeralService.Generate(3999));
        }

        [Fact]
        public void GeneratorReturnsExceptionOutOfRange()
        {
            RomanNumeralService romanNumeralService = new RomanNumeralService();
            // Cheking logic that prevents from generating roman numbers for numbers that are bellow 0 and more that 3999
            // If method is trying to generate roman numbers for numbers that is out of range, it should throw a exception
            Exception expectedException = Assert.Throws<Exception>(() => romanNumeralService.Generate(4000));
            // Checking that we got the exception
            Assert.NotNull(expectedException);
            // And that it's message is correct
            Assert.Equal("Out of range", expectedException.Message);
        }
    }
}
