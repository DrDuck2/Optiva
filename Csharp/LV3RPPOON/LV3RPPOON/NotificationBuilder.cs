using System;
using System.Collections.Generic;
using System.Text;

namespace LV3RPPOON
{
    public class NotificationBuilder : IBuilder
    {
        private String author;
        private String title;
        private DateTime time;
        private Category level;
        private ConsoleColor color;
        private String text;

        public NotificationBuilder() { }
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
