using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LV2Rpon
{
    public class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        //Ovo je bilo potrebno za Zad 4
        //public void Log(string message)
        //{
        //using (StreamWriter fileWriter = new StreamWriter(this.filePath))
        //{
        //fileWriter.WriteLine(message);
        //}
        //}

        public void Log(ILogable data)
        {
            using (StreamWriter fileWriter = new StreamWriter(this.filePath))
            {
                fileWriter.WriteLine(data.GetStringRepresentation());
            }
        }
    }
}
