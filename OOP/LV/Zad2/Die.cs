using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
    class Die
    {
        Random generator = new Random();
        private int side = 1;
        public int SetDieSide (int side)
        {
            if(side!=0)
            {
                this.side = side;
            }
            return this.side;
        }
        public int GetDieSide()
        {
            return side;
        }
        public int DieThrow(int side)
        {
            if(side!=0)
            {
                this.side = generator.Next(1, 6);
            }
            return this.side;
        }
    }
}
