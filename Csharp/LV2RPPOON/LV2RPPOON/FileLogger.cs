using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LV2RPPOON
{
    class FileLogger : ILogger
    {
        private string filepath;

        public FileLogger(string filepath)
        {
            this.filepath = filepath;
        }
        public void Log(ILogable data)
        {
            using (StreamWriter filewriter = new StreamWriter(this.filepath, true))
            {
                filewriter.WriteLine(data);
            }
        }
    }
}
