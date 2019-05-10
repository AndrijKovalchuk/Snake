namespace Logic
{
    using System;
    using Common;

    public class Food
    {
        public static Point Coordinate { get; private set; }

        private Food() { }

        public static void New(int fieldSize)
        {
            Random random = new Random();

            Coordinate = new Point(random.Next(fieldSize), random.Next(fieldSize), StatePoint.Food);
        }
    }
}