using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad2
{
    public class Item
    {
        private string name;
        private double weight;
        private double valueGold;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double ValueGold
        {
            get { return valueGold; }
            set { valueGold = value; }
        }

        public  Item(string name,double weight,double valueGold)
        {
            this.name = name;
            this.weight = weight;
            this.valueGold = valueGold;
        }
        

        public override string ToString()
        {

            return $"Name : {name}";
        }

        public static double ValueAverage(Item[] items)
        {
            double avg = 0;
            for (int i = 0; i <items.Length ; i++)
            {
                avg += items[i].ValueGold;
            }
            avg /= items.Length;
            return avg;
        }
    }
}
