using Algorithm;
using Newtonsoft.Json;
using static System.Console;
using Common;

namespace Logic
{
    public class Game
    {    
        private Game() {}
        //private static Game _instance;
        private static Game _instance;

        private static Game GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Game();
            }
            return _instance;
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
                if(snake.Eat(Food.Coordinate.X, Food.Coordinate.Y))
                {
                    Food.New(field.Size);
                }
                ReadKey();
            }
        }
    }
}