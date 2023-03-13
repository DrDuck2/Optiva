using System;

namespace LV
{
    class Program
    {
        static void Main(string[] args)
        {
            TrashCan can = new TrashCan(100);
            System.Console.WriteLine(can.GetTrashCapacity());
            System.Console.WriteLine(can.GetTrashAmount());
            can.Insert(95);
            System.Console.WriteLine(can.GetTrashAmount());
            System.Console.WriteLine(can.IsFull());
            can.Insert(10);
            System.Console.WriteLine(can.GetTrashAmount());
            System.Console.WriteLine(can.IsFull());
            can.Empty();
            System.Console.WriteLine(can.GetTrashAmount());
            System.Console.WriteLine(can.IsFull());
        }
    }
}
