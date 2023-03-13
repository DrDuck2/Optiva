using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Ispit2019_3
{
    class SolarPanel
    {
        protected double mWidth;
        protected double mHeight;
        protected double mEfficiency;

        public SolarPanel()
        {
            this.mWidth = 0;
            this.mEfficiency = 0;
        }
        public SolarPanel(double mWidth,double mHeight,double mEfficiency)
        {
            this.mWidth = mWidth;
            this.mHeight = mHeight;
            this.mEfficiency = mEfficiency;
        }

        public override string ToString()
        {
            return $"Width: {this.mWidth}, Height: {this.mHeight}, Efficiency: {this.mEfficiency}";
        }

        public virtual double YearlyEnergy()
        {
            return this.mWidth * this.mHeight * this.mEfficiency * 1300;
        }

        public double YearlyProfit(double cijena)
        {
            return cijena * YearlyEnergy();
        }

        public double YearlyProfit(SolarPanel[] paneli,double cijena)
        {
            double profit = 0;
            for (int i = 0; i < paneli.Length-1; i++)
            {
                profit += paneli[i].YearlyProfit(cijena);
            }
            return profit;
        }

        public static void WhoBetter(SolarPanel panel1, SolarPanel panel2)
        {
            using (StreamWriter writer = new StreamWriter("DominikVidovic.Txt"))
            {
                if (panel1.YearlyEnergy() > panel2.YearlyEnergy())
                {
                    writer.WriteLine($"{panel1}, YearlyEnergy: {panel1.YearlyEnergy()}");
                }
                else if (panel1.YearlyEnergy() < panel2.YearlyEnergy())
                {
                    writer.WriteLine($"{panel2}, YearlyEnergy: {panel2.YearlyEnergy()}");
                }
                else writer.WriteLine("Panel1 and Panel2 are the same!");
            }
            using (StreamReader sr = new StreamReader("DominikVidovic.txt"))
            {
                string line;
                while((line = sr.ReadLine())!= null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
