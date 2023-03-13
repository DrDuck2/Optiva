using System;

namespace LV5Rpon
{
    class Program
    {
        //C:\Users\vidov\Desktop\Da.txt
        static void Main(string[] args)
        {
            VirtualProxyDataset virtualProxyDataset = 
                new VirtualProxyDataset(@"C:\Users\vidov\Desktop\Da.txt");

            User user = User.GenerateUser("Dominik");
            ProtectionProxyDataset protectionProxyDataset = 
                new ProtectionProxyDataset(user);

            
            DataConsolePrinter dataConsolePrinter = 
                DataConsolePrinter.GetInstance();
            Console.WriteLine("VirtualProxyDataset: ");
            dataConsolePrinter.PrintData(virtualProxyDataset);
            Console.WriteLine("ProtectionProxyDataset: ");
            dataConsolePrinter.PrintData(protectionProxyDataset);
            LogProxyDataset logProxyDataset = 
                new LogProxyDataset(@"C:\Users\vidov\Desktop\Da.txt");
            Console.WriteLine("LogProxyDataset:");
            logProxyDataset.LogData();


            Note reminderNote = new ReminderNote("message hehe", new DarkTheme());
            reminderNote.Show();

            GroupNote groupNote = new GroupNote("message hihi", new DarkTheme());
            groupNote.AddMember("Dominik");
            groupNote.AddMember("Marin");
            groupNote.AddMember("Vule");
            groupNote.RemoveMember("Vule");
            groupNote.Show();
            groupNote.Theme = new LightTheme();
            groupNote.Show();

            //Notebook noteBook = new Notebook();  //Ne radi zbog novog konstruktora u Notebook
            //noteBook.AddNote(reminderNote);
            //noteBook.AddNote(groupNote);
            //noteBook.Display();

            //noteBook.ChangeTheme(new DarkTheme());

            Notebook noteBook = new Notebook(new LightTheme());
            noteBook.AddNote(reminderNote);
            noteBook.AddNote(groupNote);
            noteBook.Display();
        }
    }
}
