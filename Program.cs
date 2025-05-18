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
            Console.Write("Enter the lenth of your array: ");
            int length;

            while (true)
            {
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.Write("Enter the number please: ");
                }
            }

            Dictionary<string, int[]> arrays = new Dictionary<string, int[]>();

            arrays.Add("Quick sort", new int[length]);
            arrays.Add("Bubble sort", new int[length]);
            arrays.Add("Selection sort", new int[length]);
            arrays.Add("Insertion sort", new int[length]);

            Random rand = new Random();

            foreach (int[] array in arrays.Values) 
            {
                for (int i = 0; i < length; i++) 
                {
                    array[i] = rand.Next(0, 1000);
                }
            }
        }
    }
}