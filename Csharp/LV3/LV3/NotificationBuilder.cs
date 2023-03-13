using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    public class NotificationBuilder : IBuilder
    {
        private string author;
        private string title;
        private string text;
        private DateTime time;
        private Category level;
        private ConsoleColor color;

        public NotificationBuilder()
        {
            this.author = "author";
            this.title = "title";
            this.text = "text";
            this.time = DateTime.Now;
            this.level = Category.ERROR;
            this.color = ConsoleColor.Red;
        }
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }
        public IBuilder SetAuthor(String author)
        {
            this.author = author;
            return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.text = text;
            return this;
        }
    }
}
