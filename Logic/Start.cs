using Algorithm;
using Newtonsoft.Json;
using static System.Console;

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
        public void Start()
        {  
            int Itt = 0;          
            //Data DataOut = new Data();            
            Algorithm1 algo = new Algorithm1();
            Field field = new Field();
            Food food = new Food();
            Snake snake = new Snake();

            //food.Generate(field.Size);

            snake.CoordinateX = field.StartCordinateX;
            snake.CoordinateY = field.StartCordinateY;          
            
            while(Itt < 10)
            {
                field.DrawClean();
                field.DrawFood(food.CordinateX, food.CordinateY, food.Symbol);
                field.DrawSnake(snake.CoordinateX, snake.CoordinateY, snake.HeadSymbol);
                field.Print();
                algo.SetGameField(field.Array);
                Move direction = algo.GetMove();
                snake.DoStep((Direction) (int)direction , field.Size);
                if(snake.Eat(food.CordinateX, food.CordinateY))
                {
                    food.Generate(field.Size);
                }
                Itt++;             
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