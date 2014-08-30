using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int doubleN = n * 2;
        int tripleN = n * 3;
        int halfN = n / 2;

        // Top
        for (int row = 0; row <= halfN; row++)
        {
            for (int col = 0; col < tripleN; col++)
            {
                if (row == 0)
                {
                    if (col < n || col >= doubleN)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                else if (row == halfN)
                {
                    if (col <= n - row || col >= tripleN - n + row - 1)
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
                    if (col == n - row || col == tripleN - n + row - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }

            Console.WriteLine();
        }

        // Middle
        for (int row = 0; row < halfN - 1; row++)
        {
            for (int col = 0; col < tripleN; col++)
            {
                if (row != halfN - 2)
                {
                    if (col == 0 || col == tripleN - 1)
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
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }

        // Bottom
        for (int row = 0; row < halfN - 1; row++)
        {
            int lightCounter = 0;

            for (int col = 0; col < tripleN; col++)
            {
                if (row != halfN - 2)
                {
                    if (col < halfN || col > tripleN - halfN)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        if (col == halfN || col == n || col == tripleN - (halfN + 1) || col == tripleN - (n + 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }

                        lightCounter++;
                    }
                }
                else
                {
                    if (col >= halfN && col <= n)
                    {
                        Console.Write("*");
                    }
                    else if (col >= tripleN - n - 1 && col < tripleN - halfN)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}