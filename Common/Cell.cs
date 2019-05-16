namespace Common
{
    public class Cell
    {
        public Point Coordinate
        {
            get;
            private set;
        }

        public CellState State
        {
            get;
            private set;
        }

        public Cell(Point point, CellState state)
        {
            Coordinate = point;
            State = state;
        }
    }
}
