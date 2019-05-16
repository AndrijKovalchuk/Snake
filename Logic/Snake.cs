namespace Logic
{
    using System.Collections;
    using System.Collections.Generic;
    using Common;

    public class Snake : IReadOnlyList<Cell>
    {
        public List<Point> Body { get; private set; }

        public Point Head
        {
            get => Body[Body.Count - 1];

            private set => Body.Add(value);
        }

        public Move Direction { get; private set; }

        public int Count => Body.Count;

        public Cell this[int index]
        {
            get => new Cell(Body[index], index == Body.Count - 1 ? CellState.SnakeHead : CellState.SnakeBody);

            private set => Body[index] = value.Coordinate;
        }

        public Snake(Point initialPosition, Move initialDirection)
        {
            Body = new List<Point>();
            Body.Add(initialPosition);
            Direction = initialDirection;
        }

        public void Add(Point partBody, bool eat = false)
        {
            Body.Add(partBody);
            if (!eat)
            {
                Body.RemoveAt(0);
            }
        }

        public bool IsPresent(Point position)
        {
            return Body.IndexOf(position) > 0;
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}