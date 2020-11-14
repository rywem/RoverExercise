using System;

namespace Rover.ConsoleApplication
{
    class Program
    {
        static void Main( string[] args )
        {

            Console.WriteLine("Enter Grid Dimensions:");
            string gridDimension = Console.ReadLine();

            Input.GridInput gridInput = new Input.GridInput();            

            var stringArray = gridInput.SplitInput(gridDimension);
            int[] gridDimensionArrayAsInt = gridInput.ParseStringArrayToIntArray(stringArray);

            Objects.Grid grid = gridInput.CreateGrid(gridDimensionArrayAsInt);

            while ( true )
            {

            }
        }
    }
}
