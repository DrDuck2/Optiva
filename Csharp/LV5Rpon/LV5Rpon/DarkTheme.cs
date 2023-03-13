using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class DarkTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public string GetHeader(int width)
        {
            return new string('_', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
