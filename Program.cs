using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = CreateBoard();

            do
            {
                Console.WriteLine("Player 1 which row would you like to move to?");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Player 1 which column would you like to move to?");
                int column = int.Parse(Console.ReadLine());

                board[row, column] = 'X';
                CheckWin(board);


                PrintBoard(board);

                Console.WriteLine("Player 2 which row would you like to move to?");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Player 2 which column would you like to move to?");
                column = int.Parse(Console.ReadLine());

                board[row, column] = 'O';
                CheckWin(board);

                PrintBoard(board);

            } while (true);
        }

        public static bool CheckWin(char[,] board)
        {
            if (   board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X'
                || board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X'
                || board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X'
                || board[2, 0] == 'X' && board[1, 1] == 'X' && board[0, 2] == 'X'
                || board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X'
                || board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X'
                || board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X'
                || board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                Console.WriteLine("Player 1 Wins!");
                return true;
            }

            if (   board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O'
                || board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O'
                || board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O'
                || board[2, 0] == 'O' && board[1, 1] == 'O' && board[0, 2] == 'O'
                || board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O'
                || board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O'
                || board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O'
                || board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
            {
                Console.WriteLine("Player 2 Wins!");
            }
            return false;
        }

        public static char[,] CreateBoard()
        {
            char[,] board = new char[3, 3];
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= board.GetUpperBound(1); col++)
                {
                    board[row, col] = '-';
                }
            }
            return board;
        }

        public static void PrintBoard(char[,] board)
        {
            for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= board.GetUpperBound(1); col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
    
}
