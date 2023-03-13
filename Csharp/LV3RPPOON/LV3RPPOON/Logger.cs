using System;
using System.Collections.Generic;
using System.Text;

namespace LV3RPPOON
{
    public class Logger
    {
        private static Logger instance;
        private string filePath;

        private Logger() 
        {
            this.filePath = @"C:\Users\vidov\Desktop\Lv3\text.txt";
        }
        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public string SetFilePath
        {
            set { this.filePath = value; }
        }
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }
    }
}

