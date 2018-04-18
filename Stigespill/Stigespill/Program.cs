using System;
using System.Text;

namespace Stigespill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowHeight = 35;
            Console.WindowWidth = 75;
            var board = new Board();
            var move = Console.Read();
            board.MovePlayer(1, move);
        }
    }
}
