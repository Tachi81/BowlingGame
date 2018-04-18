using NUnit.Framework;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class BowlingGameTests
    {
        private Game _game;

        [SetUp]
        public void Init()
        {
            _game = new Game();
        }

        [Test]
        public void Should_GutterGame_ScoresZero()
        {
            for (int i = 0; i < 20; i++)
            {

                _game.Roll(0);
            }
            Assert.That(_game.TotalScores(), Is.EqualTo(0));
        }

        [Test]
        public void Should_AllOnes_ScoresTwenty()
        {
            for (int i = 0; i < 20; i++)
            {

                _game.Roll(1);
            }
            Assert.That(_game.TotalScores(), Is.EqualTo(20));
        }

        [Test]
        public void Should_SparePlusThree_Score16()
        {
            // spare in first frame
            _game.Roll(4);
            _game.Roll(6);
            // 3 in second frame and then all gutters
            _game.Roll(3);
            for (int i = 0; i < 17; i++)
            {
                _game.Roll(0);
            }
            Assert.That(_game.TotalScores(), Is.EqualTo(16));
        }
        [Test]
        public void Should_StrikePlusThreeAndFour_Score24()
        {
            // strike in first frame
            _game.Roll(10);

            // 3 and 4 in second frame and then all gutters
            _game.Roll(3);
            _game.Roll(4);

            for (int i = 0; i < 17; i++)
            {
                _game.Roll(0);
            }
            Assert.That(_game.TotalScores(), Is.EqualTo(24));
        }

        [Test]
        public void Should_PerfectGame_Score300()
        {


            for (int i = 0; i < 12; i++)
            {
                _game.Roll(10);
            }
            Assert.That(_game.TotalScores(), Is.EqualTo(300));
        }

        [Test]
        public void Should_ZeroPlus7Plus3Plus5_Score15()
        {
            // first turn
            _game.Roll(0);
            _game.Roll(7);
            // second turn
            _game.Roll(3);
            _game.Roll(5);
            for (int i = 0; i < 17; i++)
            {
                _game.Roll(0);
            }

            Assert.That(_game.TotalScores(), Is.EqualTo(15));
        }

    }
}
