namespace Logic
{
    using System;
    using static System.Console;

    public class Field
    {
        public int Size { get; set; } = 20;  // It means rectangle 20x20

        public int StartCordinateX { get; } = 1;

        public int StartCordinateY { get; } = 1;

        public void Draw(int snakeX, int snakeY, int foodX, int foodY)
        {
            for (int i = Size - 1; i >= 0; i--)
            {
               for (int j = 0; j < Size; j++)
               {
                   if (j == snakeX && i == snakeY)
                   {
                       Write("S");
                   }
                   else if (j == foodX && i == foodY)
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