using System;
namespace Project4
{
    class GameTools
    {
        // Method to print the board
        public void PrintBoard(string[] board)
        {
            Console.WriteLine("\n");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine("\n");
        }
        // Method to check if there is a winner
        public bool CheckWinner(string[] board, string player)
        {
            // setting up the arrays with the rows and columns
            int[][] winningCombinations = new int[][]
            {
                new int[] { 0, 1, 2 }, // Top row
                new int[] { 3, 4, 5 }, // Middle row
                new int[] { 6, 7, 8 }, // Bottom row
                new int[] { 0, 3, 6 }, // Left column
                new int[] { 1, 4, 7 }, // Middle column
                new int[] { 2, 5, 8 }, // Right column
                new int[] { 0, 4, 8 }, // Diagonal top-left to bottom-right
                new int[] { 2, 4, 6 } // Diagonal top-right to bottom-left
            };
            // checking to see if each player won
            foreach (var combination in winningCombinations)
            {
                // if there are three in a row
                if (board[combination[0]] == player &&
                    board[combination[1]] == player &&
                    board[combination[2]] == player)
                {
                    return true;
                }
            }
            // no win is met
            return false;
        }
        // checking if the board is full for a tie
        public bool IsBoardFull(string[] board)
        {
            foreach (var spot in board)
            {
                // seeing if the board is full
                if (spot != "X" && spot != "O")
                {
                    return false;
                }
            }
            return true;
        }
    }
}