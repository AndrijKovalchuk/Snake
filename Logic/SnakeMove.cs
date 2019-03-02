using System;

namespace Logic
{
    public partial class Snake
    {
        public void DoStep(Direction direction, int size)
        {
            switch (direction)
            {
                case Direction.Left:
                    if(this.CoordinateX == 0)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateX--;
                    break;
                case Direction.Right:
                    if(this.CoordinateX == size - 1)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateX++;
                    break;
                case Direction.Down:
                    if(this.CoordinateY == 0)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateY--;
                    break;
                case Direction.Up:
                    if(this.CoordinateY == size - 1)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateY++;
                    break;
            }
        }
    }
}