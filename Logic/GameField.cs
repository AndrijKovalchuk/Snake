namespace Logic
{
    // using System.IO;
    // using System.Reflection;
    using Common;
    using log4net;
    using log4net.Config;

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

                    Logger.Info("Move" + direction + "is reversed");
                    Logger.Info("Status: " + Status);                    
                }

                if (Kite.IsCrashed())
                {
                    Status = GameStatus.GameOver;
                    Log += "Move " + direction + " is crashed\n";
                    Logger.Info("Move: " + direction + ". Snake has crashed");
                    Logger.Info("Status: " + Status);
                }

                if(OutOfRange(direction))
                {
                    Status = GameStatus.GameOver;
                    Log += "You have went beyond";
                }
                // logger.Info("Snake is doing step or eating");
                if (Kite.MoveIsEat(Food))
                {
                    Logger.Info("Snake has eaten");
                    Food = Point.Random(Size);
                }
            }
        }

        public CellState this[int x, int y]
        {
            get
            {
                if (Food.Equals(x, y))
                {
                    return CellState.Food;
                }

                if (Kite.Head.Equals(x, y))
                {
                    return CellState.SnakeHead;
                }

                if (Kite.Body.Exists(item => item.X == x && item.Y == y))
                {
                    return CellState.SnakeBody;
                }

                return CellState.Empty;
            }
        }

        public bool OutOfRange(Move direction)
        {
            switch (direction)
            {
                case Move.Down:
                    return Kite.currentPoint.Y < 0;
                case Move.Left:
                    return Kite.currentPoint.X < 0;
                case Move.Right:
                    return Kite.currentPoint.X >= Size.X;
                case Move.Up:
                    return Kite.currentPoint.Y >= Size.Y;
                default:
                    return false;
            }
        }
    }
}