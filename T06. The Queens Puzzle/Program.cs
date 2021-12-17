using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace T06._The_Queens_Puzzle
{
    class Program
    {
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        private static HashSet<int> attackedRightDiagonal = new HashSet<int>();

        static void Main(string[] args)
        {


            bool[,] tab = new bool[8, 8];

            PutQueens(tab, 0);

        }

        static void PutQueens(bool[,] tab, int row)
        {
            if (row >= tab.GetLength(0))
            {
                PrintSolution(tab);
                return;
            }

            for (int col = 0; col < tab.GetLength(1); col++)
            {
                if (CanPlaceQueen(tab, row, col))
                {
                    SetQueen(tab, row, col);
                    PutQueens(tab, row + 1);
                    RemoveQueen(tab, row, col);
                }
            }
        }


        private static void RemoveQueen(bool[,] tab, int row, int col)
        {
            tab[row, col] = false;

            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonal.Remove(row - col);
            attackedRightDiagonal.Remove(row + col);
        }

        private static void SetQueen(bool[,] tab, int row, int col)
        {
            tab[row, col] = true;

            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonal.Add(row - col);
            attackedRightDiagonal.Add(row + col);
        }

        private static bool CanPlaceQueen(bool[,] tab, int srow, int col)
        {
            if (tab[srow, col] != true)
            {
                if (!attackedRows.Contains(srow) && !attackedCols.Contains(col) && !attackedLeftDiagonal.Contains(srow - col) && !attackedRightDiagonal.Contains(srow + col))
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintSolution(bool[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == true)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }

                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
