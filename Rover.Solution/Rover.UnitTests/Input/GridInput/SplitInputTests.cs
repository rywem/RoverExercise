using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Rover.UnitTests.Input.GridInput
{
    public class SplitInputTests
    {
        [Fact]
        public void SplitStringArray_2ValidInputs()
        {
            string input = "4 5";
            Rover.ConsoleApplication.Input.GridInput gridInput = new ConsoleApplication.Input.GridInput();
            var result = gridInput.SplitInput(input);

            Assert.Collection(result, 
                value => Assert.Equal("4", value),
                value => Assert.Equal("5", value)
            );
        }

        [Fact]
        public void SplitStringArray_1ValidInputs()
        {
            string input = "45";
            Rover.ConsoleApplication.Input.GridInput gridInput = new ConsoleApplication.Input.GridInput();
            var result = gridInput.SplitInput(input);

            Assert.Collection(result,
                value => Assert.Equal("45", value)
            );
        }
    }
}
