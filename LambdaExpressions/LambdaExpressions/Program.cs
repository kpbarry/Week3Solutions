using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>() {"boisonberry","banana","kiwi", "strawberry", "mango", "pineapple", "apple", "blueberry" };
            OrderByExample(myList);
            WhereExample(myList);
            DistinctExample();
            FirstAndLastExample(myList);
            SkipAndTakeExample(myList);
            Console.ReadKey();
        }

        static void OrderByExample(IEnumerable<string> list)
        {
            //Order list by length, then alphabetically, then print out to console
            List<string> orderedList = list.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", orderedList));
        }

        static void WhereExample(IEnumerable<string> list)
        {
            //Print to console all times items in list contains "berry"
            List<string> berryList = list.Where(x => x.Contains("berry")).ToList();
            Console.WriteLine(string.Join(", ", berryList));

            //Print where does not contain berry
            List<string> notBerryList = list.Where(x => !x.Contains("berry")).ToList();
            Console.WriteLine(string.Join(", ", notBerryList));
        }

        static void FirstAndLastExample(IEnumerable<string> list)
        {
            //Sort alphabetically and print first and last items
            List<string> sorted = list.OrderBy(x => x).ToList();
            Console.WriteLine("First: " + sorted.First() + "\nLast: " + sorted.Last());
        }

        static void DistinctExample()
        {
            List<int> intList = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4 };
            Console.WriteLine(string.Join(", ", intList.Distinct()));
        }

        static void SkipAndTakeExample(IEnumerable<string> list)
        {
            //Print out 3rd item sorted by length
            List<string> sorted = list.OrderBy(x => x.Length).ToList();
            //Skip 2, take 1
            Console.WriteLine(sorted.Skip(2).Take(1).First());
        }
    }
}
