using System;

class PandaScotlandFlag
{
    private static char letter = '@';

    public static char Letter
    { 
        get
        {
            if (letter < 90)
            {
                return ++letter;
            }
            else
            {
                return letter = 'A';
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int halfN = n / 2;

        // Upper-half
        for (int row = 0; row < halfN; row++)
        {
            // Upper-left
            for (int col = 0; col < halfN; col++)
            {
                if (col == row)
                {
                    Console.Write(Letter);
                }
                else if (col < row)
                {
                    Console.Write("~");
                }
                else
                {
                    Console.Write("#");
                }
            }

            // Upper-right
            for (int col = halfN; col >= 0; col--)
            {
                if (col > row)
                {
                    Console.Write("#");
                }
                else if (col < row)
                {
                    Console.Write("~");
                }
                else
                {
                    Console.Write(Letter);
                }
            }

            Console.WriteLine();
        }

        // Midline
        for (int col = 0; col < n; col++)
        {
            if (col != halfN)
            {
                Console.Write("-");
            }
            else
            {
                Console.Write(Letter);
            }
        }

        Console.WriteLine();

        // Lower-half
        for (int row = 0; row < halfN; row++)
        {
            // Lower-left
            for (int col = halfN; col >= 0; col--)
            {
                if (col == row + 1)
                {
                    Console.Write(Letter);
                }
                else if (col < row + 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("~");
                }
            }

            // Lower-right
            for (int col = 0; col < halfN; col++)
            {
                if (col == row)
                {
                    Console.Write(Letter);
                }
                else if (col < row + 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("~");
                }
            }

            Console.WriteLine();
        }
    }
}
