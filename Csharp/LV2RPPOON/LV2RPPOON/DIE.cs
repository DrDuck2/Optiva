using System;
using System.Collections.Generic;
using System.Text;

namespace LV2RPPOON
{
    class Die   
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            return randomGenerator.NextInt(1, numberOfSides + 1);
        }
        public int GetNumberOfSides()
        {
            return numberOfSides;
        }
    }
}
