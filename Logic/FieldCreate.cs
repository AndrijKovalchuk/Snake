using System;
using static System.Console;

namespace Logic
{
    public partial class Field
    {
        public void InitField()
        {
            FieldClean();
            this.GameField[5, 5] = 'X'; 
            this.GameField[1, 1] = '1';        
        }
        public void DoMove(char Direction)
        {
            Snake snake = new Snake();
            Food food = new Food();

            FieldClean();
            
            this.GameField[food.CordinateY, food.CordinateX] = food.Ch;
            //WriteLine(Direction);
            snake.MakeMove(Direction);
            this.GameField[snake.CordinateY, snake.CordinateX] = snake.Ch;
        }

        private void FieldClean()
        {
            for(int i = 0; i < FieldSize; i++)
            {
                for(int j = 0; j < FieldSize; j++)
                {
                    this.GameField[i, j] = '+';
                }
            }            
        }
    }
}