using SearchingDataStructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine
                    ("Please select an option" +
                        Environment.NewLine + "1. Iterative Binary Search" +
                        Environment.NewLine + "2. Recursive Binary Search" +
                        Environment.NewLine + "0. Exit"
                    );

                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine(Environment.NewLine + "Input format is not valid. Please try again." + Environment.NewLine);
                }

                if (i == 0)
                {
                    Environment.Exit(0);
                }
                else if (i == 1)
                {
                    Searching.IterativeBinarySearch();
                }
                else if (i == 2)
                {
                    Console.WriteLine("Enter the numbers in sorted order(comma separated)"); // 2,5,9,15,25,33,56,64
                    int[] items = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();

                    Console.WriteLine("Enter the element to be searched");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Searching.RecursiveBinarySearch(items, num, 0, items.Length - 1);
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }
            }
        }
    }
}
