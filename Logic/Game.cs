using Algorithm;
using Newtonsoft.Json;
using static System.Console;
using Common;

namespace Logic
{
    public enum Direction
    {
        Up = 1,
        Down,
        Right,
        Left
    }
    public class Game
    {    
        private Game() {}
        //private static Game _instance;

        public static void Start()
        {  
            
            //Data DataOut = new Data();            
            Algorithm1 algo = new Algorithm1();
            Field field = new Field();
            Food food = new Food();
            Snake snake = new Snake();

            //food.Generate(field.Size);

            snake.CoordinateX = field.StartCordinateX;
            snake.CoordinateY = field.StartCordinateY;

            

            for (Move direction = Move.Left; snake.TryStep((Direction)(int)direction, field.Size); direction = algo.GetMove())
            {
                field.DrawClean();
                field.DrawFood(food.CordinateX, food.CordinateY, food.Symbol);
                field.DrawSnake(snake.CoordinateX, snake.CoordinateY, snake.HeadSymbol);

                Clear();
                field.Print();

                algo.SetGameField(field.Array);
                WriteLine(direction);
                if(snake.Eat(food.CordinateX, food.CordinateY))
                {
                    food.Generate(field.Size);
                }
                ReadKey();
            }
        }

        private string GetData(string input)
        {
            var type = new {direction = ""};
            var Direction = JsonConvert.DeserializeAnonymousType(input, type);

            Snake snake = new Snake();
            //snake.DoStep(Direction.direction);


            string a = "a";
            return a;
        }
    }
}