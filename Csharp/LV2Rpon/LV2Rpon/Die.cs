using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    public class Die
    {
        private int sides;
        //Ovo je bilo potrebno u ZAD 1 i ZAD 2, ali nije potrebno u ZAD 3
        //private Random randomGenerator;

        // Ovo je komentirano za ZAD 1
        //public Die(int sides)
        //{
        //this.sides = sides;
        //this.randomGenerator = new Random();
        //}

        // Ovo je komentirano za ZAD 2
        //public Die(int sides,Random randomGenerator)
        //{
            //this.sides = sides;
            //this.randomGenerator = randomGenerator;
        //}

        public Die(int sides)
        {
            this.sides = sides;
        }
        // Ovo je bilo potrebno u ZAD 1 i ZAD 2
        //public int Roll()
        //{
             //return randomGenerator.Next(1, sides + 1);

        //}

        public int Roll()
        {
            return RandomGenerator.GetInstance().NextInt(1, 7);
        }

        public int GetSides()
        {
            return this.sides;
        }

    }
}
