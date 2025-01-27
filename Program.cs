// 2-13 Group: Summer Sampson, Kate Sargent, Ainsley Rossiter, Trey Hammond
using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcoming
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            // setting up the array board
            string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            // calling the new GameTools.cs page on the other side
            GameTools game = new GameTools();
            string currentPlayer = "X";
            bool gameWon = false;

            while (!gameWon && !game.IsBoardFull(board))
            {
                // Print the board
                game.PrintBoard(board);

                // Get player's choice
                Console.WriteLine($"Player {currentPlayer}, choose a position (1-9):");
                string input = Console.ReadLine();

                // Validate and update the board
                if (int.TryParse(input, out int position) && position >= 1 && position <= 9 &&
                    board[position - 1] == input)
                {
                    board[position - 1] = currentPlayer;

                    // check if there is a winner
                    if (game.CheckWinner(board, currentPlayer))
                    {
                        gameWon = true;
                        game.PrintBoard(board);
                        Console.WriteLine($"Player {currentPlayer} wins!");
                    }
                    else
                    {
                        // switch player
                        currentPlayer = currentPlayer == "X" ? "O" : "X";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }
            // if neither won and the board was full
            if (!gameWon)
            {
                game.PrintBoard(board);
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
