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
        private List<Turn> _turns;

        public Game()
        {
            _rolls = new List<Roll>();
            _turns = new List<Turn>();
        }

        public void Roll(int pins)
        {
            if (!_turns.Any()|| _turns.Last().RollsInThisTurn.Count == 2)
            {
                _turns.Add(new Turn());
            }

            if (_turns.Last().RollsInThisTurn.Count == 2 && _turns.Count ==9)
            {
                
            }
            
            var roll= new Roll()
            {
                KnockedPinsCount = pins
            };
            _turns.Last().RollsInThisTurn.Add(roll);
            _rolls.Add(roll);
        }

        public int MaxNumberOfRolls()
        {
            return 20;
        }

        public int TotalScores()
        {
            return _rolls.Sum(r=>r.KnockedPinsCount);
        }
    }
}
