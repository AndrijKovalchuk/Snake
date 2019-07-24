namespace Common
{
    public class MovePoint
    {
        private MovePoint()
        {
        }

        public static readonly Point UpPoint;
        public static readonly Point LeftPoint;
        public static readonly Point RightPoint;
        public static readonly Point DownPoint;
        public static readonly Point NonePoint;

        static MovePoint()
        {
            UpPoint = new Point(0, 1);
            LeftPoint = new Point(-1, 0);
            RightPoint = new Point(1, 0);
            DownPoint = new Point(0, -1);
            NonePoint = new Point(0, 0);
        }

        public static Point GetPoint(Move direction)
        {
            switch (direction)
            {
                case Move.Up:
                    return UpPoint;
                case Move.Left:
                    return LeftPoint;
                case Move.Right:
                    return RightPoint;
                case Move.Down:
                    return DownPoint;
                default:
                    return NonePoint;
            }
        }
    }
}
