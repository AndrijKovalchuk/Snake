namespace Logic
{
    using Common;

    public class MovePoint
    {
        public static Point GetPoint(Move direction)
        {
            switch (direction)
            {
                case Move.Up:
                    return new Point(0, 1);
                case Move.Left:
                    return new Point(-1, 0);
                case Move.Right:
                    return new Point(1, 0);
                case Move.Down:
                    return new Point(0, -1);
                default:
                    return new Point(0, 0);
            }
        }
    }
}
