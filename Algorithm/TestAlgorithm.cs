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
                return Move.Left;
            }
            else
            {
                return Move.Right;
            }
        }

        private Move MoveOY()
        {
            if (snakeHead.Y > locationFood.Y)
            {
                return Move.Down;
            }
            else
            {
                return Move.Up;
            }
        }
    }
}
