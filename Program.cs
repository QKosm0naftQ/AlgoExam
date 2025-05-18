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
            int[] data = { 5, 2, 9, 1, 5, 6 };

            ISortService sorter = new Insertion_sort();

            OutPutLine outPutLine = new OutPutLine();
            outPutLine.AddItem(sorter.Sort(data));

            outPutLine.PrintTable();
            
        }
    }
}