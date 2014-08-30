using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem4
{
    struct Position
    {
        public int q1row;
        public int q1col;
        public int q2row;
        public int q2col;
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine()) + 1;
        List<Position> positions = new List<Position>();

        // Initializing board
        bool[,] board = new bool[size, size];

        // First queen position
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                int q2posRow;
                int q2posCol;

                // Second queen position
                // To the top
                if (row - distance >= 0)
                {
                    q2posRow = row - distance;
                    q2posCol = col;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the right
                if (col + distance < size)
                {
                    q2posRow = row;
                    q2posCol = col + distance;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the bottom
                if (row + distance < size)
                {
                    q2posRow = row + distance;
                    q2posCol = col;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the left
                if (col - distance >= 0)
                {
                    q2posRow = row;
                    q2posCol = col - distance;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the top-right
                if (row - distance >= 0 && col + distance < size)
                {
                    q2posRow = row - distance;
                    q2posCol = col + distance;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the right-down
                if (col + distance < size && row + distance < size)
                {
                    q2posRow = row + distance;
                    q2posCol = col + distance;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the bottom-left
                if (row + distance < size && col - distance >= 0)
                {
                    q2posRow = row + distance;
                    q2posCol = col - distance;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }

                // To the left-top
                if (col - distance >= 0 && row - distance >= 0)
                {
                    q2posRow = row - distance;
                    q2posCol = col - distance;

                    positions.Add(new Position { q1row = row, q1col = col, q2row = q2posRow, q2col = q2posCol });
                }
            }
        }

        if (positions.Count == 0)
        {
            Console.WriteLine("No valid positions");
            return;
        }

        foreach (Position pos in positions)
        {
            Console.WriteLine("{0}{1} - {2}{3}", (char)(pos.q1row + 97), pos.q1col + 1, (char)(pos.q2row + 97), pos.q2col + 1);
        }
    }
}