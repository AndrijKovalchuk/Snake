using System;
using static System.Console;
//using Common;
using System.Collections.Generic;
using System.Drawing;

namespace Logic
{
    public class Field 
    {
        public int Size { get; set;} = 20;  // It means rectangle 20x20
        //public Point[,] Array = new Point[20, 20];
        //private List<Point> Array = new List<Point>();
        public int StartCordinateX { get; } = 1;
        public int StartCordinateY { get; } = 1;
        
        public void Draw(int SnakeX, int SnakeY, int FoodX, int FoodY)
        {
            for(int i = Size - 1;i >= 0;i--)
            {
               for(int j=0; j<Size; j++)
               {
                   if(j == SnakeX & i == SnakeY)
                   {
                       Write("S");
                   }
                   if(j == FoodX & i == FoodY)
                   {
                       Write("F");
                   }
                   else
                   {
                       Write("_");
                   }
               }
               Write("\n");
            }
        }


        /*
        public void DrawClean()
        {
            for(int i = 0; i < this.Size; i++)
            {
                for(int j = 0; j < this.Size; j++)
                {
                    //Array[ i, j].State = StatePoint.empty;
                    //Array[i,j](1,2,StatePoint.empty);
                }
            }
        }
            
        public void DrawFood(int x, int y, char Symbol)
        {
            this.Array[y,x] = Symbol;
        }

        public void DrawSnake(int x, int y, char Symbol)
        {
            this.Array[y, x] = Symbol;
        }
        
        
        public void Print()
        {
            for(var i = 0; i < Array.GetLength(0); i++)
            {
                for(var j = 0; j < Array.GetLength(1); j++)
                {
                    ColorWrite(Array[i,j]);
                }
                WriteLine();
            }
        }*/

        private void ColorWrite(char token)
        {
            switch (token)
            {
                case '1':
                    ForegroundColor = ConsoleColor.Green;
                    break;
                case 'X':
                    ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Write(token + " ");

            ResetColor();
        }    
    }
}