using System;

namespace Logic
{
    public partial class Snake
    {
        public bool TryStep(Direction direction, int size)
        {
            var askIsDead = true;

            switch (direction)
            {
                case Direction.Left:
                    if (CoordinateX > 0)
                    {
                        CoordinateX--;
                        askIsDead = false;
                    }
                    break;
                case Direction.Right:
                    if (CoordinateX < size - 1)
                    {
                        CoordinateX++;
                        askIsDead = false;
                    }
                    break;
                case Direction.Down:
                    if (CoordinateY < size - 1)
                    {
                        CoordinateY++;
                        askIsDead = false;
                    }
                    break;
                case Direction.Up:
                    if (CoordinateY > 0)
                    {
                        CoordinateY--;
                        askIsDead = false;
                    }
                    break;
            }

            if (askIsDead)
            {
                IsDead();
            }

            return !askIsDead;
        }
    }
}