using System;
using static System.Console;

namespace Logic
{
    public partial class Field
    {
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