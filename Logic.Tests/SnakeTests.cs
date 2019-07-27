using NUnit.Framework;
using Common;
using Logic;

namespace Tests
{
    public class SnakeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsReverseMovement_UpThenDown_True()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            snake.SetMove(Move.Up);
            snake.MoveIsEat(new Point(1, 10));
            snake.SetMove(Move.Down);
            
            Assert.That(snake.IsReverseMovement(), Is.True);
        }

        [Test]
        public void IsReverseMovement_UpThenRight_False()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            snake.SetMove(Move.Up);
            snake.MoveIsEat(new Point(1, 10));
            snake.SetMove(Move.Right);
            
            Assert.That(snake.IsReverseMovement(), Is.False);
        }

        [Test]
        public void MoveIsEat_From1_1to1_2_True()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            snake.SetMove(Move.Up);
            
            Assert.That(snake.MoveIsEat(new Point(1, 2)), Is.True);
        }

        [Test]
        public void MoveIsEat_From1_1to1_10_False()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            Assert.That(snake.MoveIsEat(new Point(1, 10)), Is.False);
        }

        [Test]
        public void IsCrashed_Size4TurnRight4Times_False()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);          

            //Snake eat 3 times, she has size: 4
            for(int i = 2; i < 5; i++)
            {
                snake.SetMove(Move.Up);
                snake.MoveIsEat(new Point(1, i));
            }

            //Turn 3th times, on 3rd time doesn't have to dead
            snake.SetMove(Move.Right);
            snake.MoveIsEat(new Point(1, 100));
            snake.SetMove(Move.Down);
            snake.MoveIsEat(new Point(1, 100));
            snake.SetMove(Move.Left);           
            
            TestContext.Out.WriteLine("Snake's coordinates:");
            TestContext.Out.WriteLine(snake.Body[0].X + " " + snake.Body[0].Y);
            TestContext.Out.WriteLine(snake.Body[1].X + " " + snake.Body[1].Y);
            TestContext.Out.WriteLine(snake.Body[2].X + " " + snake.Body[2].Y);
            TestContext.Out.WriteLine(snake.Body[3].X + " " + snake.Body[3].Y);

            Assert.That(snake.IsCrashed(), Is.False);
        }
    }
}