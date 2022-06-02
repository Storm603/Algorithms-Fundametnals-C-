using System;
using System.Linq;

namespace T05.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", Quicksort(nums, 0, nums.Length - 1)));
            
        }

        private static int[] Quicksort(int[] nums, int startIdx, int endIdx)
        {
            int pivot = startIdx;
            int leftIdx = startIdx + 1;
            int rightIx = endIdx;

            while (leftIdx >= rightIx)
            {
                if (nums[leftIdx] > nums[pivot] && nums[rightIx] < nums[pivot])
                {
                    Swap(nums, leftIdx, rightIx);
                }

                if (nums[leftIdx] <= nums[pivot])
                {
                    leftIdx++;
                }

                if (nums[rightIx] >= nums[pivot])
                {
                    rightIx--;
                }
            }

            Swap(nums, pivot, rightIx);

            bool isLeftArraySmaller = rightIx - 1 - leftIdx < (nums.Length - 1) - (rightIx + 1);

            if (isLeftArraySmaller)
            {
                Quicksort(nums, startIdx, rightIx - 1);
                Quicksort(nums, rightIx + 1, endIdx);
            }
            else
            {
                Quicksort(nums, rightIx + 1, endIdx);
                Quicksort(nums, startIdx, endIdx - 1);
            }

            return nums;
        }

        private static void Swap(int[] nums, int leftIdx, int rightIx)
        {
            int temp = nums[rightIx];
            nums[rightIx] = nums[leftIdx];
            nums[leftIdx] = temp;
        }
    }
}
