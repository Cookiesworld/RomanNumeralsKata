using System;
using Xunit;

namespace RomanNumerals.Test
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("XIV", 14)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("CDXCIX", 499)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        [InlineData("MXIV", 1014)]

        public void Valid_Scenarios_Are_Converted_To_Numerals(string expected, int test)
        {
            var result = test.ToRomanNumeral();

            Assert.Equal(expected, result);
        }       
        
        [Fact]
        public void Negative_number_throws_exception()
        {
            const int test = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => test.ToRomanNumeral());
        }

        [Fact]
        public void Number_over_3999_number_Throws_exception()
        {
            const int test = 4000;
            Assert.Throws<ArgumentOutOfRangeException>(() => test.ToRomanNumeral());
        }
    }
}
