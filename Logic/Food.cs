using System;

namespace Logic
{
    public class Food 
    {
        public int CordinateX { get; set; } = 1;
        public int CordinateY { get; set; } = 5;
        public char Symbol = 'X';

        public void Generate(int FieldSize)
        {
            Random random = new Random();

            this.CordinateX = random.Next(FieldSize);
            this.CordinateY = random.Next(FieldSize);
        }
        
    }
}