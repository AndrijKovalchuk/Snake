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

                    if (GameField[i, j] == "1") SnakeHead = new Point(j, i);
                    if (GameField[i, j] == "X") LocationFood = new Point(j, i);
                }
            }
        }

        public Move GetMove()
        {
            // if snake is missing
            if (SnakeHead.Equals(new Point()))
            {
                return Move.None;
            }

            // if food is missing
            if (LocationFood.Equals(new Point()))
            {
                if (MoveFromTheEdges() != Move.None)
                {
                    return MoveFromTheEdges();
                }
                else
                {
                    if (MoveAlongTheEdge() != Move.None)
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

        private Move MoveFromTheEdges()
        {
            if ((SnakeHead.X == 0) && (SnakeHead.Y == 0))
            {
                return Move.Right;
            }

            if ((SnakeHead.X == GameField.GetLength(0) - 1) && (SnakeHead.Y == 0))
            {
                return Move.Down;
            }

            if ((SnakeHead.X == GameField.GetLength(0) - 1) && (SnakeHead.Y == GameField.GetLength(1) - 1))
            {
                return Move.Left;
            }

            if ((SnakeHead.X == 0) && (SnakeHead.Y == GameField.GetLength(1) - 1))
            {
                return Move.Up;
            }

            return Move.None;
        }

        private Move MoveAlongTheEdge()
        {
            if (SnakeHead.X == 0)
            {
                return Move.Up;
            }

            if (SnakeHead.X == GameField.GetLength(0) - 1)
            {
                return Move.Down;
            }

            if (SnakeHead.Y == 0)
            {
                return Move.Right;
            }

            if (SnakeHead.Y == GameField.GetLength(1) - 1)
            {
                return Move.Left;
            }

            return Move.None;
        }

        private Move MoveToTheEdge()
        {
            var DistanceTheRightEdge = GameField.GetLength(0) - 1 - SnakeHead.X;
            var DistanceTheDownEdge = GameField.GetLength(1) - 1 - SnakeHead.Y;

            if (SnakeHead.X > DistanceTheRightEdge)
            {
                if (SnakeHead.Y > DistanceTheDownEdge)
                {
                    if (DistanceTheRightEdge > DistanceTheDownEdge)
                    {
                        return Move.Down;
                    }
                    else
                    {
                        return Move.Right;
                    }
                }
                else
                {
                    if (DistanceTheRightEdge > SnakeHead.Y)
                    {
                        return Move.Up;
                    }
                    else
                    {
                        return Move.Right;
                    }
                }                    
            }
            else
            {
                if (SnakeHead.Y > DistanceTheDownEdge)
                {
                    if (SnakeHead.X > DistanceTheDownEdge)
                    {
                        return Move.Down;
                    }
                    else
                    {
                        return Move.Left;
                    }
                }
                else
                {
                    if (SnakeHead.X > SnakeHead.Y)
                    {
                        return Move.Up;
                    }
                    else
                    {
                        return Move.Left;
                    }
                }
            }
        }

        private Move MoveToThePoint()
        {
            if (SnakeHead.X == LocationFood.X)
            {
                if (SnakeHead.Y > LocationFood.Y)
                {
                    return Move.Up;
                }
                else
                {
                    return Move.Down;
                }
            }

            if (SnakeHead.Y == LocationFood.Y)
            {
                if (SnakeHead.X > LocationFood.X)
                {
                    return Move.Left;
                }
                else
                {
                    return Move.Right;
                }
            }

            if (SnakeHead.X > LocationFood.X)
            {
                if (SnakeHead.Y > LocationFood.Y)
                {
                    if(SnakeHead.X - LocationFood.X > SnakeHead.Y - LocationFood.Y)
                    {
                        return Move.Up;
                    }
                    else
                    {
                        return Move.Left;
                    }
                }
                else
                {
                    if (SnakeHead.X - LocationFood.X > LocationFood.Y - SnakeHead.Y)
                    {
                        return Move.Down;
                    }
                    else
                    {
                        return Move.Left;
                    }
                }
            }
            else
            {
                if (SnakeHead.Y > LocationFood.Y)
                {
                    if (LocationFood.X - SnakeHead.X > SnakeHead.Y - LocationFood.Y)
                    {
                        return Move.Up;
                    }
                    else
                    {
                        return Move.Right;
                    }
                }
                else
                {
                    if (LocationFood.X - SnakeHead.X > LocationFood.Y - SnakeHead.Y)
                    {
                        return Move.Down;
                    }
                    else
                    {
                        return Move.Right;
                    }
                }
            }
        }
    }
}
