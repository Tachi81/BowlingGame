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
            for (int i = 0; i < 10; i++)
            {
                _game.Roll(0);
            }

            var score = _game.TotalScores();

            Assert.That(score, Is.EqualTo(0));
        }
    }
}
