using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class LinqOperators
    {
        public static void WhereOp()
        {
            string[] names = {"Ana","Tom", "Dick", "Harry"};

            
            IEnumerable<string> filteredNames = System.Linq.Enumerable.Where
                (names, n => n.Length >= 4);
            List<string> mylist = new List<string>(filteredNames);

            filteredNames = names.Where(n => n.Contains("a"));

            mylist = new List<string>(filteredNames);
        }

        public static void ChainingOp()
        {
            string[] names = {"Tom", "Dick", "Harry", "Mary", "Jay"};
            IEnumerable<string> query = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)                
                //.OrderByDescending(n => n.ToLower())
                .Select(n => n.ToUpper());
            
            List<string> mylist = new List<string>(query);

            IEnumerable<string> filtered = names.Where(n => n.Contains("a"));
            IEnumerable<string> sorted = filtered.OrderBy(n => n.Length);
            IEnumerable<string> finalQuery = sorted.Select(n => n.ToUpper());

            IEnumerable<string> filteredEnumerablequery =
                Enumerable.Select(
                    Enumerable.OrderBy(
                        Enumerable.Where(
                            names, n => n.Contains("a")
                            ), n => n.Length
                        ), n => n.ToUpper()
                    );

             mylist = new List<string>(filteredEnumerablequery.Skip(1));
            mylist = new List<string>(filteredEnumerablequery.Reverse().Take(2));

            mylist = filteredEnumerablequery.OrderBy(n => n).ToList();
            //Harry, Jay , Mary


        }

        public static void OtherOperators()
        {
            int[] numbers = {10, 9, 8, 7, 6};
            int count = numbers.Count();
            int min = numbers.Min();
            bool hasAnOddElement = numbers.Any(n => n%2 != 0);
            int countodds = numbers
                .Where(n => n % 2 != 0)
                .Count();
            double avg = numbers.Average();
            int sum = numbers.Sum();

            IEnumerable<char> query = "Not what you might expect";
            string vowels = "aeiou";
            
           query = query.Where(c => !vowels.Contains(c));
           
            List<char> mylist = query.ToList();

        }

        public static void SubQueries()
        {
            string[] names = {"Tom", "Dick", "Harry", "Mary", "Jay", "Gimmy" };

                      
            
            IEnumerable<string> outerQuery = names
                .Where(n => n.Length == names.OrderBy(n2 => n2.Length)
                    .Select(n2 => n2.Length).Last());
            List<string> mylist = outerQuery.ToList();

            IEnumerable<string> query2 =
                from n in names
                select n.Replace("a", "").Replace("e", "").Replace("i", "")
                    .Replace("o", "").Replace("u", "")
                into noVowel
                select noVowel;
           

            IEnumerable<string> query =
                from n in names
                select n.Replace("a", "").Replace("e", "").Replace("i", "")
                    .Replace("o", "").Replace("u", "")
                into noVowel
                where noVowel.Length > 2
                orderby noVowel
                select noVowel;
                

            mylist = query.ToList();

            query =
                from n in names
                let vowelless = n.Replace("a", "").Replace("e", "").Replace("i", "")
                    .Replace("o", "").Replace("u", "")
                where vowelless.Length > 2
                orderby vowelless
                select n; // Thanks to let, n is still in scope.
            mylist = query.ToList();

        }
    }
}
