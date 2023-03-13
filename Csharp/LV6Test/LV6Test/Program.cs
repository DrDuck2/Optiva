using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Test
{
    class Program
    {
        public static string GetAsString<T>(HashSet<T> set)
        {
            string output = string.Empty;
            foreach (var element in set)
            {
                output += $"{element}{Environment.NewLine}";
            }
            return output;
        }
        static void Main(string[] args)
        {
            HashSet<char> letters = new HashSet<char>();
            letters.Add('a');
            letters.Add('q');
            letters.Add('a');
            Console.WriteLine("Characters: ");
            Console.WriteLine(GetAsString(letters));
            
            HashSet<char> numbers = new HashSet<char>();
            numbers.Add('2');
            numbers.Add('1');
            Console.WriteLine("Numbers: ");
            Console.WriteLine(GetAsString(numbers));
            
            letters.UnionWith(numbers);
            Console.WriteLine("Letters after union: ");
            Console.WriteLine(GetAsString(letters));
            
            HashSet<char> vowels = new HashSet<char>("aeiouAEIOU");
            Console.WriteLine("Vowels: ");
            Console.WriteLine(GetAsString(vowels));
            HashSet<char> sentence = new HashSet<char>("The quick brown fox");
            sentence.IntersectWith(vowels);
            Console.WriteLine("Vowels in sentence: ");
            Console.WriteLine(GetAsString(sentence));
            HashSet<Package> packages = new HashSet<Package>();
            packages.Add(new Package(1, 11.0m));
            packages.Add(new Package(3.13, 220.0m));
            packages.Add(new Package(1, 11.0m));
            Console.WriteLine(GetAsString(packages));
        }
    }
}
