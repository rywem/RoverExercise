using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Objects.GridTests
{
    public class ValidatePositionTests
    {
        [Fact]
        public void ValidatePosition_WherePositionIsValid()
        {
            Grid grid = new Grid(5, 5);
            Position position = new Position(1, 2, "N");

            Assert.True(grid.ValidatePosition(position));
        }

        [Fact]
        public void ValidatePosition_WherePositionIsValid_OnBorder()
        {
            Grid grid = new Grid(5, 5);
            Position position = new Position(5, 5, "N");

            Assert.True(grid.ValidatePosition(position));
        }

        [Fact]
        public void ValidatePosition_WhereXPositionIsInvalid_AboveUpperBounds()
        {
            Grid grid = new Grid(5, 5);
            Position position = new Position(10, 2, "N");

            var ex = Assert.Throws<Exception>(() => grid.ValidatePosition(position));
            Assert.Equal("Rover out of bounds.", ex.Message);
        }

        [Fact]
        public void ValidatePosition_WhereXPositionIsInvalid_BelowLowerBounds()
        {
            Grid grid = new Grid(5, 5);
            Position position = new Position(-1, 2, "N");

            var ex = Assert.Throws<Exception>(() => grid.ValidatePosition(position));
            Assert.Equal("Rover out of bounds.", ex.Message);
        }

        [Fact]
        public void ValidatePosition_WhereYPositionIsInvalid_AboveUpperBounds()
        {
            Grid grid = new Grid(5, 5);
            Position position = new Position(1, 10, "N");

            var ex = Assert.Throws<Exception>(() => grid.ValidatePosition(position));
            Assert.Equal("Rover out of bounds.", ex.Message);
        }

        [Fact]
        public void ValidatePosition_WhereYPositionIsInvalid_BelowLowerBounds()
        {
            Grid grid = new Grid(5, 5);
            Position position = new Position(2, -2, "N");

            var ex = Assert.Throws<Exception>(() => grid.ValidatePosition(position));
            Assert.Equal("Rover out of bounds.", ex.Message);
        }
    }
}
