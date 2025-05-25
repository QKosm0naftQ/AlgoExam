using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModel;
using LibraryModel.Algorithm;
using LibraryModel.Service;

namespace ConsoleProject
{
    internal class Program
    {
        private static Random rand = new Random();
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
            int[] arr = new int[length];
            arr = GenerateRandomArray(length);

            Bubble_sort bubbleSort = new Bubble_sort();
            Quick_sort quickSort = new Quick_sort();
            Insertion_sort insertionSort = new Insertion_sort();
            Selection_sort selectionSort = new Selection_sort();

            OutPutLine _service = new OutPutLine();

            _service.AddItem(bubbleSort.Sort((int[])arr.Clone()));
            _service.AddItem(selectionSort.Sort((int[])arr.Clone()));
            _service.AddItem(insertionSort.Sort((int[])arr.Clone()));
            _service.AddItem(quickSort.Sort((int[])arr.Clone()));

            _service.PrintTable();

        }
        static int[] GenerateRandomArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, 1001);
            }
            return array;
        }

    }
}