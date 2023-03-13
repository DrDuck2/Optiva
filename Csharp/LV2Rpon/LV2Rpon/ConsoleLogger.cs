using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Rpon
{
    public class ConsoleLogger : ILogger
    {
        //Ovo je bilo potrebno za Zad 4
        //public void Log(string message)
        //{
        //Console.WriteLine(message);
        //}

        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
