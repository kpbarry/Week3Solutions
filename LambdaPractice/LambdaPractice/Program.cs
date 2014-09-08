using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();
            //print the kayakProducts to the console using a foreach loop.
            foreach (var v in kayakProducts)
            {
                Console.WriteLine(v);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();
            //print the shoeProducts to the console using a foreach loop or string.Join().
            Console.WriteLine("SHOES");
            Console.WriteLine(string.Join(", ", shoeProducts));
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball")).ToList();
            //print the ballProducts to the console using a foreach loop or string.Join().
            Console.WriteLine(string.Join(", ", ballProducts));
            //sort ballProducts alphabetically and print them to the console.
            List<string> sortedBallProducts = ballProducts.OrderBy(x => x).ToList();
            Console.WriteLine("Sorted ball products: " + string.Join(", ", sortedBallProducts));
            //add six more items to the products list using .add().
            products.Add("Knee pads");
            products.Add("Rock climbing shoes");
            products.Add("Shoulder pads");
            products.Add("Hockey stick");
            products.Add("Baseball mitt");
            products.Add("Elbow pads");
            //print the product with the longest name to the console using the .First() extension.
            string longest = (from x in products
                              orderby x.Length descending
                              select x).First();
            Console.WriteLine("Longest word is: " + longest);
            //print the product with the shortest name to the console using OrderByDescending() and the .First() extension.
            string shortest = (from x in products
                               orderby x.Length ascending
                               select x).First();
            Console.WriteLine("Shortest word is: " + shortest);
            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            List<string> fourth = products.OrderBy(x => x.Length).ToList();
            Console.WriteLine("Fourth shortest: " + fourth[3]);
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            List<string> secondLongest = products.OrderBy(x => x.Length).ToList();
            Console.WriteLine("Second Longest: " + secondLongest[products.Count - 1]);
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(string.Join(", ", reversedProducts));
            Console.WriteLine("ORDERED BY LONGEST WORD");
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var v in reversedProducts)
            {
                Console.WriteLine(v);
            }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //Note: you will not use a variable to store your list
            Console.WriteLine("Longest Word First");
            foreach (var v in reversedProducts)
            {
                reversedProducts.OrderByDescending(x => x).ToList();
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}