using System;
using System.Collections.Generic;

namespace LV6Zad1
{
    class Program
    {
        public static string GetAsString<K,V>(Dictionary<K,V> dictionary)
        {
            string output = string.Empty;
            foreach (var key in dictionary.Keys)
            {
                output += $"User: [{key}]: {dictionary[key]}{Environment.NewLine}";
            }
            return output;
        }
        static void Main(string[] args)
        {
            Dictionary<string, SocialMediaPost> posts = new Dictionary<string, SocialMediaPost>();
            posts.Add("Dvidovic", new SocialMediaPost("DominikVidovic", "Pogledaj moga psa!"));
            posts.Add("Msimundic", new SocialMediaPost("MarinSimundic", "Macke su najbolje!"));
            posts.Add("Lvukic", new SocialMediaPost("LukaVukic", "Igram nogomet sa ekipom!"));
            posts["Dvidovic"].Tag("#Dogs");
            posts["Msimundic"].Tag("#Cats");
            posts["Lvukic"].Tag("#Football");
            Console.WriteLine(GetAsString(posts));

            Dictionary<string, SocialMediaPost> copy = new Dictionary<string, SocialMediaPost>();
            foreach (var key in posts.Keys)
            {
                copy[key] = new SocialMediaPost(posts[key]);
            }
            copy["Dvidovic"].Untag("#Dogs");
            copy["Msimundic"].Untag("#Cats");
            copy["Lvukic"].Untag("#Football");
            Console.WriteLine("Copy: ");
            Console.WriteLine(GetAsString(copy));
        }
    }
}
