using AlgoExam.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam.Algorithm
{
    public class Quick_sort : ISortService
    {
        public void QuickSort(int[] array, int low, int high, ref int operationCount)
        
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high, ref operationCount);

                QuickSort(array, low, pivotIndex - 1, ref operationCount);
            }
        }
        static int Partition(int[] array, int low, int high, ref int operationCount)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                operationCount++;
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                    operationCount++;
                }
            }

            Swap(array, i + 1, high);
            operationCount++;
            return i + 1;
        }
        static void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}
    }
}
