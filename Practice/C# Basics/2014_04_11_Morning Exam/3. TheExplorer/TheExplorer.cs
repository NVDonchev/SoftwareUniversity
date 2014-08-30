using System;

class TheExplorer
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int halfWidth = width / 2;
        int halfHeight = width / 2;
        int starPlace;

        for (int row = 0; row < halfHeight; row++)
        {
            // First quarter
            starPlace = halfWidth - row;

            for (int col = 0; col <= halfWidth; col++)
            {
                if (col == starPlace)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            // Second quarter
            starPlace = row;

            for (int col = 1; col <= halfWidth; col++)
            {
                if (col == starPlace)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();
        }

        for (int row = 0; row <= halfHeight; row++)
        {
            // Third quarter
            starPlace = row;

            for (int col = 0; col <= halfWidth; col++)
            {
                if (col == starPlace)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            // Fourth quarter
            starPlace = halfWidth - row;

            for (int col = 1; col <= halfWidth; col++)
            {
                if (col == starPlace)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();

            // Third quarter

        }
    }
}
