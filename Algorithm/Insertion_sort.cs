using AlgoExam.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam.Algorithm
{
    public class Insertion_sort : ISortService
    {
        public SortResult Sort(int[] array)
        {
            long operations = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;
                operations++; 
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                    operations += 2; 
                }
                array[j + 1] = key;
                operations++;
            }

            stopwatch.Stop();
            return new SortResult
            {
                OperationCount = operations,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                AlgorithmName = "Insertion Sort"
            };
        }
    }
}
