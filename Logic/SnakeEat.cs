using System;

namespace Logic
{
    public partial class Snake
    {
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
    }
}