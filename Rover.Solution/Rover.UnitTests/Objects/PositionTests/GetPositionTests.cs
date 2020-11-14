using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Rover.UnitTests.Objects.PositionTests
{
    public class GetPositionTests
    {
        [Fact]
        public void GetPosition_NotMoved()
        {
            Position position = new Position(1, 3, "N");
            string getPositionResult = position.GetPosition();

            Assert.Equal("1 3 N", getPositionResult);
        }
    }
}
