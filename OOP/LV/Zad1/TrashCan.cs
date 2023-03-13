using System;
using System.Collections.Generic;
using System.Text;

namespace LV
{
    class TrashCan
    {
        private int capacity;
        private int amount;

        public TrashCan(int capacity)
        {
            this.capacity = capacity;
        }
        public int GetTrashCapacity()
        {
            return capacity;
        }
        public int GetTrashAmount()
        {
            return amount;
        }
        public void Insert(int amount)
        {
            this.amount = this.amount + amount;
        }
        public bool IsFull()
        {
            return amount >= capacity;
        }
        public void Empty()
        {
            amount = 0;
        }
    }
}
