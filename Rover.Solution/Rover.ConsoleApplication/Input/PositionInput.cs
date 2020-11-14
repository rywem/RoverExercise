using System;
using System.Collections.Generic;
using System.Text;
using Rover.ConsoleApplication.Extensions;
namespace Rover.ConsoleApplication.Input
{
    public class PositionInput
    {
        public string[] SplitInput( string input )
        {
            return input.Split(" ");
        }

        public Objects.Position CreatePosition( string[] inputAsStringArray )
        {
            return new Objects.Position(inputAsStringArray[0].ToInt(), inputAsStringArray[1].ToInt(), inputAsStringArray[2]);
        }
    }
}
