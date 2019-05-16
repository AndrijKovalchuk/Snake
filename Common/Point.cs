namespace Common
{
    using System;

    public class Point : IEquatable<Point>
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

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point Random(Point maxValue)
        {
            var random = new Random();
            return new Point(random.Next(maxValue.X), random.Next(maxValue.Y));
        }

        public bool Equals(Point other)
        {
            if (other == null)
            {
                return false;
            }

            return X == other.X && Y == other.Y;
        }

        public static Point operator +(Point left, Point right)
        {
            return new Point(left.X + right.X, left.Y + right.Y);
        }

        public static Point operator -(Point left, Point right)
        {
            return new Point(left.X - right.X, left.Y - right.Y);
        }
    }
}
