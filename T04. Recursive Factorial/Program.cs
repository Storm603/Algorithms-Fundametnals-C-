using System;

namespace T04._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RecFac(n));
            
        }

        private static int RecFac(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * RecFac(n - 1);
        }
    }
}
