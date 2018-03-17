using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class BowlinGameTests
    {
        private Game _game;

        [SetUp]
        public void Init()
        {
            _game = new Game();
        }
        

        [Test]
        public void Should_GutterGame_ScoreZero()
        {
            for (int i = 0; i < _game.MaxNumberOfRolls(); i++)
            {
                _game.Roll(0);
            }

            Assert.That(_game.TotalScores(), Is.EqualTo(0));
        }

        [Test]
        public void Should_AllOnes_Score20()
        {
            for (int i = 0; i < _game.MaxNumberOfRolls(); i++)
            {
                _game.Roll(1);
            }

            Assert.That(_game.TotalScores(), Is.EqualTo(20));
        }
    }
}
