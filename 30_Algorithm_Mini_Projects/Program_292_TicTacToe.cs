// ============================================
// Program #292 — TicTacToe
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Two-player Tic Tac Toe with board and win detection.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_292_TicTacToe
    {
        static void Main(string[] args)
        {
            char[] board = { '1','2','3','4','5','6','7','8','9' };
            char current = 'X';
            for (int turn = 0; turn < 9; turn++)
            {
                Draw(board);
                Console.Write($"Player {current}, choose cell: ");
                if (!int.TryParse(Console.ReadLine(), out int cell) || cell < 1 || cell > 9 || board[cell - 1] == 'X' || board[cell - 1] == 'O')
                {
                    Console.WriteLine("Invalid move.");
                    turn--;
                    continue;
                }
                board[cell - 1] = current;
                if (Win(board, current)) { Draw(board); Console.WriteLine($"Player {current} wins!"); return; }
                current = current == 'X' ? 'O' : 'X';
            }
            Draw(board);
            Console.WriteLine("It's a draw.");
        }

        static void Draw(char[] b)
        {
            Console.WriteLine($"\n{b[0]}|{b[1]}|{b[2]}\n-+-+-\n{b[3]}|{b[4]}|{b[5]}\n-+-+-\n{b[6]}|{b[7]}|{b[8]}\n");
        }

        static bool Win(char[] b, char p)
        {
            int[,] lines = { {0,1,2},{3,4,5},{6,7,8},{0,3,6},{1,4,7},{2,5,8},{0,4,8},{2,4,6} };
            for (int i = 0; i < lines.GetLength(0); i++) if (b[lines[i,0]] == p && b[lines[i,1]] == p && b[lines[i,2]] == p) return true;
            return false;
        }
    }
}
