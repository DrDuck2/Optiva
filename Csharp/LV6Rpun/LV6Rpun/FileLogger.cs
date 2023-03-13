using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(type + ": " + DateTime.Now);
                writer.WriteLine(new string('=', message.Length));
                writer.WriteLine(message);
                writer.WriteLine(new string('=', message.Length) + "\n");
            }
        }

    }
}
