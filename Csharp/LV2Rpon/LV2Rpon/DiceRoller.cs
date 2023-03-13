using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    public class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> rollResults;
        private ILogger logger;
        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.rollResults = new List<int>();
            this.logger = new ConsoleLogger();
        }

        public void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void ClearResults()
        {
            this.rollResults.Clear();
        }
        public void RollAllDice()
        {
            foreach (Die die in dice)
            {
                this.rollResults.Add(die.Roll());
            }
        }
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.rollResults);
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }

        public string GetStringRepresentation()
        {
            return string.Join("\n", rollResults);
        }
        //Ovo je bilo potrebno za Zad 4
        //public void LogRollingResults()
        //{
        //foreach (int result in this.rollResults)
        //{
        //logger.Log(result.ToString());
        //}
        //}

    }
}
