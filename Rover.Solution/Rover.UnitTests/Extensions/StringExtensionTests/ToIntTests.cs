using Rover.ConsoleApplication.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Rover.UnitTests.Extensions.StringExtensionTests
{
    public class ToIntTests
    {
        [Fact]
        public void StringToInt_IsAValidNumber()
        {
            string stringToParse = "2";
            int value = stringToParse.ToInt();

            Assert.Equal(2, value);
        }

        [Fact]
        public void StringToInt_ThrowsExceptionOnStringCharacter()
        {
            string stringToParse = "c";

            var ex = Assert.Throws<ArgumentException>(() => stringToParse.ToInt());
            Assert.Equal("Not a valid integer.", ex.Message);
        }
    }
}
