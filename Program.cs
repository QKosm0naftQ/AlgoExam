using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test the function with an example
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 3;
            int result = FindKthLargest(arr, k);
            Console.WriteLine($"The {k}th largest element is: {result}");
        }
    }
}
