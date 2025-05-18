    using AlgoExam.Interface;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AlgoExam.Algorithm
    {
        internal class Selection_sort : ISortService
        {
            public int[] sort(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
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
                    }
                }

                return nums;
            }
        }
    }
