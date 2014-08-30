using System;
using System.Text;

class BitPaths
{
    static void Main()
    {
        // Getting input
        int numberOfPaths = int.Parse(Console.ReadLine());
        string[] pathsString = new string[numberOfPaths];
        int[,] paths = new int[numberOfPaths, 8];
        StringBuilder[] board = new StringBuilder[8]
        {
            new StringBuilder(),
            new StringBuilder(),
            new StringBuilder(),
            new StringBuilder(),
            new StringBuilder(),
            new StringBuilder(),
            new StringBuilder(),
            new StringBuilder(),
        };

        for (int path = 0; path < numberOfPaths; path++)
        {
            pathsString[path] = Console.ReadLine();
            string[] pathArrayString = pathsString[path].Split(',');

            for (int digit = 0; digit < pathArrayString.Length; digit++)
            {
                paths[path, digit] = int.Parse(pathArrayString[digit]);
            }
        }

        // Initializing the board
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                board[row].Append("0");
            }
        }

        // Processing
        for (int path = 0; path < numberOfPaths; path++)
        {
            int currentPath = paths[path, 0];
            int currentPos = 0;

            for (int step = 0; step < 8; step++)
            {
                currentPath = paths[path, step];

                if (step == 0)
                {
                    currentPos = currentPath;
                }
                else
                {
                    currentPos = currentPos + currentPath;
                }

                if (board[step][currentPos].ToString() == "0")
                {
                    board[step][currentPos] = '1';
                }
                else
                {
                    board[step][currentPos] = '0';
                }
            }
        }

        int decResult = 0;

        foreach (StringBuilder line in board)
        {
            decResult += Convert.ToInt32(line.ToString(), 2);
        }

        string hexResult = decResult.ToString("X");

        Console.WriteLine(Convert.ToString(decResult, 2));
        Console.WriteLine(hexResult);
    }
}
