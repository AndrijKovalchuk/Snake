namespace Logic
{
    //using System.IO;
    //using System.Reflection;
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

        //private static readonly ILog logger = LogManager.GetLogger(typeof(GameField));

        public GameField()
        {
            Food = Point.Random(Size);
            Kite = new Snake(new Point(1, 1), Move.Up);
        }

        public void MakeMove(Move direction)
        {
            //XmlConfigurator.Configure(LogManager.GetRepository(Assembly.GetEntryAssembly()), new FileInfo("Logic.config"));

            //logger.Info("Directrion: " + direction + "Status: " + Status);

            if (Status == GameStatus.Play)
            {
                Kite.SetMove(direction);

                if (Kite.IsReverseMovement())
                {
                    Status = GameStatus.GameOver;
                    Log += "Move " + direction + " is reverse\n";
                    //logger.Info("Move" + direction + "is reversed");
                    //logger.Info("Status: " + Status);
                    Logger.Info("test message");
                }

                if (Kite.IsCrashed())
                {
                    Status = GameStatus.GameOver;
                    Log += "Move " + direction + " is crashed\n";
                    //logger.Info("Move: " + direction + ". Snake has crashed");
                    //logger.Info("Status: " + Status);
                }

                //logger.Info("Snake is doing step or eating");
                if (Kite.MoveIsEat(Food))
                {
                    //logger.Info("Snake has eaten");
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