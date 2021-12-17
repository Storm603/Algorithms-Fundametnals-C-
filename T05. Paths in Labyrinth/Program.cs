using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.PortableExecutable;

namespace T05._Paths_in_Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            var lab = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                var colElements = Console.ReadLine();
                for (int c = 0; c < colElements.Length; c++)
                {
                    lab[r, c] = colElements[c];
                }
            }

            

            FindPaths(lab, 0, 0, string.Empty);
        }

        static List<string> path = new List<string>();

        private static void FindPaths(char[,] lab, int row, int col, string direction)
        { 
            if (!IsInBounds(lab, row, col))
            {
                return;
            }

            path.Add(direction);


            if (IsExit(lab, row, col))
            {
                PrintPath(path, lab, col, row);
                path.RemoveAt(path.Count - 1);

            }
            else if(!IsVisited(lab , row, col) && IsFree(lab, row, col))
            {
                Mark(lab, row, col);
                FindPaths(lab, row, col + 1, "R");
                FindPaths(lab, row + 1, col, "D");
                FindPaths(lab, row, col - 1, "L");
                FindPaths(lab, row - 1, col, "U");
                Unmark(lab, row, col);
            }

        }

        private static char Unmark(char[,]lab, int row, int col)
        {
            path.RemoveAt(path.Count - 1);

            return lab[row, col] = '-';

        }

        private static bool IsFree(char[,]lab, int row, int col)
        {
            if (lab[row, col] == '-')
            {
                return true;
            }

            return false;
        }

        private static char Mark(char[,] lab, int row, int col)
        {
            return lab[row, col] = 'v';
        }

        private static bool IsVisited(char[,] lab, int row, int col)
        {
            if (lab[row, col] == 'v')
            {
                return true;
            }

            return false;
        }

        private static void PrintPath(List<string> path, char[,] lab, int row, int col) // Path print
        {

            Console.WriteLine(string.Join(string.Empty, path));
        }

        private static bool IsExit(char[,] lab, int row, int col) // Checks if its an exit
        {
            if (lab[row,col] == 'e')
            {
                return true;
            }

            return false;
        }

        private static bool IsInBounds(char[,] lab, int row, int col)  // Checks if next step is in bounds
        {
            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1) || lab[row, col] == '*' || lab[row, col] == 'v') 
            {
                return false;
            }

            return true;
        }
    }
}
