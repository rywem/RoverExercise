using Rover.ConsoleApplication.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.ConsoleApplication.Input
{
    public class GridInput
    {

        public string[] SplitInput(string input)
        {
            return input.Split(" ");
        }

        public int[] ParseStringArrayToIntArray(string[] stringArray)
        {
            int[] gridDimensionArrayAsInt = new int[stringArray.Length];
            for ( int i = 0; i < stringArray.Length; i++ )
            {
                int parseValue;

                if ( int.TryParse(stringArray[i], out parseValue) )
                    gridDimensionArrayAsInt[i] = parseValue;
            }
            return gridDimensionArrayAsInt;
        }

        public Grid CreateGrid(int[] intArray )
        {
            return new Grid(intArray[0], intArray[1]);
        }
    }
}
