namespace Logic
{
    using System;
    using Algorithm;
    using Common;
    using static System.Console;

    public class Game
    {
        public static void Start()
        {
            Game game = GetInstance();
            game.Play();
        }

        public void Play()
        {
            for (var direction = Move.None; gameField.Status == GameStatus.Play; direction = TestAlgorithm.GetMove(gameField.Kite.Body, gameField.Kite.Head, gameField.Food))
            {
                Clear();
                ShowGameField();
                gameField.MakeMove(direction);
                ReadKey();
            }
        }

        public void ShowGameField()
        {
            for (var y = gameField.Size.Y - 1; y >= 0; y--)
            {
                for (var x = 0; x < gameField.Size.X; x++)
                {
                    ColorWrite(gameField[x, y]);
                }

                Write("\n");
            }
        }

        private GameField gameField;

        private Game()
        {
            gameField = new GameField();
        }

        private static Game instance;

        private static Game GetInstance()
        {
            if (instance == null)
            {
                instance = new Game();
            }

            return instance;
        }

        private void ColorWrite(CellState token)
        {
            switch (token)
            {
                case CellState.SnakeBody:
                    ForegroundColor = ConsoleColor.Green;
                    Write("U ");
                    break;
                case CellState.SnakeHead:
                    ForegroundColor = ConsoleColor.Green;
                    Write("A ");
                    break;
                case CellState.Food:
                    ForegroundColor = ConsoleColor.DarkRed;
                    Write("X ");
                    break;
                default:
                    ForegroundColor = ConsoleColor.Yellow;
                    Write("_ ");
                    break;
            }

            ResetColor();
        }
    }
}