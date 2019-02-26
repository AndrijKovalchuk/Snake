using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Algorithm1 : UserAlgorithm
    {
        private string[,] GameField;
        private Point SnakeHead = new Point();
        private Point LocationFood = new Point();

        public void SetGameField(char[,] Field)
        {
            GameField = new string[Field.GetLength(0), Field.GetLength(1)];

            for(var i = 0; i < Field.GetLength(0); i++)
            {
                for(var j = 0; j < Field.GetLength(1); j++)
                {
                    GameField[i, j] = Field[i, j].ToString();

                    if (GameField[i, j] == "1") SnakeHead = new Point(i, j);
                    if (GameField[i, j] == "X") LocationFood = new Point(i, j);
                }
            }
        }

        public char GetMove()
        {
            // if snake is missing
            if (SnakeHead.Equals(new Point()))
            {
                return 's';
            }

            // if food is missing
            if (LocationFood.Equals(new Point()))
            {
                if (MoveFromTheEdges() != 's')
                {
                    return MoveFromTheEdges();
                }
                else
                {
                    if (MoveAlongTheEdge() != 's')
                    {
                        return MoveAlongTheEdge();
                    }
                    else
                    {
                        return MoveToTheEdge();
                    }
                }
            }
            
            return MoveToThePoint();
        }

        private char MoveFromTheEdges()
        {
            if ((SnakeHead.X == 0) && (SnakeHead.Y == 0))
            {
                return 'r';
            }

            if ((SnakeHead.X == GameField.GetLength(0) - 1) && (SnakeHead.Y == 0))
            {
                return 'd';
            }

            if ((SnakeHead.X == GameField.GetLength(0) - 1) && (SnakeHead.Y == GameField.GetLength(1) - 1))
            {
                return 'l';
            }

            if ((SnakeHead.X == 0) && (SnakeHead.Y == GameField.GetLength(1) - 1))
            {
                return 'u';
            }

            return 's';
        }

        private char MoveAlongTheEdge()
        {
            if (SnakeHead.X == 0)
            {
                return 'u';
            }

            if (SnakeHead.X == GameField.GetLength(0) - 1)
            {
                return 'd';
            }

            if (SnakeHead.Y == 0)
            {
                return 'r';
            }

            if (SnakeHead.Y == GameField.GetLength(1) - 1)
            {
                return 'l';
            }

            return 's';
        }

        private char MoveToTheEdge()
        {
            var DistanceTheRightEdge = GameField.GetLength(0) - 1 - SnakeHead.X;
            var DistanceTheDownEdge = GameField.GetLength(1) - 1 - SnakeHead.Y;

            if (SnakeHead.X > DistanceTheRightEdge)
            {
                if (SnakeHead.Y > DistanceTheDownEdge)
                {
                    if (DistanceTheRightEdge > DistanceTheDownEdge)
                    {
                        return 'd';
                    }
                    else
                    {
                        return 'r';
                    }
                }
                else
                {
                    if (DistanceTheRightEdge > SnakeHead.Y)
                    {
                        return 'u';
                    }
                    else
                    {
                        return 'r';
                    }
                }                    
            }
            else
            {
                if (SnakeHead.Y > DistanceTheDownEdge)
                {
                    if (SnakeHead.X > DistanceTheDownEdge)
                    {
                        return 'd';
                    }
                    else
                    {
                        return 'l';
                    }
                }
                else
                {
                    if (SnakeHead.X > SnakeHead.Y)
                    {
                        return 'u';
                    }
                    else
                    {
                        return 'l';
                    }
                }
            }
        }

        private char MoveToThePoint()
        {
            if (SnakeHead.X == LocationFood.X)
            {
                if (SnakeHead.Y > LocationFood.Y)
                {
                    return 'u';
                }
                else
                {
                    return 'd';
                }
            }

            if (SnakeHead.Y == LocationFood.Y)
            {
                if (SnakeHead.X > LocationFood.X)
                {
                    return 'l';
                }
                else
                {
                    return 'r';
                }
            }

            if (SnakeHead.X > LocationFood.X)
            {
                if (SnakeHead.Y > LocationFood.Y)
                {
                    if(SnakeHead.X - LocationFood.X > SnakeHead.Y - LocationFood.Y)
                    {
                        return 'u';
                    }
                    else
                    {
                        return 'l';
                    }
                }
                else
                {
                    if (SnakeHead.X - LocationFood.X > LocationFood.Y - SnakeHead.Y)
                    {
                        return 'd';
                    }
                    else
                    {
                        return 'l';
                    }
                }
            }
            else
            {
                if (SnakeHead.Y > LocationFood.Y)
                {
                    if (LocationFood.X - SnakeHead.X > SnakeHead.Y - LocationFood.Y)
                    {
                        return 'u';
                    }
                    else
                    {
                        return 'r';
                    }
                }
                else
                {
                    if (LocationFood.X - SnakeHead.X > LocationFood.Y - SnakeHead.Y)
                    {
                        return 'd';
                    }
                    else
                    {
                        return 'r';
                    }
                }
            }
        }
    }
}
