using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Objects.PositionTests
{
    public class TurnLeftTests
    {
        [Fact]
        public void FacingNorth()
        {
            Position position = new Position(1, 1, "N");
            position.TurnLeft();

            Assert.Equal("W", position.Direction);
        }

        [Fact]
        public void FacingWest()
        {
            Position position = new Position(1, 1, "W");
            position.TurnLeft();

            Assert.Equal("S", position.Direction);
        }

        [Fact]
        public void FacingSouth()
        {
            Position position = new Position(1, 1, "S");
            position.TurnLeft();

            Assert.Equal("E", position.Direction);
        }

        [Fact]
        public void FacingEast()
        {
            Position position = new Position(1, 1, "E");
            position.TurnLeft();

            Assert.Equal("N", position.Direction);
        }
    }
}
