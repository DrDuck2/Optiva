using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class Box : IShipable //,IBillable
    {
        //private List<IBillable> items;
        private List<IShipable> items;
        private string name;

        //public Box(string name)
        //{
        //this.items = new List<IBillable>();
        //this.name = name;
        //}

        public Box(string name)
        {
            this.items = new List<IShipable>();
            this.name = name;
        }

        //public void Add(IBillable item)
        //{
        //items.Add(item);
        //}
        public void Add(IShipable item)
        {
            items.Add(item);
        }

        //public void Remove(IBillable item)
        //{
        //items.Remove(item);
        //
        public void Remove(IShipable item)
        {
            items.Remove(item);
        }
        //public double Price 
        //{
            //get { double totalPrice = 0;
                //foreach(IBillable item in items)
                //{
                    //totalPrice += item.Price;
                //}
                //return totalPrice;
            //}
        //}


        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IShipable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }
        public double Weight
        {
            get { double totalWeight = 0;
                foreach(IShipable item in items)
                {
                    totalWeight += item.Weight;
                }
                return totalWeight;
            }
        }
        //public string Description(int depth = 0)
        //{
            //StringBuilder builder = new StringBuilder(new string(' ', depth) + this.name + "\n");
            //foreach(IBillable item in items)
            //{
                //builder.Append(item.Description(depth + 2)).Append("\n");
            //}
            //return builder.ToString();
        //}

        public string Description(int depth = 0)
        {
            StringBuilder builder = new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IShipable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }
    }
}
