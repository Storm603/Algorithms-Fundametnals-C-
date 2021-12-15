using System;

namespace _02._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Drawn(count);
        }

        private static void Drawn(int count)
        {
            if (count <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', count));

            Drawn(count - 1);

            Console.WriteLine(new string('#', count));
        }
    }
}
