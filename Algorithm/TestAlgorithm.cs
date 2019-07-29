namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using Common;
    using static System.Math;

    public class TestAlgorithm
    {
        private Point snakeHead;
        private Point locationFood;

        private Move lastMove;

        private Point nextStep;

        private List<Point> Body;

        private TestAlgorithm()
        {
        }

        private static TestAlgorithm testAlgorithmInstance = null;

        public static TestAlgorithm GetInstance()
        {
            if (testAlgorithmInstance == null)
            {
                testAlgorithmInstance = new TestAlgorithm();
            }

            return testAlgorithmInstance;
        }

        public static Move GetMove(List<Point> snakeBody, Point snakeHead, Point food)
        {
            var testAlgorithm = GetInstance();
            testAlgorithm.snakeHead = snakeHead ?? throw new Exception("Snake head is missing!");
            testAlgorithm.locationFood = food ?? throw new Exception("Food is missing!");
            testAlgorithm.Body = snakeBody;

            return testAlgorithm.MoveToThePoint();
        } 

        private Move MoveToThePoint()
        {
            if (Abs(snakeHead.X - locationFood.X) > Abs(snakeHead.Y - this.locationFood.Y))
            {
                return MoveOX();
            }
            else
            {
                return MoveOY();
            }
        }

        private Move MoveOX()
        {
            if (snakeHead.X > locationFood.X)
            {
                nextStep = snakeHead + MovePoint.GetPoint(Move.Left);

                if(lastMove != Move.Right && !Crashed())
                {
                    lastMove = Move.Left;
                    return Move.Left;
                }
            }
            else
            {
                nextStep = snakeHead + MovePoint.GetPoint(Move.Right);

                if(lastMove != Move.Left && !Crashed())
                {
                    lastMove = Move.Right;
                    return Move.Right;
                }
            }
            return MoveOY();
        }

        private Move MoveOY()
        {
            if (snakeHead.Y > locationFood.Y)
            {
                nextStep = snakeHead + MovePoint.GetPoint(Move.Down);

                if (lastMove != Move.Up && !Crashed())
                {
                    lastMove = Move.Down;
                    return Move.Down;
                }
            }
            else
            {
                nextStep = snakeHead + MovePoint.GetPoint(Move.Up);

                if(lastMove != Move.Down && !Crashed())
                {
                    lastMove = Move.Up;
                    return Move.Up;
                }
            }
            return MoveOX();
        }

        private bool Crashed()
        {
            return Body.IndexOf(nextStep) > 0;
        }
    }
}
