using AlgoExam.Algorithm;
using AlgoExam.Algorithm;
using AlgoExam.Interface;
using AlgoExam.Service;
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
            Selection_sort selection_Sort = new Selection_sort();

            Console.Write("Enter the lenth of your array: ");
            int length;
            int[] data = { 5, 2, 9, 1, 5, 6 };

            ISortService sorter = new Insertion_sort();

            OutPutLine outPutLine = new OutPutLine();
            outPutLine.AddItem(sorter.Sort(data));

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
            outPutLine.PrintTable();
            
        }
    }
}