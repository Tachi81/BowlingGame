using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private List<Roll> _rolls;

        public Game()
        {
            _rolls = new List<Roll>();
        }

        public void Roll(int pins)
        {
            _rolls.Add(new Roll()
            {
                KnockedPinsCount = pins
            });
        }

        public int MaxNumberOfRolls()
        {
            return 1;
        }

        public int TotalScores()
        {
            return _rolls.Sum(r=>r.KnockedPinsCount);
        }
    }
}
