using System;

namespace Logic
{
    public partial class Snake
    {
        private bool CheckMove(char NextDirection, int NextCordinateX, int NextCordinateY)
        {
            if(Math.Abs(NextCordinateX - CordinateX) == 1 & Math.Abs(NextCordinateY - CordinateY) == 1)
            {
                // Cheking 4 directions
                if(NextCordinateX == 0 & NextDirection == 'l') 
                {
                    return false;
                }

                if(NextCordinateY == 0 & NextDirection == 'd')
                {
                    return false;
                }

                if(NextCordinateX == 99 & NextDirection == 'r')
                {
                    return false;
                }

                if(NextCordinateY == 99 & NextDirection == 'u')
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public void MakeMove(char NextDirection, int NextCordinateX, int NextCordinateY)
        {
            if(CheckMove(NextDirection, NextCordinateX, NextCordinateY))
            {
                this.Direction = NextDirection;
                this.CordinateX = NextCordinateX;
                this.CordinateY = NextCordinateY;
            }
            
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
    }
}