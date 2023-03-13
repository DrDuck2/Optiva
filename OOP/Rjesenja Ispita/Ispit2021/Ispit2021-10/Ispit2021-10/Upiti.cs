using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021_10
{
    public static class Upiti
    {
        public static string GetAsStringRows<T>(IEnumerable<T> data)
        {
            return string.Join(Environment.NewLine, data);
        }

        public static void ArticlesWithHina() //Trenutno nije zadana baza podataka pa se nemoze provjeriti tocnost ali to bi trebalo biti to otprilike
        {
            var filteredbyHina = articles.where(source => (source.Source == "HINA") && (source.Keywords.Contains("Trump")));
            Console.WriteLine(GetAsStringRows(filteredbyHina));

        }

        public static void AllUniqueKeys()
        {
            var allUniqueKeys = articles.where(charcount => charcount.Charcount > 1000).Select(keywords => keywords.Keywords);
            Console.WriteLine(GetAsStringRows(allUniqueKeys));
        }

        public static void AverageLenghtPotres()
        {
            double average = 0;
            var potresArticles = articles.where(keywords => keywords.Keywords.Contains("Potres"));
            foreach (var item in potresArticles)
            {
                average += item.Charcount;
            }
            Console.WriteLine(average / potresArticles.Count);
        }
    }
}
