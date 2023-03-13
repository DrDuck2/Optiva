using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ2
{
    class Money
    {
        private int mAmount;
        public int getAmount
        {
            get { return this.mAmount; }
        }
        public Money(int mAmount)
        {
            this.mAmount = mAmount;
        }

        public static int[] MoneyToString(Money[] money)
        {
            int[] integer = new int[money.Length];
            for (int i = 0; i < money.Length; i++)
            {
                integer[i] = money[i].getAmount;
            }
            return integer;
        }
    }
}
