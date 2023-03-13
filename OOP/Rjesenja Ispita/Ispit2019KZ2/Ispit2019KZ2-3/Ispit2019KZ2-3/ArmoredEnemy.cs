using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ2_3
{
    class ArmoredEnemy : Enemy
    {
        private double hitChance;
        private int ShieldLevel;

        public ArmoredEnemy(double hitChance,int ShieldLevel,string mName, int mAttackDamage) : base(mName,mAttackDamage)
        {
            if (hitChance < 0 || hitChance > 1) throw new ArgumentOutOfRangeException();
            if (ShieldLevel < 0 || ShieldLevel > 100) throw new ArgumentOutOfRangeException();
            this.hitChance = Math.Round(hitChance,2);
            this.ShieldLevel = ShieldLevel;
        }

        public override void takeDamage(int amount)
        {
            Random gen = new Random();
            if(gen.NextDouble() >= hitChance)
            {
                if (this.ShieldLevel > 0)
                {
                    if (this.ShieldLevel - amount < 0)
                    {
                        this.ShieldLevel = 0;
                    }
                    else this.ShieldLevel -= amount;
                }
                else base.takeDamage(amount);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} HitChance: {this.hitChance} ShieldLevel: {this.ShieldLevel}";
        }
    }
}
