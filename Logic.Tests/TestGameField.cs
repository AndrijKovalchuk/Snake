using NUnit.Framework;
using Common;
using Logic;

namespace Tests
{
    public class TestGameField
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMakeMove()
        {
            GameField gameField = new GameField();

            gameField.MakeMove(Move.Left);
            Assert.That(gameField.Status, Is.EqualTo(GameStatus.Play));

            //Turn left again, snake have to dead
            gameField.MakeMove(Move.Left);
            Assert.That(gameField.Status, Is.EqualTo(GameStatus.GameOver));
            
            //Clear gameField
            gameField = null;
            gameField = new GameField();

            gameField.MakeMove(Move.Right);
            Assert.That(gameField.Status, Is.EqualTo(GameStatus.Play));

            gameField.MakeMove(Move.Left);
            Assert.That(gameField.Status, Is.EqualTo(GameStatus.GameOver));
        }
    }
}