namespace Logic
{
    using Algorithm;
    using Common;
    using Newtonsoft.Json;
    using static System.Console;

    public class Game
    {
        private Game()
        {
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

        public static void Start()
        {
            Game game = GetInstance();
            game.Play();
        }

        public void Play()
        {
            Field field = new Field();
            Snake snake = new Snake(field.StartCordinateX, field.StartCordinateY);

            Food.New(field.Size);

            for (Move direction = Move.None; snake.TryStep(direction, field.Size); direction = TestAlgorithm.GetMove(snake.Body, snake.Head, Food.Coordinate))
            {
                Clear();
                field.Draw(snake.Body[snake.Body.Count - 1].X, snake.Body[snake.Body.Count - 1].Y, Food.Coordinate.X, Food.Coordinate.Y);

                WriteLine("snake.Head.X = " + snake.Head.X + "\tFood.Coordinate.X =  " + Food.Coordinate.X);
                WriteLine("snake.Head.Y = " + snake.Head.Y + "\tFood.Coordinate.Y " + Food.Coordinate.Y);
                WriteLine("direction = " + direction);
                WriteLine("BodyCount = " + snake.Body.Count);
                WriteLine("Size = " + snake.Size);

                if (snake.Eat(Food.Coordinate.X, Food.Coordinate.Y))
                {
                    Food.New(field.Size);
                }

                ReadKey();
            }
        }
    }
}