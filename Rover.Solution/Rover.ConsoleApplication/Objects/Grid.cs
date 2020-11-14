using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.ConsoleApplication.Objects
{
    public class Grid
    {
        public int XBound { get; set; }
        public int YBound { get; set; }

        public Grid( int xBound, int yBound )
        {
            XBound = xBound;
            YBound = yBound;
        }

        public bool ValidatePosition( Position position )
        {
            if ( position.YPosition >= 0 && position.YPosition <= YBound && position.XPosition >= 0 && position.XPosition <= XBound )
                return true;
            else 
                throw new Exception("Rover out of bounds.");
        }

    }
}
