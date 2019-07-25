using NUnit.Framework;
using Common;
using Logic;

namespace Tests
{
    public class TestSnake
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReverseMovement()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            snake.SetMove(Move.Down);
            Assert.That(snake.IsReverseMovement(), Is.EqualTo(true));

            snake = null;
        }

        [Test]
        public void TestIsCrashed()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            snake.SetMove(Move.Left);
            snake.SetMove(Move.Left);
            snake.SetMove(Move.Left);
            snake.SetMove(Move.Left);
            Assert.That(snake.IsCrashed(), Is.EqualTo(true));

            snake = null;
        }

        [Test]
        public void TestMoveIsEat()
        {
            Snake snake = new Snake(new Point(1, 1), Move.Up);

            snake.SetMove(Move.Up);
            Assert.That(snake.MoveIsEat(new Point(1, 2)), Is.EqualTo(true));
        }
    }
}