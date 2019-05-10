namespace Logic
{
    using System;
    using System.Collections.Generic;
    using Common;
    using static System.Console;

    public class Snake
    {
        public int Size { get; private set; }

        public Point Head{ get; private set; }

        public List<Point> Body = new List<Point>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Snake"/> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Snake(int x, int y)
        {
            Point point = new Point(x, y, StatePoint.SnakeBody);
            Body.Add(point);
            Size = 1;
            Head = new Point(x, y, StatePoint.SnakeHead);
        }

        public bool TryStep(Move direction, int size)
        {
            bool notDead = true;
            WriteLine(Body[0].X);

            switch (direction)
            {
                case Move.Left:
                    if (Body[Body.Count - 1].X > 0)
                    {
                        Point pointL = new Point(Body[Body.Count - 1].X - 1, Body[Body.Count - 1].Y, StatePoint.SnakeBody);
                        Body.Add(pointL);
                        Body.RemoveAt(0);
                        Head = pointL;
                        notDead = true;
                    }
                    else
                    {
                        notDead = false;
                    }

                    break;

                case Move.Right:
                    if (Body[Body.Count - 1].X < (size - 1))
                    {
                        WriteLine(Body[0].X);
                        Point pointR = new Point(Body[0].X+1, Body[Body.Count-1].Y, StatePoint.SnakeBody);
                        Body.Add(pointR);
                        Body.RemoveAt(0);
                        WriteLine(Body[0].X);
                        Head = pointR;
                        notDead = true;
                    }
                    else
                    {
                        notDead = false;
                    }

                    break;

                case Move.Down:
                    if (Body[Body.Count - 1].Y > 0)
                    {
                        Point pointD = new Point(Body[Body.Count - 1].X, Body[Body.Count - 1].Y - 1, StatePoint.SnakeBody);
                        Body.Add(pointD);
                        Body.RemoveAt(0);
                        Head = pointD;
                        notDead = true;
                    }
                    else
                    {
                        notDead = false;
                    }

                    break;

                case Move.Up:
                    if (Body[Body.Count - 1].Y < (size - 1))
                    {
                        Point pointU = new Point(Body[Body.Count - 1].X, Body[Body.Count - 1].Y + 1, StatePoint.SnakeBody);
                        Body.Add(pointU);
                        Body.RemoveAt(0);
                        Head = pointU;
                        notDead = true;
                    }
                    else
                    {
                        notDead = false;
                    }

                    break;
            }

            if (!notDead)
            {
                IsDead();
            }

            return notDead;
        }

        public bool Eat(int x, int y)
        {
            if (Head.X == x & Head.Y == y)
            {
                Size++;
                return true;
            }

            return false;
        }

        public void IsDead()
        {
            WriteLine("This is the end of your story");
        }
    }
}