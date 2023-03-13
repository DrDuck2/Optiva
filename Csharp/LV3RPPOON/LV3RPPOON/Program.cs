using System;

namespace LV3RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {

            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor("Dominik");
            builder.SetColor(ConsoleColor.Red);
            builder.SetLevel(Category.ALERT);
            ConsoleNotification consoleNotification = builder.Build();
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(consoleNotification);

        }
    }
}
