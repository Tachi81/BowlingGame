using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        List<Roll> _rolls;

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

        public int TotalScores()
        {
            int result = 0;
            int rollsCounterInFrame = 1;
            int frameCounter = 1;

            for (int i = 0; i < _rolls.Count; i++)
            {
                while (frameCounter < 10)
                {
                    if (IsStrike(i))
                    {
                        if (i < _rolls.Count - 2)
                        {
                            result += _rolls[i].KnockedPinsCount + _rolls[i + 1].KnockedPinsCount +
                                      _rolls[i + 2].KnockedPinsCount;
                            StartNextFrame(ref frameCounter, ref rollsCounterInFrame, ref i);

                        }
                    }
                    else if (IsSpare(i) && rollsCounterInFrame % 2 == 0)
                    {
                        result += _rolls[i].KnockedPinsCount + _rolls[i + 1].KnockedPinsCount;

                        StartNextFrame(ref frameCounter, ref rollsCounterInFrame, ref i);


                    }
                    else
                    {
                        result += _rolls[i].KnockedPinsCount;
                        if (rollsCounterInFrame % 2 == 0)
                        {
                            StartNextFrame(ref frameCounter, ref rollsCounterInFrame, ref i);
                        }
                        else
                        {
                            rollsCounterInFrame++;
                            i++;
                        }
                    }
                }

                while (frameCounter == 10)
                {
                    if (IsStrike(i) && rollsCounterInFrame == 1)
                    {
                        result += _rolls[i].KnockedPinsCount + _rolls[i + 1].KnockedPinsCount +
                                  _rolls[i + 2].KnockedPinsCount;
                        frameCounter++;
                        break;
                    }

                    if (IsSpare(i) && rollsCounterInFrame == 2)
                    {
                        result += _rolls[i].KnockedPinsCount + _rolls[i + 1].KnockedPinsCount;
                        frameCounter++;
                        break;
                    }

                    result += _rolls[i].KnockedPinsCount;
                    if (rollsCounterInFrame % 2 == 0)
                    {
                        frameCounter++;
                        break;
                    }
                    rollsCounterInFrame++;
                    i++;
                }
            }


            return result;
        }



        private void StartNextFrame(ref int frameCounter, ref int rollsCounter, ref int i)

        {
            frameCounter++;
            rollsCounter = 1;
            i++;
        }


        private bool IsStrike(int i)
        {
            return _rolls[i].KnockedPinsCount == 10;
        }


        private bool IsSpare(int i)
        {
            if (i > 0)
            {
                return _rolls[i].KnockedPinsCount + _rolls[i - 1].KnockedPinsCount == 10;
            }

            return false;
        }
    }
}
