using System;
using System.Linq;

namespace T02SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", SelectionSort(nums)));
            

        }

        private static int[] SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int min = nums[i];
                int smallestIndex = 0;
                bool toSwapNumbers = false;
                for (int j = 1 + i; j < nums.Length; j++)
                {
                    if (nums[j] < min)
                    {
                        min = nums[j];
                        smallestIndex = j;
                        toSwapNumbers = true;
                    }
                }

                if (toSwapNumbers)
                {
                    nums = Swap(nums, smallestIndex, i);
                }
            }

            return nums;
        }

        private static int[] Swap(int[] nums, int smallestIndex, int i)
        {
            int temp = nums[i];
            nums[i] = nums[smallestIndex];
            nums[smallestIndex] = temp;

            return nums;
        }
    }
}
