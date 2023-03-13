using System;
using System.Collections.Generic;

namespace LV2RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceroller = new DiceRoller();
            Random randomGenerator = new Random();
            for(int i = 0;i<20;i++)
            {
                diceroller.InsertDie(new Die(6));
            }
            diceroller.RollAllDice();
            foreach(int integer in diceroller.GetRollingResults())
            {
                Console.WriteLine(integer);
            }
        }
    }
}
