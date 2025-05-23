using AlgoExam.Interface;

internal class Selection_sort : ISortService
{
    public int[] sort(int[] nums, ref int operationCount)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                operationCount++; // порівняння
                if (nums[j] < nums[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int replace = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = replace;
                operationCount++; // обмін
            }
        }

        return nums;
    }

    public SortResult Sort(int[] array)
    {
        if (array == null || array.Length == 0)
            return new SortResult
            {
                OperationCount = 0,
                ElapsedMilliseconds = 0,
                AlgorithmName = "Selection Sort - O(n^2)"
            };

        int operationCount = 0;
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        int[] sortedArray = sort(array, ref operationCount);

        stopwatch.Stop();

        return new SortResult
        {
            OperationCount = operationCount,
            ElapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds,
            AlgorithmName = "Selection Sort - O(n^2)"
        };
    }
}
