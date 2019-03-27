using System;
using static System.Console;

namespace Logic
{
    public class Field 
    {
        public int Size { get; set;} = 20;
        public char[,] Array = new char[20, 20];
        public int StartCordinateX { get; set; } = 1;
        public int StartCordinateY { get; set; } = 1;
        private char OpenSymbol { get; set; } = '+';
        
        public void DrawClean()
        {
            for(int i = 0; i < this.Size; i++)
            {
                for(int j = 0; j < this.Size; j++)
                {
                    this.Array[ i, j] = this.OpenSymbol;
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
        }

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