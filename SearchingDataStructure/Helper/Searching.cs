using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingDataStructure.Helper
{
    internal class Searching
    {
        internal static void IterativeBinarySearch()
        {
            Console.WriteLine("Enter the numbers in sorted order(comma separated)"); // 2,5,9,15,25,33,56,64
            int[] items = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();

            Console.WriteLine("Enter the element to be searched");
            int num = Convert.ToInt32(Console.ReadLine());

            int low = 0;
            int high = items.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;

                if(items[mid] == num)
                {
                    Console.WriteLine($"Element {num} found at index : {mid}");
                    return;
                }
                else if(num > items[mid])
                {
                    low = mid + 1;                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("Element not found");
        }

        internal static void RecursiveBinarySearch(int[] items, int num, int low, int high)
        {
            if(low > high)
            {
                Console.WriteLine("Element not found");
                return;
            }

            int mid = (low + high) / 2;

            if(items[mid] == num)
            {
                Console.WriteLine($"Element {num} found at index : {mid}");
            }
            else if (num > items[mid])
            {
                RecursiveBinarySearch(items, num, mid + 1, high);
            }
            else
            {
                RecursiveBinarySearch(items, num, low, mid - 1);
            }
        }
    }
}
