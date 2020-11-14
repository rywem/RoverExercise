using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.ConsoleApplication.Objects
{
    public class Position
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string Direction { get; set; }        
        public Position( int xPosition, int yPositon, string direction)
        {            
            XPosition = xPosition;
            YPosition = yPositon;
            Direction = direction;
        }

        public void Move()
        {
            switch ( Direction )
            {
                case "N":
                    YPosition++;
                    break;
                case "E":
                    XPosition++;
                    break;
                case "S":
                    YPosition--;
                    break;
                case "W":
                    XPosition--;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch ( Direction )
            {
                case "N":
                    Direction = "W";
                    break;
                case "E":
                    Direction = "N";
                    break;
                case "S":
                    Direction = "E";
                    break;
                case "W":
                    Direction = "S";
                    break;
                default:
                    break;
            }
        }
        public void TurnRight()
        {
            switch ( Direction )
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "N";
                    break;
                default:
                    break;
            }
        }

        public string GetPosition()
        {
            return $"{XPosition} {YPosition} {Direction}";
        }
    }
}
