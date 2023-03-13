using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    public class FlexibleDiceRoller : IRoller,IDiceManager,ILogable
    {
        private List<Die> dice;
        private List<int> rollResult;

        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.rollResult = new List<int>();
        }
        public void RollAllDice()
        {
            ClearResults();
            foreach(Die die in dice)
            {
                this.rollResult.Add(die.Roll());
            }
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void ClearDice()
        {
            dice.Clear();
        }
        public void ClearResults()
        {
            rollResult.Clear();
        }
        public void RemoveAllDice()
        {
            ClearDice();
            ClearResults();
        }


        public string GetStringRepresentation()
        {
            return string.Join("\n", rollResult);
        }

        public void RemoveSideDie(int side)
        {
            for(int i=dice.Count-1;i>0;i--)
            {
                if(dice[i].GetSides() == side)
                {
                    dice.Remove(dice[i]);
                }
            }
        }
    }
}
