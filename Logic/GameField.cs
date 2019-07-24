namespace Logic
{
    using Common;

    public class GameField
    {
        public Point Size { get; private set; } = new Point(20, 20);

        public GameStatus Status { get; private set; } = GameStatus.Play;

        public Point Food { get; private set; }

        public Snake Kite { get; private set; }

        public string Log = string.Empty;

        public GameField()
        {
            Food = Point.Random(Size);
            Kite = new Snake(new Point(1, 1), Move.Up);
        }

        public void MakeMove(Move direction)
        {
            if (Status == GameStatus.Play)
            {
                Kite.SetMove(direction);

                if (Kite.IsReverseMovement())
                {
                    Status = GameStatus.GameOver;
                    Log += "Move " + direction + " is reverse\n";
                }

                if (Kite.IsCrashed())
                {
                    Status = GameStatus.GameOver;
                    Log += "Move " + direction + " is crashed\n";
                }

                if (Kite.MoveIsEat(Food))
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