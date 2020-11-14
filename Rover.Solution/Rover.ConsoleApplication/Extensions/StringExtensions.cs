using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.ConsoleApplication.Extensions
{
    public static class StringExtensions
    {
        public static int ToInt(this string stringToParse )
        {
            int value;

            if ( int.TryParse(stringToParse, out value) )
                return value;
            else
                throw new ArgumentException("Not a valid integer.");
        }
    }
}
