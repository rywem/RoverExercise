using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Objects.PositionTests
{
    public class MoveTests
    {
        [Fact]
        public void FacingNorth()
        {
            Position position = new Position(1, 1, "N");
            position.Move();

            Assert.Equal(1, position.XPosition);
            Assert.Equal(2, position.YPosition);
        }

        [Fact]
        public void FacingWest()
        {
            Position position = new Position(1, 1, "W");
            position.Move();

            Assert.Equal(0, position.XPosition);
            Assert.Equal(1, position.YPosition);
        }

        [Fact]
        public void FacingSouth()
        {
            Position position = new Position(1, 1, "S");
            position.Move();

            Assert.Equal(1, position.XPosition);
            Assert.Equal(0, position.YPosition);
        }

        [Fact]
        public void FacingEast()
        {
            Position position = new Position(1, 1, "E");
            position.Move();

            Assert.Equal(2, position.XPosition);
            Assert.Equal(1, position.YPosition);
        }
    }
}
