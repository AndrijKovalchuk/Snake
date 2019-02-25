using System;

namespace Logic
{
    public partial class Snake
    {
        public void DoStep(int Direction)
        {
            switch (Direction)
            {
                case 'l':
                    this.CoordinateX--;
                    break;
                case 'r':
                    this.CoordinateX++;
                    break;
                case 'd':
                    this.CoordinateY--;
                    break;
                case 'u':
                    this.CoordinateY++;
                    break;
            }
        }
    }
}