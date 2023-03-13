using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class ReminderNote : Note
    {
        public ReminderNote(string message,ITheme theme) : base(message, theme) { }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
