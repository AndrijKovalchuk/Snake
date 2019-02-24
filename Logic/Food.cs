using System;

namespace Logic
{
    public class Food 
    {
        public int CordinateX { get; set; } = 5;
        public int CordinateY { get; set; } = 5;
        public char Ch = 'X';
        Random random = new Random();

        public void Generate()
        {
            CordinateX = random.Next(2, CordinateX - 2);
            CordinateY = random.Next(2, CordinateY - 2);
        }             
    }
}