using System;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complexdefault = new Complex();
            Complex complexnumber = new Complex(5, 5);

            System.Console.WriteLine(complexdefault.GetRealNumber());
            System.Console.WriteLine(complexdefault.GetImaginaryNumber());

            System.Console.WriteLine(complexnumber.GetRealNumber());
            System.Console.WriteLine(complexnumber.GetImaginaryNumber());

            System.Console.WriteLine(complexnumber.ComplexModule());

            System.Console.WriteLine(complexnumber.ComplexString());
        }
    }
}
