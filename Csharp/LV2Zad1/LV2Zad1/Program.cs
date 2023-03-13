using System;
using System.Text;
using System.IO;

namespace LV2Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite broj zeljenih kontakata:");
            int contactCount = Convert.ToInt32(Console.ReadLine());
            
            Contact[] contact = new Contact[contactCount];
            for(int i = 0;i<contactCount;i++)
            {
                contact[i] = new Contact();
                Console.WriteLine($"Molim unesite podatke {i + 1} kontakta:");
                Console.WriteLine("Ime:");
                contact[i].Name = Console.ReadLine();
                Console.WriteLine("Prezime:");
                contact[i].Surname = Console.ReadLine();
                Console.WriteLine("Tel.broj:");
                contact[i].PhoneNumber = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("email:");
                    contact[i].Email = Console.ReadLine();
                    if (EmailHelper.CorrectEmail(contact[i].Email) == false)
                    {
                        Console.WriteLine("POGRESAN UNOS EMAILA!");
                    }
                } while (EmailHelper.CorrectEmail(contact[i].Email) == false);
                
            }
            Console.WriteLine("Molim unos naziva datoteke:");
            string fileName = Console.ReadLine();
            string filePath = $@"D:\{fileName}.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for(int i = 0;i<contactCount;i++)
                {
                    if(EmailHelper.FeritEmail(contact[i].Email) == true)
                    {
                        writer.WriteLine(contact[i].Name);
                        writer.WriteLine(contact[i].Surname);
                        writer.WriteLine(contact[i].PhoneNumber);
                        writer.WriteLine(contact[i].Email);
                    }
                }
            }

        }
    }
}
