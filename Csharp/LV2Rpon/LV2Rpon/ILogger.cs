using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    public interface ILogger
    {
        //Ovo je bilo potrebno za Zad 4
        //void Log(string message);

        void Log(ILogable data);
    }
}
