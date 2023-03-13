using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad1
{
    public class CharCounter : ScoreTool
    {

        private int scoreCount;
        private int vowelsPoints;
        private int consonantsPoints;

        public CharCounter(int scoreCount, int vowelsPoints,int consonantsPoints) :  base(scoreCount)
        {
            this.scoreCount = scoreCount;
            this.vowelsPoints = vowelsPoints;
            this.consonantsPoints = consonantsPoints;
        }
        public override int ScoreCounter(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                foreach (char c in word[i])
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        scoreCount += vowelsPoints;
                    }
                    else
                    {
                        scoreCount += consonantsPoints;
                    }
                }
            }
            return scoreCount;
        }
    }
}
