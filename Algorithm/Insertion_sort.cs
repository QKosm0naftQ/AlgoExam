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
            if (array == null || array.Length == 0)
            {
                return new SortResult
                {
                    OperationCount = 0,
                    ElapsedMilliseconds = 0,
                    AlgorithmName = "Insertion Sort - O(n^2)"
                };
            }

            long operations = 0;
            var stopwatch = Stopwatch.StartNew();

            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    operations++; // порівняння
                    if (array[j] > key)
                    {
                        array[j + 1] = array[j];
                        operations++; // зсув (копіювання)
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }

                array[j + 1] = key;
                operations++; // вставка ключа
            }

            stopwatch.Stop();

            return new SortResult
            {
                OperationCount = operations,
                ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
                AlgorithmName = "Insertion Sort - O(n^2)"
            };
        }

    }
}
