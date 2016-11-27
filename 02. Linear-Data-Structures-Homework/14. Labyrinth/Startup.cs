using System;

namespace _14.Labyrinth
{
    class Startup
    {
        private const int LabyrinthSize = 6;
        private const string FullCell = "x";
        private const string StartCell = "*";

        private static bool[,] visitedCells = new bool[LabyrinthSize, LabyrinthSize];

        private static string[,] labyrinth = new[,]
            {
                { "0", "0", "0", "x", "0", "x"},
                { "0", "x", "0", "x", "0", "x"},
                { "0", "*", "x", "0", "x", "0"},
                { "0", "x", "0", "0", "0", "0"},
                { "0", "0", "0", "x", "x", "0"},
                { "0", "0", "0", "x", "0", "x"},
            };

        public static void Main()
        {
            GetPath(2, 0, 0);

            for (int i = 0; i < LabyrinthSize; i++)
            {
                for (int j = 0; j < LabyrinthSize; j++)
                {
                    if (labyrinth[i, j] == "0")
                    {
                        labyrinth[i, j] = "u";
                    }

                    Console.Write(labyrinth[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void GetPath(int row, int col, int stepCount)
        {
            visitedCells[row, col] = true;

            var currentCellValue = int.Parse(labyrinth[row, col]);
            if (currentCellValue == 0 || stepCount < currentCellValue)
            {
                labyrinth[row, col] = (++stepCount).ToString();
            }

            if (IsInBounds(row, col - 1) && IsEmpty(row, col - 1) && ShouldBeVisited(row, col - 1, stepCount))
            {
                GetPath(row, col - 1, stepCount);
            }
            if (IsInBounds(row - 1, col) && IsEmpty(row - 1, col) && ShouldBeVisited(row - 1, col, stepCount))
            {
                GetPath(row - 1, col, stepCount);
            }

            if (IsInBounds(row, col + 1) && IsEmpty(row, col + 1) && ShouldBeVisited(row, col + 1, stepCount))
            {
                GetPath(row, col + 1, stepCount);
            }

            if (IsInBounds(row + 1, col) && IsEmpty(row + 1, col) && ShouldBeVisited(row + 1, col, stepCount))
            {
                GetPath(row + 1, col, stepCount);
            }
        }

        private static bool IsEmpty(int row, int col)
        {
            return labyrinth[row, col] != FullCell && labyrinth[row, col] != StartCell;
        }

        private static bool ShouldBeVisited(int row, int col, int stepCount)
        {
            var currentCellValue = int.Parse(labyrinth[row, col]);
            var shouldUpdateCellValue = (currentCellValue == 0 || stepCount < currentCellValue);

            return !visitedCells[row, col] || shouldUpdateCellValue;
        }

        private static bool IsInBounds(int row, int col)
        {
            var rowIsInBounds = 0 <= row && row < LabyrinthSize;
            var colIsInBounds = 0 <= col && col < LabyrinthSize;

            return rowIsInBounds && colIsInBounds;
        }
    }
}
