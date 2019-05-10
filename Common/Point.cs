namespace Common
{
    public class Point
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

        public StatePoint State
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="state"></param>
        public Point(int x, int y, StatePoint state)
        {
            X = x;
            Y = y;
            State = state;
        }
    }
}
