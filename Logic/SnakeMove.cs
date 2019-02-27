using System;

namespace Logic
{
    public partial class Snake
    {
        public void DoStep(string Direction, int size)
        {
            switch (Direction)
            {
                case "l":
                    if(this.CoordinateX == 0)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateX--;
                    break;
                case "r":
                    if(this.CoordinateX == size - 1)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateX++;
                    break;
                case "d":
                    if(this.CoordinateY == 0)
                    {
                        IsDead();
                        break;
                    }
                    this.CoordinateY--;
                    break;
                case "u":
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