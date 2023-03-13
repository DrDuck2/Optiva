using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ2_3
{
    class Enemy
    {
        private string mName;
        private int mHealth;
        private int mAttackDamage;

        public Enemy(string mName,int mAttackDamage)
        {
            if (mAttackDamage > 100 || mAttackDamage < 0) throw new OutOfMemoryException();
            if (mAttackDamage < 50) throw new IllegalEnemyException(mName,100,mAttackDamage,"AttackDamage lower than 50!");
            this.mName = mName;
            this.mHealth = 100;
            this.mAttackDamage = mAttackDamage;
        }
        public int getAttackDamage
        {
            get { return this.mAttackDamage; }
        }
        public int getHealth
        {
            get { return this.mHealth; }
        }

        public virtual void heal(int amount)
        {
            if(this.mHealth != 0 && this.mHealth < 100)
            {
                if (this.mHealth + amount > 100)
                {
                    this.mHealth = 100;
                }
                else this.mHealth += amount;
            }
        }
        public virtual void takeDamage(int amount)
        {
            if (this.mHealth - amount < 0)
            {
                this.mHealth = 0;
            }
            else this.mHealth -= amount;
        }

        public override string ToString()
        {
            return $"Name: {this.mName} Health: {this.mHealth} AttackDamage: {this.mAttackDamage}";
        }

    }
}
