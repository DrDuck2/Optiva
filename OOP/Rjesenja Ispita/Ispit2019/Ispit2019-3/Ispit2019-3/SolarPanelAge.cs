using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019_3
{
    class SolarPanelAge : SolarPanel
    {
        private double faktorStarenja;
        private int age;

        public SolarPanelAge(double faktorStarenja,int age, double mWidth, double mHeight, double mEfficiency) : base(mWidth,mHeight,mEfficiency)
        {
            this.faktorStarenja = faktorStarenja;
            this.age = age;
        }

        public void AddAge()
        {
            this.age++;
        }

        public override double YearlyEnergy()
        {
            double efficiencyHolder = this.mEfficiency;
            efficiencyHolder -= this.faktorStarenja * this.age;
            if(efficiencyHolder < 0.02)
            {
                throw new EfficiencyException(efficiencyHolder,"Efficiency less than 0.02!");
            }
            return this.mWidth * this.mHeight * efficiencyHolder * 1300;
        }
    }
}
