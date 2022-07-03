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
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(14);

            Assert.AreEqual(result, "XIV");
        }

        [TestMethod]
        public void Convert_1014_Returns_XIV()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(1014);

            Assert.AreEqual(result, "MXIV");
        }

        [TestMethod]
        public void Convert_1_Returns_I()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(1);

            Assert.AreEqual(result, "I");
        }

        [TestMethod]
        public void Convert_5_Returns_V()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(5);

            Assert.AreEqual(result, "V");
        }


        [TestMethod]
        public void Convert_10_Returns_X()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(10);

            Assert.AreEqual(result, "X");
        }

        [TestMethod]
        public void Convert_50_Returns_L()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(50);

            Assert.AreEqual(result, "L");
        }

        [TestMethod]
        public void Convert_100_Returns_C()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(100);

            Assert.AreEqual(result, "C");
        }

        [TestMethod]
        public void Convert_500_Returns_D()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(500);

            Assert.AreEqual(result, "D");
        }

        [TestMethod]
        public void Convert_1000_Returns_M()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            var result = numeralConvertor.Convert(1000);

            Assert.AreEqual(result, "M");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Negative_number_throws_exception()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            numeralConvertor.Convert(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Number_over_3999_number_Throws_exception()
        {
            var numeralConvertor = new RomanNumeralConvertor();

            numeralConvertor.Convert(4000);
        }
    }
}
