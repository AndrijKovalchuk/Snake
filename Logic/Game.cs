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
            var algo = new TestAlgorithm();
            Field field = new Field();
            //Food food = new Food();
            Snake snake = new Snake(field.StartCordinateX, field.StartCordinateY);

            Food.New(field.Size);

            for (Move direction = Move.Up; snake.TryStep(direction, field.Size); direction = algo.GetMove())
            //while(true)
            {
                Clear();
                snake.TryStep(Move.Up, field.Size);
                field.Draw(snake.Body[snake.Head].X, snake.Body[snake.Head].Y, Food.Coordinate.X, Food.Coordinate.Y);
                                
                //algo.SetGameField(field.Array);
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