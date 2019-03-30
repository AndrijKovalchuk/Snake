using System;
using static System.Console;
using System.Collections.Generic;
using Common;

namespace Logic
{
    public class Snake
    {
        public int Size { get; private set; }
        public int Head { get; private set; }
        private int TempX { get; set; }
        private int TempY { get; set; }
        public List<Point> Body = new List<Point>();
        
        public Snake(int x, int y)
        {
            Point point = new Point(x,y,StatePoint.snakeBody);
            Body.Add(point);
            Size = 1;
            Head = 0;
        }
        
        public bool TryStep(Move direction, int size)
        {
            bool NotDead = true;

            switch (direction)
            {
                case Move.Left:
                    if(Body[Head].X > 0)
                    {
                        Point pointL = new Point(Body[Head].X, Body[Head].Y + 1,StatePoint.snakeBody);
                        Body.Add(pointL);
                        Body.RemoveAt(Head);
                        Head = Body.Count - 1;
                        NotDead = true;
                    }
                    else
                    {
                        NotDead = false;
                    }  
                    break;

                case Move.Right:
                    if(Body[Head].X < (size - 1))
                    {
                        Point pointR = new Point(Body[Head].X + 1, Body[Head].Y,StatePoint.snakeBody);
                        Body.Add(pointR);
                        Body.RemoveAt(Head);
                        Head = Body.Count - 1;
                        NotDead = true;
                    }  
                    else
                    {
                        NotDead = false;
                    }                       
                    break;

                case Move.Down:
                    if(Body[Head].Y > 0)
                    {
                        Point pointD = new Point(Body[Head].X, Body[Head].Y - 1,StatePoint.snakeBody);
                        Body.Add(pointD);
                        Body.RemoveAt(Head);
                        Head = Body.Count - 1;
                        NotDead = true;
                    }
                    else
                    {
                        NotDead = false;
                    }  
                    break;

                case Move.Up:
                    if (Body[Head].Y < (size - 1))
                    {
                        Point pointU = new Point(Body[Head].X, Body[Head].Y + 1,StatePoint.snakeBody);
                        Body.Add(pointU);
                        Body.RemoveAt(Head);
                        Head = Body.Count - 1;
                        NotDead = true;             
                    }
                    else
                    {
                        NotDead = false;
                    }  
                    break;
            }

            if (!NotDead)
            {
                IsDead();
            }

            return NotDead;
        }
        
        public bool Eat(int x, int y)
        {
            if(Body[Head].X == x & Body[Head].Y == y)
            {
                Size++;
                WriteLine("Your size: " + Size);
                return true;
            }
            return false;
        }

        public void IsDead()
        {
            Console.WriteLine("This is the end of your story");
        }
    }
}