using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Point
    {
        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }

        public StatePoint State
        {
            get;
            private set;
        }

        public Point(int x, int y, StatePoint state)
        {
            X = x;
            Y = y;
            State = state;
        }
    }
}
