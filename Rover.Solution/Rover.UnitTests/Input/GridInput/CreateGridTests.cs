using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Rover.UnitTests.Input.GridInput
{
    public class CreateGridTests
    {
        [Fact]
        public void CreateGrid_Test()
        {
            int[] input = new int[] { 4, 5 };
            Rover.ConsoleApplication.Input.GridInput gridInput = new ConsoleApplication.Input.GridInput();
            Grid grid = gridInput.CreateGrid(input);

            Assert.Equal(4, grid.XBound);
            Assert.Equal(5, grid.YBound);
        }
    }
}
