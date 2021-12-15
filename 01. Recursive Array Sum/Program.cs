using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;
            Console.WriteLine(GetSum(input, index));
            

        }

        private static int GetSum(int[] input, int index)
        {
            if (index >= input.Length)
            {
                return 0;
            }

            return input[index] + GetSum(input, index + 1);

        }

    }
}
