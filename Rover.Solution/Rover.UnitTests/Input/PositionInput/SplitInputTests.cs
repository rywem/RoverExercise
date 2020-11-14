using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Input.PositionInput
{
    public class SplitInputTests
    {
        [Fact]
        public void SplitInput_ValidValues()
        {
            string input = "1 2 N";
            Rover.ConsoleApplication.Input.PositionInput positionInput = new ConsoleApplication.Input.PositionInput();
            var result = positionInput.SplitInput(input);

            Assert.Collection(result,
                value => Assert.Equal("1", value),
                value => Assert.Equal("2", value),
                value => Assert.Equal("N", value)
            );
        }
    }
}
