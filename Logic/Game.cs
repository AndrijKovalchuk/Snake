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

        public static void Start()
        {

            //Data DataOut = new Data();            
            //var algo = new TestAlgorithm();
            Field field = new Field();
            //Food food = new Food();
            Snake snake = new Snake(field.StartCordinateX, field.StartCordinateY);

            Food.New(field.Size);

            for (Move direction = Move.None; snake.TryStep(direction, field.Size); direction = TestAlgorithm.GetMove(snake.Body, snake.Head, Food.Coordinate)) 
            {
                Clear();
                //snake.TryStep(direction, field.Size);  
                field.Draw(snake.Body[snake.Body.Count - 1].X, snake.Body[snake.Body.Count - 1].Y, Food.Coordinate.X, Food.Coordinate.Y);
                              
                //algo.SetGameField(field.Array);
                WriteLine(snake.Head.X + " " + Food.Coordinate.X);
                WriteLine(snake.Head.Y + " " + Food.Coordinate.Y);
                WriteLine(direction);
                if(snake.Eat(Food.Coordinate.X, Food.Coordinate.Y))
                {
                    Food.New(field.Size);
                }
                ReadKey();
            }
        }
    }
}