using System;
using System.Linq;

namespace T04._Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", InsertionSort(nums)));
            
        }

        private static int[] InsertionSort(int[] nums)
        {
            while (true)
            {
                bool swapped = false;

                int del = 0;

                for (int i = 0; i < nums.Length - 1 - del; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Swap(nums, i);
                        swapped = true;
                    }
                }

                del++;
                if (!swapped)
                {
                    break;
                }
            }

            return nums;
        }

        private static void Swap(int[] nums, int i)
        {
            int temp = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = temp;
        }
    }
}
