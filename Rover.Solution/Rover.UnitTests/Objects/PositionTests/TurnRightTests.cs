using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Objects.PositionTests
{
    public class TurnRightTests
    {
        [Fact]
        public void FacingNorth()
        {
            Position position = new Position(1, 1, "N");
            position.TurnRight();

            Assert.Equal("E", position.Direction);
        }

        [Fact]
        public void FacingWest()
        {
            Position position = new Position(1, 1, "W");
            position.TurnRight();

            Assert.Equal("N", position.Direction);
        }

        [Fact]
        public void FacingSouth()
        {
            Position position = new Position(1, 1, "S");
            position.TurnRight();

            Assert.Equal("W", position.Direction);
        }

        [Fact]
        public void FacingEast()
        {
            Position position = new Position(1, 1, "E");
            position.TurnRight();

            Assert.Equal("S", position.Direction);
        }
    }
}
