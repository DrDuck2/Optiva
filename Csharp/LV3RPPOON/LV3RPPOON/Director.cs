using System;
using System.Collections.Generic;
using System.Text;

namespace LV3RPPOON
{
    public class Director
    {
        private NotificationBuilder notificationBuilder;

        public Director()
        {
            notificationBuilder = new NotificationBuilder();
        }
        public ConsoleNotification ConstructInfoConsoleNotification(string author)
        {
            notificationBuilder.SetAuthor(author).SetColor(ConsoleColor.Black).SetLevel(Category.INFO).SetText("textInfo").SetTime(DateTime.Now).SetTitle("titl1");
            return notificationBuilder.Build();
        }
        public ConsoleNotification ConstructAlertConsoleNotification(string author)
        {
            notificationBuilder.SetAuthor(author).SetColor(ConsoleColor.Red).SetLevel(Category.ALERT).SetText("textAlert").SetTime(DateTime.Now).SetTitle("titl2");
            return notificationBuilder.Build();
        }
        public ConsoleNotification ConstructErrorConsoleNotification(string author)
        {
            notificationBuilder.SetAuthor(author).SetColor(ConsoleColor.Blue).SetLevel(Category.ERROR).SetText("textError").SetTime(DateTime.Now).SetTitle("titl3");
            return notificationBuilder.Build();
        }

    }
}
