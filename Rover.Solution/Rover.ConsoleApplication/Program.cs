using Rover.ConsoleApplication.Objects;
using System;

namespace Rover.ConsoleApplication
{
    class Program
    {
        static void Main( string[] args )
        {

            Console.WriteLine("Enter Grid Dimensions:");
            string gridDimension = Console.ReadLine();

            Input.GridInput gridUserInput = new Input.GridInput();            

            var stringArray = gridUserInput.SplitInput(gridDimension);
            int[] gridDimensionArrayAsInt = gridUserInput.ParseStringArrayToIntArray(stringArray);

            Grid grid = gridUserInput.CreateGrid(gridDimensionArrayAsInt);

            while ( true )
            {
                Console.WriteLine("Enter Position:");
                string positionUserInput = Console.ReadLine();
                Input.PositionInput positionInput = new Input.PositionInput();

                var positionInputAsStringArray = positionInput.SplitInput(positionUserInput);
                Position position = positionInput.CreatePosition(positionInputAsStringArray);

                Console.WriteLine("Enter Commands:");
                string commandUserInput = Console.ReadLine();

                for ( int i = 0; i < commandUserInput.Length; i++ )
                {
                    switch ( commandUserInput[i] )
                    {
                        case 'L':
                            position.TurnLeft();
                            break;
                        case 'R':
                            position.TurnRight();
                            break;
                        case 'M':
                            position.Move();
                            break;
                        default:
                            break;
                    }
                }
                grid.ValidatePosition(position);
                Console.WriteLine(position.GetPosition());


            }
        }
    }
}
