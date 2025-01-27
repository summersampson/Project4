// Welcome the user
Console.WriteLine("Welcome to Tic-Tac-Toe!");

using Project4;

gameTools gt = new gameTools();

bool gameOver = false;

char[] board = new char[9];

string input = "";

int player = 0;

while (gameOver == false) 
{
    // Display the board
    gt.displayBoard(board);

    Console.WriteLine("Player X, please enter the number of an open space between 1 and 9: ");

    while (true)
    {
        input = Console.ReadLine();
        if (int.TryParse(input, out player) && player >= 1 && player <= 9)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
        }
    }


    player = int.Parse(Console.ReadLine());

    board[player - 1] = 'X';

    // Check for a winner
    if (gt.checkForWinner(board) == true)
    {
        Console.WriteLine("Player X wins!");
        gt.displayBoard(board);
        gameOver = true;
    }
    else
    {
        gt.displayBoard(board);

        Console.WriteLine("Player O, please enter the number of an open space between 1 and 9: ");
        player = int.Parse(Console.ReadLine());
        board[player - 1] = 'O';
        // Check for a winner
        if (gt.checkForWinner(board) == true)
        {
            Console.WriteLine("Player O wins!");
            gt.displayBoard(board);
            gameOver = true;
        }
    }
}

Console.WriteLine("Thank you for playing!");
