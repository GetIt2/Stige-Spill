using System;
using System.Text;

namespace Stigespill
{
    class Board
    {
        private BoardCell[] _cells; 
        private const int Size = 10;
        public Board()
        {
            _cells = new BoardCell[Size * Size];
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new BoardCell();
            }
            Show();
        }

        private void Show()
        {
            var firstRow = GetFirstRow();
            Console.WriteLine(firstRow);
            for (int i = Size - 1; i >= 1; i--)
            {
                var firstWallRow = CreateFirstWallRow( i);
                var secondWallRow = CreateSecondWallRow();
                var middleRow = CreateMiddleRow();
                Console.WriteLine(firstWallRow);
                Console.WriteLine(secondWallRow);
                Console.WriteLine(middleRow);
            }
            Console.WriteLine(CreateFirstWallRow(0));
            Console.WriteLine(CreateSecondWallRow());
            var lastRow = CreateLastRow();
            Console.WriteLine(lastRow);

        }
        
        private static string CreateLastRow()
        {
            var lastRow = "└";
            for (int i = 0; i < Size - 1; i++)
            {
                lastRow += "──────┴";
            }

            lastRow += "──────┘";
            return lastRow;
        }

        private static string CreateMiddleRow()
        {
            var middleRow = "├";
            for (int middleIndex = 0; middleIndex < Size - 1; middleIndex++)
            {
                middleRow += "──────┼";
            }

            middleRow += "──────┤";
            return middleRow;
        }

        private static string CreateFirstWallRow( int i)
        {
            string wallRow = null;
            if (i % 2 == 0)
            {
                for (int wallIndex = 0; wallIndex < Size; wallIndex++)
                {
                    if (wallIndex == 0 && i == 0) wallRow += $"│ Start";
                    else wallRow += $"│    {i}{wallIndex}";
                }
            }
            else
            {
                for (int wallIndex = Size - 1; wallIndex >= 0; wallIndex--)
                {
                    if (wallIndex == 9 && i == 9) wallRow += $"│Finish";
                    else wallRow += $"│    {i}{wallIndex}";
                }
            }

            wallRow += "│";
            return wallRow;
        }

        private static string CreateSecondWallRow()
        {
            string wallRow = null;
            for (int wallIndex = 0; wallIndex < Size; wallIndex++)
            {
                wallRow += $"│      ";
            }

            wallRow += "│";
            return wallRow;
        }

        private static string GetFirstRow()
        {
            var firstRow = "┌";
            for (int i = 0; i < Size - 1; i++)
            {
                firstRow += "──────┬";
            }

            firstRow += "──────┐";
            return firstRow;
        }
    }
}
