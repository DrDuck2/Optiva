using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    public class NotificationDirector
    {
        private NotificationBuilder builder;

        public NotificationDirector()
        {
            builder = new NotificationBuilder();
        }
        public NotificationDirector(NotificationBuilder builder)
        {
            this.builder = builder;
        }

        public ConsoleNotification CreateInfoNotification(string author)
        {
            builder.SetAuthor(author).SetColor(ConsoleColor.Red).SetLevel(Category.INFO).SetText("Text1").SetTime(DateTime.Now).SetTitle("Title1");
            return builder.Build();
        }
        public ConsoleNotification CreateAlertNotification(string author)
        {
            builder.SetAuthor(author).SetColor(ConsoleColor.Blue).SetLevel(Category.ALERT).SetText("Text2").SetTime(DateTime.Now).SetTitle("Title2");
            return builder.Build();
        }
        public ConsoleNotification CreateErrorNotification(string author)
        {
            builder.SetAuthor(author).SetColor(ConsoleColor.Green).SetLevel(Category.ERROR).SetText("Text3").SetTime(DateTime.Now).SetTitle("Title3");
            return builder.Build();
        }
    }
}
