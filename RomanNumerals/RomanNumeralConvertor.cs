namespace RomanNumerals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public static class RomanNumeralConvertor 
    {
        /// <summary>
        /// Convert number
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Roman Numeral String</returns>
        public static string ToRomanNumeral(this int number)
        {
            return ToRoman(number);
        }

        /// <summary>
        /// Roman Numeral converter
        /// </summary>
        /// <remarks>Thanks to http://social.msdn.microsoft.com/Forums/vstudio/en-US/70eaf2c8-52d2-426f-91cb-22325509a4f7/how-to-convert-a-number-into-roman-numeral-in-visual-c?forum=csharpgeneral" for the solution</remarks>
        /// <param name="number">Number to convert</param>
        /// <returns>String representing roman numeral</returns>
        private static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) 
            { 
                throw new ArgumentOutOfRangeException("Value must be between 1 and 3999"); 
            }

            if (number < 1)
            {
                return string.Empty;
            }

            if (number >= 1000)
            { 
                return "M" + ToRoman(number - 1000); 
            }

            if (number >= 900)
            {
                return "CM" + ToRoman(number - 900);
            }

            if (number >= 500)
            {
                return "D" + ToRoman(number - 500);
            }

            if (number >= 400)
            {
                return "CD" + ToRoman(number - 400);
            }

            if (number >= 100)
            {
                return "C" + ToRoman(number - 100);
            }

            if (number >= 90)
            {
                return "XC" + ToRoman(number - 90);
            }

            if (number >= 50)
            {
                return "L" + ToRoman(number - 50);
            }

            if (number >= 40)
            {
                return "XL" + ToRoman(number - 40);
            }

            if (number >= 10)
            {
                return "X" + ToRoman(number - 10);
            }

            if (number >= 9)
            {
                return "IX" + ToRoman(number - 9);
            }

            if (number >= 5)
            {
                return "V" + ToRoman(number - 5);
            }

            if (number >= 4)
            {
                return "IV" + ToRoman(number - 4);
            }

            if (number >= 1)
            {
                return "I" + ToRoman(number - 1);
            }

            throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
        }
    }
}
