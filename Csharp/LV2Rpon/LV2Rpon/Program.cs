using System;
using System.Collections.Generic;

namespace LV2Rpon
{
    public class Program
    {
        public static void PrintRollingResults(DiceRoller diceRoller)
        {
            IList<int> results = diceRoller.GetRollingResults();
            foreach(int result in results)
            {
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {

            //Testovi za 1,2,3 zadatak ->
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();
            int i;
            for(i = 0;i<20;i++)
            {
                //Ovo je komentirano za ZAD 1
                //diceRoller.InsertDie(new Die(6));
                //Ovo je komentirano za ZAD 2
                //diceRoller.InsertDie(new Die(6, randomGenerator));
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            Program.PrintRollingResults(diceRoller);

            //Test za 4 zadatak -> Napomena : logger u "diceRoller" je postavljen na ConsoleLogger, tako da ce ispisati na konzolu istu stvar ko i ovo gore za zad 1,2,3
            //diceRoller.LogRollingResults();

            //Test za 5 zadatak
            ConsoleLogger consoleLogger = new ConsoleLogger();
            //consoleLogger.Log(diceRoller);

            //Test za 6 i 7 Zadatak
            FlexibleDiceRoller flexibleDiceRoller = new FlexibleDiceRoller();
            for(i = 0;i<20;i++)
            {
                flexibleDiceRoller.InsertDie(new Die(6));
            }
            flexibleDiceRoller.RollAllDice();
            consoleLogger.Log(flexibleDiceRoller);
            flexibleDiceRoller.RemoveSideDie(6); // Sve kockice imaju 6 strana, predamo 6 i niti jedna kockica nebi trebala ostati u rolleru
            consoleLogger.Log(flexibleDiceRoller);

        }



    }
}
