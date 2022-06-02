using System;
using System.Linq;

namespace T03BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", BubbleSort(nums)));
        }

        private static int[] BubbleSort(int[] nums)
        {
            int temp;

            int del = 0;

            while (true)
            {
                bool swapped = false;

                for (int i = 0; i < nums.Length - 1 - del; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        swapped = true;
                    }
                }

                del++;
                if (swapped == false)
                {
                    break;
                }
            }

            return nums;
        }
    }
}
