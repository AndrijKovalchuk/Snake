using System;

namespace Logic
{
    public partial class Food
    {
        public void Generate(int FieldSize)
        {
            Random random = new Random();

            this.CordinateX = random.Next(FieldSize);
            this.CordinateY = random.Next(FieldSize);
        }
    }
}