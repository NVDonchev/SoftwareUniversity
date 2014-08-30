using System;

class HouseWithWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int halfN = n / 2;
        int colsCount = (n * 2) - 1;

        // Roof-part
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < colsCount; col++)
            {
                if (col + 1 == n - row || col + 1 == n + row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }

        // A line
        for (int col = 0; col < colsCount; col++)
        {
            Console.Write("*");
        }

        Console.WriteLine();

        // The window part
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < colsCount; col++)
            {
                if (row < n / 4 || row >= n - (n / 4))
                {
                    if (col == 0 || col == colsCount - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    if (col == 0 || col == colsCount - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (col <= halfN || col > colsCount - halfN - 2)
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
            }

            Console.WriteLine();
        }

        // A line
        for (int col = 0; col < colsCount; col++)
        {
            Console.Write("*");
        }
    }
}
