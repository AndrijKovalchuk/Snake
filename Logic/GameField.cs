namespace Logic
{
    using System;
    using Common;

    public class GameField
    {
        public Point Size { get; private set; } = new Point(20, 20);

        public GameStatus Status { get; private set; } = GameStatus.Play;

        public Point Food { get; private set; }

        public Snake Kite { get; private set; }

        public GameField()
        {
            Food = Point.Random(Size);
            Kite = new Snake(new Point(1, 1), Move.Up);
        }

        public void MakeMove(Move direction)
        {
            if (Status == GameStatus.Play)
            {
                var movePoint = Kite.Head + MovePoint.GetPoint(direction);

                if (Kite.Head - MovePoint.GetPoint(Kite.Direction) == movePoint)
                {
                    throw new Exception("Reverse movement is not allowed!");
                }

                if (Kite.IsPresent(movePoint))
                {
                    Status = GameStatus.GameOver;
                }

                var eatFood = movePoint.Equals(Food);

                Kite.Add(movePoint, eatFood);

                if (eatFood)
                {
                    Food = Point.Random(Size);
                }
            }
        }

        public CellState this[int x, int y]
        {
            get
            {
                var enterPoint = new Point(x, y);

                if (Kite.Head.Equals(enterPoint))
                {
                    return CellState.SnakeHead;
                }

                if (Kite.Body.IndexOf(enterPoint) != -1)
                {
                    return CellState.SnakeBody;
                }

                if (Food.Equals(enterPoint))
                {
                    return CellState.Food;
                }

                return CellState.Empty;
            }
        }
    }
}