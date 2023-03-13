using System;

namespace LV7Rpuuuun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRVI DIO \n");
            double[] array = new double[20];
            Random randomGenerator = new Random();
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = randomGenerator.Next(0, 10);
            }
            NumberSequence numberSequence = new NumberSequence(array);
            SortStrategy bubbleSort = new BubbleSort();
            numberSequence.SetSortStrategy(bubbleSort);
            Console.WriteLine("Before sorting \n");
            Console.WriteLine(numberSequence.ToString());
            numberSequence.Sort();
            Console.WriteLine("After sorting \n");
            Console.WriteLine(numberSequence.ToString());
            SearchStrategy linearSearch = new LinearchSearch();
            numberSequence.SetSearchStrategy(linearSearch);
            Console.WriteLine("Does it contain number 3: \n");
            Console.WriteLine(numberSequence.Search(3));



            Console.WriteLine("DRUGI DIO \n");
            SystemDataProvider systemDataProvider = new SystemDataProvider();
            for (; ;)
            {
                systemDataProvider.GetCPULoad();
                systemDataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
                if(Console.ReadLine()=="q")
                {
                    break;
                }
            }

            Console.WriteLine("BUY VISITOR:");
            IItem book = new Book(50, "Title");
            IItem vhs = new VHS("VHS", 20);
            IItem dvd = new DVD("DVD",DVDType.MOVIE, 10);
            IVisitor buyVisitor = new BuyVisitor();
            Console.WriteLine("Book: ");
            Console.WriteLine(book.Accept(buyVisitor));
            Console.WriteLine("VHS: ");
            Console.WriteLine(vhs.Accept(buyVisitor));
            Console.WriteLine("DVD: ");
            Console.WriteLine(dvd.Accept(buyVisitor));

            Console.WriteLine("RENT VISITOR:");
            IVisitor rentVisitor = new RentVisitor();
            Console.WriteLine("Book: ");
            Console.WriteLine(book.Accept(rentVisitor));
            Console.WriteLine("VHS: ");
            Console.WriteLine(vhs.Accept(rentVisitor));
            Console.WriteLine("DVD: ");
            Console.WriteLine(dvd.Accept(rentVisitor));
        }
    }
}
