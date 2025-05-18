using AlgoExam.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam.Algorithm
{
    public class Bubble_sort : ISortService
    {
        public int BubbleSort(int[] array)
        {
            int operationCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    operationCount++;
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        operationCount++;
                    }
                }
            }
            return operationCount;
        }
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
