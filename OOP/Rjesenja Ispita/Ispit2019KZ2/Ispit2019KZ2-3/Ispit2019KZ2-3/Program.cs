using System;

namespace Ispit2019KZ2_3
{
    class Program
    {
        public static Enemy[] CreateEnemies(int n)
        {
            Enemy[] enemy = new Enemy[n];
            Random gen = new Random();
            for (int i = 0; i < enemy.Length; i++)
            {
                try
                {
                    enemy[i] = new ArmoredEnemy(gen.NextDouble(), gen.Next(0, 100), $"Enemy{i + 1}", gen.Next(0, 100));
                }
                catch(IllegalEnemyException e)
                {
                    Console.WriteLine($"Name: {e.getmName}, Health: {e.getmHealth}, AttackDamage: {e.getmAttackDamage}, {e.Message}");
                    i--;
                }
            }
            return enemy;
        }

        public static int runBattle(Enemy[] group1, Enemy[] group2)
        {
            int group1SurvivedCounter = group1.Length;
            int group2SurivedCounter = group2.Length;
            if(group1.Length != group2.Length)
            {
                Console.WriteLine("Not fair!");
                return 0;
            }
            Random gen = new Random();
            for (int i = 0; i < group1.Length; i++)
            {
                group2[gen.Next(0, group2.Length - 1)].takeDamage(group1[i].getAttackDamage);
                group1[gen.Next(0, group1.Length - 1)].takeDamage(group2[i].getAttackDamage);
            }
            for (int i = 0; i < group1.Length; i++)
            {
                if(group1[i].getHealth == 0)
                {
                    group1SurvivedCounter--;
                }
                if(group2[i].getHealth == 0)
                {
                    group2SurivedCounter--;
                }
            }
            if (group1SurvivedCounter > group2SurivedCounter)
            {
                return 1;
            }
            else if (group1SurvivedCounter < group2SurivedCounter)
            {
                return 2;
            }
            else return 0;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj enemya: ");
            int n = int.Parse(Console.ReadLine());
            Enemy[] enemy = CreateEnemies(n);
            Enemy[] enemy2 = CreateEnemies(n);

            Console.Write($"And the winner is: {runBattle(enemy, enemy2)}");


        }
    }
}
