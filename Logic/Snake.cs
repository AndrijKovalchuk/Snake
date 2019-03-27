using System;
using Common;

namespace Logic
{
    public partial class Snake
    {
        public int Size { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public char HeadSymbol { get; set; } = '1';
        public char BodySymbol { get; set; }

        public bool TryStep(Move direction, int size)
        {
            var askIsDead = true;

            switch (direction)
            {
                case Move.Left:
                    if (CoordinateX > 0)
                    {
                        CoordinateX--;
                        askIsDead = false;
                    }
                    break;
                case Move.Right:
                    if (CoordinateX < size - 1)
                    {
                        CoordinateX++;
                        askIsDead = false;
                    }
                    break;
                case Move.Down:
                    if (CoordinateY < size - 1)
                    {
                        CoordinateY++;
                        askIsDead = false;
                    }
                    break;
                case Move.Up:
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

        public bool Eat(int x, int y)
        {
            if(this.CoordinateX == x & this.CoordinateY == y)
            {
                this.Size++;
                Console.WriteLine(this.Size);
                return true;
            }
            return false;
        }

        public void IsDead()
        {
            Console.WriteLine("This is the end of your story");
        }
    }
}