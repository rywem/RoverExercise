using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.ConsoleApplication.Objects
{
    public class Grid
    {
        public int XBound { get; set; }
        public int YBound { get; set; }

        public Grid(int xBound, int yBound)
        {
            XBound = xBound;
            YBound = yBound;
        }
    }
}
