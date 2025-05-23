using AlgoExam.Interface;

public class BubbleSort : ISortService
{
    public int BubbleSortS(int[] array)
    {
        int operationCount = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                operationCount++; 
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                    operationCount++; 
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        return operationCount;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public SortResult Sort(int[] array)
    {
        if (array == null || array.Length == 0)
            return new SortResult
            {
                OperationCount = 0,
                ElapsedMilliseconds = 0,
                AlgorithmName = "Bubble Sort - O(n^2)"
            };

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        int operationCount = BubbleSortS(array);
        stopwatch.Stop();

        return new SortResult
        {
            OperationCount = operationCount,
            ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
            AlgorithmName = "Bubble Sort - O(n^2)"
        };
    }
}

