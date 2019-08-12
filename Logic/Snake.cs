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
            Body = new List<Point>
            {
                initialPosition,
            };
            Direction = initialDirection;
        }

        public void SetMove(Move direction)
        {
            currentMove = direction;
            currentPoint = Head + MovePoint.GetPoint(currentMove);
        }

        public bool IsReverseMovement()
        {
            return (-1 * (int)Direction) == (int)currentMove;
        }

        public bool IsCrashed()
        {
            return Body.IndexOf(currentPoint) > 0;
        }

        public bool MoveIsEat(Point food)
        {
            Body.Add(currentPoint);

            if (!food.Equals(currentPoint))
            {
                Body.RemoveAt(0);
            }

            Direction = currentMove;
            currentMove = Move.None;

            return food.Equals(currentPoint);
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            return GetEnumerator();
        }

        private Move currentMove;

        public Point currentPoint { get; private set; }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}