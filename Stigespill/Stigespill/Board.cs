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
            for (int i = 0; i < size - 1; i++)
            {
                var wallRow = CreateWallRow(size);
                var middleRow = CreateMiddleRow(size);
                Console.WriteLine(wallRow);
                Console.WriteLine(middleRow);
            }
            Console.WriteLine(CreateWallRow(size));
            var lastRow = CreateLastRow(size);
            Console.WriteLine(lastRow);

        }

        private static string CreateLastRow(int size)
        {
            var lastRow = "└";
            for (int i = 0; i < size - 1; i++)
            {
                lastRow += "───┴";
            }

            lastRow += "───┘";
            return lastRow;
        }

        private static string CreateMiddleRow(int size)
        {
            var middleRow = "├";
            for (int middleIndex = 0; middleIndex < size - 1; middleIndex++)
            {
                middleRow += "───┼";
            }

            middleRow += "───┤";
            return middleRow;
        }

        private static string CreateWallRow(int size)
        {
            string wallRow = null;
            for (int wallIndex = 0; wallIndex < size; wallIndex++)
            {
                wallRow += "│   ";
            }

            wallRow += "│";
            return wallRow;
        }

        private static string GetFirstRow(int size)
        {
            var firstRow = "┌";
            for (int i = 0; i < size - 1; i++)
            {
                firstRow += "───┬";
            }

            firstRow += "───┐";
            return firstRow;
        }
    }
}
