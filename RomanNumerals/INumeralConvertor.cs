namespace RomanNumerals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Interface for numeral converter
    /// </summary>
    public interface INumeralConvertor
    {
        string Convert(int number);
    }
}
