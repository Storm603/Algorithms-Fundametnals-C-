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
                bool toSwap = false;
                int smallest = 0;
                int index = 0;
                for (int j = 1 + i; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        smallest = nums[j];
                        index = j;
                        toSwap = true;
                    }
                }

                if (toSwap)
                {
                    nums = Swap(nums, smallest, index, i);
                }
            }

            return nums;
        }

        private static int[] Swap(int[] nums, int smallest, int index, int i)
        {
            int temp = nums[i];
            nums[i] = smallest;
            nums[index] = temp;

            return nums;
        }
    }
}
