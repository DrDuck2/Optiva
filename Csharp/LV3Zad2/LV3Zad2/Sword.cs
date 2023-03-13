using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad2
{
    public class Sword : Item
    {
        private double strenght;

        public double Strenght
        {
            get { return strenght; }
            set { strenght = value; }
        }


        public Sword(double strenght,string name, double weight, double valueGold) : base(name,weight,valueGold)
        { 
            this.strenght = strenght;
        }

        public override string ToString()
        {
            return $"Type : Sword {base.ToString()}";
        }
    }
}
