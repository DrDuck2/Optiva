using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ2_3
{
    [Serializable]
    class IllegalEnemyException : SystemException
    {
        private string mName;
        private int mHealth;
        private int mAttackDamage;

        public string getmName
        {
            get { return mName; }
        }
        public int getmHealth
        {
            get { return mHealth; }
        }
        public int getmAttackDamage
        {
            get { return mAttackDamage; }
        }

        public IllegalEnemyException() : base() { }
        public IllegalEnemyException(string message) : base(message) { }
        public IllegalEnemyException(string message, SystemException exception) : base(message, exception) { }
        public IllegalEnemyException(string mName,int mHealth,int mAttackDamage, string message): base(message)
        {
            this.mName = mName;
            this.mHealth = mHealth;
            this.mAttackDamage = mAttackDamage;
        }
    }
}
