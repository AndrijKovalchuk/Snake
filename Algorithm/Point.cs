using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Point
    {
        public int X, Y;

        public Point() : this(-1, -1) { } // Default value

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
