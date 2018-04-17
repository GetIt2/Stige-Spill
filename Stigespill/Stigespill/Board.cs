using System;

namespace Stigespill
{
    class Board
    {
        public Board(int size)
        {
            Show(size);
        }

        private void Show(int size)
        {
            var firstRow = GetFirstRow(size);
            Console.WriteLine(firstRow);
            for (int i = size - 1; i >= 1; i--)
            {
                var firstWallRow = CreateFirstWallRow(size, i);
                var secondWallRow = CreateSecondWallRow(size);
                var middleRow = CreateMiddleRow(size);
                Console.WriteLine(firstWallRow);
                Console.WriteLine(secondWallRow);
                Console.WriteLine(middleRow);
            }
            Console.WriteLine(CreateFirstWallRow(size , 0));
            Console.WriteLine(CreateSecondWallRow(size));
            var lastRow = CreateLastRow(size);
            Console.WriteLine(lastRow);

        }

        private static string CreateSecondWallRow(int size)
        {
            string wallRow = null;
            for (int wallIndex = 0; wallIndex < size; wallIndex++)
            {
                wallRow += $"│      ";
            }

            wallRow += "│";
            return wallRow;
        }

        private static string CreateLastRow(int size)
        {
            var lastRow = "└";
            for (int i = 0; i < size - 1; i++)
            {
                lastRow += "──────┴";
            }

            lastRow += "──────┘";
            return lastRow;
        }

        private static string CreateMiddleRow(int size)
        {
            var middleRow = "├";
            for (int middleIndex = 0; middleIndex < size - 1; middleIndex++)
            {
                middleRow += "──────┼";
            }

            middleRow += "──────┤";
            return middleRow;
        }

        private static string CreateFirstWallRow(int size, int i)
        {
            string wallRow = null;
            if (i % 2 == 0)
            {
                for (int wallIndex = 0; wallIndex < size; wallIndex++)
                {
                    wallRow += $"│    {i}{wallIndex}";
                }
            }
            else
            {
                for (int wallIndex = size - 1; wallIndex >= 0; wallIndex--)
                {
                    wallRow += $"│    {i}{wallIndex}";
                }
            }

            wallRow += "│";
            return wallRow;
        }

        private static string GetFirstRow(int size)
        {
            var firstRow = "┌";
            for (int i = 0; i < size - 1; i++)
            {
                firstRow += "──────┬";
            }

            firstRow += "──────┐";
            return firstRow;
        }
    }
}
