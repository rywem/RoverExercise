using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Rover.UnitTests.Input.GridInput
{
    public class ParseStringArrayToIntArrayTests
    {
        [Fact]
        public void ParseIntArray_2ValidInputs()
        {
            string[] input = new string[] { "4", "5" };
            Rover.ConsoleApplication.Input.GridInput gridInput = new ConsoleApplication.Input.GridInput();
            var result = gridInput.ParseStringArrayToIntArray(input);

            Assert.Collection(result,
                value => Assert.Equal(4, value),
                value => Assert.Equal(5, value)
            );
        }
    }
}
