

namespace Tests
{
    using NUnit.Framework;
    using Common;
    using Logic;
    
    [TestFixture]
    public class GameFieldTest
    {
        [SetUp]
        public void Setup()
        {            
        }

        [Test]
        public void MakeMove_Left_Play()
        {
            GameField gameField = new GameField();

            gameField.MakeMove(Move.Left);

            Assert.That(gameField.Status, Is.EqualTo(GameStatus.Play));
        }

        [Test]
        public void MakeMove_Right_Play()
        {
            GameField gameField = new GameField();

            gameField.MakeMove(Move.Right);

            Assert.That(gameField.Status, Is.EqualTo(GameStatus.Play));
        }

        [Test]
        public void MakeMove_RightThenLeft_GameOver()
        {
            GameField gameField = new GameField();

            gameField.MakeMove(Move.Right);
            gameField.MakeMove(Move.Left);

            Assert.That(gameField.Status, Is.EqualTo(GameStatus.GameOver));
        }
    }
}