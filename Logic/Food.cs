using System;
using Common;

namespace Logic
{
    public class Food 
    {
        public static Point Coordinate{ get; private set; }
        private Food(){}
        public static void New(int FieldSize)
        {
            Random random = new Random();

            Coordinate = new Point(random.Next(FieldSize),random.Next(FieldSize), StatePoint.Food);
            //Coordinate = new Point(1,15, StatePoint.food);
        }
        
    }
}