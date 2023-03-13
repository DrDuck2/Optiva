using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    
    public interface IDiceManager
    {
        void InsertDie(Die die);
        void RemoveAllDice();
    }
}
