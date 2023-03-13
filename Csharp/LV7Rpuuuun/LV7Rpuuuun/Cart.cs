using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class Cart
    {
        private List<IItem> items;

        public Cart()
        {
            items = new List<IItem>();
        }

        public void Add(IItem item)
        {
            items.Add(item);
        }
        public void Remove(IItem item)
        {
            items.Remove(item);
        }

        public double Accept(IVisitor visitor)
        {
            double cartPrice = 0;
            foreach(IItem item in items)
            {
                cartPrice += item.Accept(visitor);
            }
            return cartPrice;
        }
    }
}
