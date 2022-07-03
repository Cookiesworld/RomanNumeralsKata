using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Test
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void Convert_14_Returns_XIV()
        {
            const int test = 14; 
            var result = test.ToRomanNumeral();

            Assert.AreEqual(result, "XIV");
        }

        [TestMethod]
        public void Convert_1014_Returns_XIV()
        {
            const int test = 1014;
            var result = test.ToRomanNumeral();
            Assert.AreEqual(result, "MXIV");
        }

        [TestMethod]
        public void Convert_1_Returns_I()
        {
            const int test = 1;
            var result = test.ToRomanNumeral();            
            Assert.AreEqual(result, "I");
        }

        [TestMethod]
        public void Convert_5_Returns_V()
        {
            const int test = 5;
            var result = test.ToRomanNumeral();

            Assert.AreEqual(result, "V");
        }


        [TestMethod]
        public void Convert_10_Returns_X()
        {
            const int test = 10;
            var result = test.ToRomanNumeral();

            Assert.AreEqual(result, "X");
        }

        [TestMethod]
        public void Convert_50_Returns_L()
        {
            const int test = 50;
            var result = test.ToRomanNumeral();

            Assert.AreEqual(result, "L");
        }

        [TestMethod]
        public void Convert_100_Returns_C()
        {
            const int test = 100;
            var result = test.ToRomanNumeral();            
            Assert.AreEqual(result, "C");
        }

        [TestMethod]
        public void Convert_500_Returns_D()
        {
            const int test = 500;
            var result = test.ToRomanNumeral();
            Assert.AreEqual(result, "D");
        }

        [TestMethod]
        public void Convert_1000_Returns_M()
        {
            const int test = 1000;
            var result = test.ToRomanNumeral();

            Assert.AreEqual(result, "M");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Negative_number_throws_exception()
        {
            const int test = -1;
            var result = test.ToRomanNumeral();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Number_over_3999_number_Throws_exception()
        {
            const int test = 4000;
            var result = test.ToRomanNumeral();
        }
    }
}
