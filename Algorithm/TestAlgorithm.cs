using System;
using System.Collections.Generic;
using Common;
using static System.Math;

namespace Algorithm
{
    public class TestAlgorithm
    {
        private Point SnakeHead;
        private Point LocationFood;
        private TestAlgorithm() { }

        private static TestAlgorithm _testAlgorithmInstance = null;
        public static TestAlgorithm GetInstance()
        {
            if (_testAlgorithmInstance == null)
            {
                _testAlgorithmInstance = new TestAlgorithm();
            }
            return _testAlgorithmInstance;
        }

        public static Move GetMove(List<Point> SnakeBody, Point SnakeHead, Point Food)
        {
            var TestAlgorithm = GetInstance();
            TestAlgorithm.SnakeHead = SnakeHead ?? throw new Exception("Snake head is missing!");
            TestAlgorithm.LocationFood = Food ?? throw new Exception("Food is missing!");

            return TestAlgorithm.MoveToThePoint();
        }

        private Move MoveToThePoint()
        {
            if (Abs(SnakeHead.X - LocationFood.X) > Abs(SnakeHead.Y - LocationFood.Y))
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
            if (SnakeHead.X > LocationFood.X)
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
            if (SnakeHead.Y > LocationFood.Y)
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
