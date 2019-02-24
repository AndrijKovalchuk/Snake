using System;

namespace Logic
{
    public partial class Snake
    {
        private bool CheckMove(char NextDirection)
        {            
                // Cheking 4 directions
                if(this.CordinateX == 0 & NextDirection == 'l') 
                {
                    return false;
                }

                if(this.CordinateY == 0 & NextDirection == 'd')
                {
                    return false;
                }

                if(this.CordinateX == 99 & NextDirection == 'r')
                {
                    return false;
                }

                if(this.CordinateY == 99 & NextDirection == 'u')
                {
                    return false;
                }
            
            return true;
        }
        public void MakeMove(char NextDirection)
        {
            //Console.WriteLine(NextCordinateX);
            ClaculateNextCordinats(NextDirection);
            if(CheckMove(NextDirection))
            {
                //Console.WriteLine(this.NextCordinateX);
                this.Direction = NextDirection;
                this.CordinateX = NextCordinateX;
                this.CordinateY = NextCordinateY;
            }
            
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
        public void ClaculateNextCordinats(char NextDirection)
        {
            switch(NextDirection)
            {
                case 'l':
                    this.NextCordinateX = this.CordinateX - 1;
                    break;
                case 'r':
                    this.NextCordinateX = this.CordinateX + 1;
                    break;
                case 'd':
                    this.NextCordinateY = this.CordinateY - 1;
                    break;
                case 'u':
                    this.NextCordinateY = this.CordinateY + 1;
                    break;
                
            }
        }
    }
}