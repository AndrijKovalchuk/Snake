using System;
using static System.Console;
using System.Collections.Generic;
using Common;

namespace Logic
{
    public class Snake
    {
        public int Size { get; private set; }
        public Point Head{ get; private set; }
        public List<Point> Body = new List<Point>();
        
        public Snake(int x, int y)
        {
            Point point = new Point(x,y,StatePoint.snakeBody);
            Body.Add(point);
            Size = 1;
            Head = new Point(x, y, StatePoint.snakeHead);
        }
        
        public bool TryStep(Move direction, int size)
        {
            bool NotDead = true;
            WriteLine(Body[0].X);

            switch (direction)
            {
                case Move.Left:
                    if(Body[Body.Count - 1].X > 0)
                    {
                        Point pointL = new Point(Body[Body.Count - 1].X - 1, Body[Body.Count - 1].Y, StatePoint.snakeBody);
                        Body.Add(pointL);
                        Body.RemoveAt(0);
                        Head = pointL;
                        NotDead = true;
                    }
                    else
                    {
                        NotDead = false;
                    }  
                    break;

                case Move.Right:
                    if(Body[Body.Count - 1].X < (size - 1))
                    {
                        WriteLine(Body[0].X);
                        Point pointR = new Point(Body[0].X+1, Body[Body.Count-1].Y, StatePoint.snakeBody);
                        Body.Add(pointR);
                        Body.RemoveAt(0);
                        WriteLine(Body[0].X);
                        Head = pointR;
                        NotDead = true;
                    }  
                    else
                    {
                        NotDead = false;
                    }                       
                    break;

                case Move.Down:
                    if(Body[Body.Count - 1].Y > 0)
                    {
                        Point pointD = new Point(Body[Body.Count - 1].X, Body[Body.Count - 1].Y - 1, StatePoint.snakeBody);
                        Body.Add(pointD);
                        Body.RemoveAt(0);
                        Head = pointD;
                        NotDead = true;
                    }
                    else
                    {
                        NotDead = false;
                    }  
                    break;

                case Move.Up:
                    if (Body[Body.Count - 1].Y < (size - 1))
                    {
                        Point pointU = new Point(Body[Body.Count - 1].X, Body[Body.Count - 1].Y + 1, StatePoint.snakeBody);
                        Body.Add(pointU);
                        Body.RemoveAt(0);
                        Head = pointU;
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
            if(Head.X == x & Head.Y == y)
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