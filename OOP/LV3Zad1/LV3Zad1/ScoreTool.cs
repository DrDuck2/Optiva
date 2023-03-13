using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad1
{
    public class ScoreTool
    {
        private int scoreCount;

        public ScoreTool(int scoreCount)
        {
            this.scoreCount = scoreCount;
        }

        public virtual int ScoreCounter(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                scoreCount += word[i].Length;
            }
            return scoreCount;
        }
    }
}
