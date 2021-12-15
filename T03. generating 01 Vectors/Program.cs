using System;
using System.ComponentModel;

namespace T03._generating_01_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];

            int index = 0;

            Rec(arr, index);
        }

        private static void Rec(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    Rec(arr, index + 1);
                }
            }
        }
    }
}
