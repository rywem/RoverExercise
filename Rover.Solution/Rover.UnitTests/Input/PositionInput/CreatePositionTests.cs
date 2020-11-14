using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Input.PositionInput
{
    public class CreatePositionTests
    {
        [Fact]
        public void CreatePosition_ValidPosition()
        {
            string[] input = new string[] { "1", "2", "N" };
            Rover.ConsoleApplication.Input.PositionInput positionInput = new ConsoleApplication.Input.PositionInput();
            var position = positionInput.CreatePosition(input);

            Assert.Equal(1, position.XPosition);
            Assert.Equal(2, position.YPosition);
            Assert.Equal("N", position.Direction);
        }
    }
}
