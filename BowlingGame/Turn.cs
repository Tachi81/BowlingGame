using System.Collections.Generic;

namespace BowlingGame
{
    public class Turn
    {
        public int PinsStanding;
        public int TurnScore;
        public List<Roll> RollsInThisTurn;
        public Turn()
        {
            PinsStanding = 10;
            RollsInThisTurn = new List<Roll>();
        }
        
    }
}