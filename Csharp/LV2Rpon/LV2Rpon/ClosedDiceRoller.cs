using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    public class ClosedDiceRoller : IRoller,ILogable
    {
        private List<Die> dice;
        private List<int> rollResults;
        public ClosedDiceRoller(int diceCount, int sides)
        {
            this.dice = new List<Die>();
            for (int i = 0; i < diceCount; i++)
            {
                this.dice.Add(new Die(sides));
            }
            this.rollResults = new List<int>();
        }
        public string GetStringRepresentation()
        {
            return string.Join("\n", rollResults);
        }

        public void ClearResults()
        {
            this.rollResults.Clear();
        }
        public void RollAllDice()
        {
            ClearResults();
            foreach (Die die in dice)
            {
                this.rollResults.Add(die.Roll());
            }
        }
    }
}
