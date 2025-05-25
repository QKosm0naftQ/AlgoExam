using LibraryModel.Interface;
using System;

public class Quick_sort : ISortService
{
    public void QuickSortS(int[] array, int low, int high, ref int operationCount)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high, ref operationCount);

            QuickSortS(array, low, pivotIndex - 1, ref operationCount);
            QuickSortS(array, pivotIndex + 1, high, ref operationCount);
        }
    }

    static int Partition(int[] array, int low, int high, ref int operationCount)
    {
        int mid = low + (high - low) / 2;
        Swap(array, mid, high); 
        operationCount++;

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
        if (i != j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    public SortResult Sort(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return new SortResult
            {
                OperationCount = 0,
                ElapsedMilliseconds = 0,
                AlgorithmName = "QuickSort"
            };
        }

        int operationCount = 0;
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        QuickSortS(array, 0, array.Length - 1, ref operationCount);

        stopwatch.Stop();
        return new SortResult
        {
            OperationCount = operationCount,
            ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
            AlgorithmName = "QuickSort"
        };
    }
}
