using System;

class WineGlass
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int halfNum = num / 2;
        int stemLength;
        int rowConter = 0;

        // top-half
        for (int row = 0; row < halfNum; row++)
        {
            // top-left
            for (int col = 0; col < halfNum; col++)
            {
                if (col < row)
                {
                    Console.Write(".");
                }
                else if (col == row)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write("*");
                }
            }

            // top-right
            for (int col = 0; col < halfNum; col++)
            {
                if (col == halfNum - row - 1)
                {
                    Console.Write("/");
                }
                else if (col > halfNum - row - 1)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
            rowConter++;
        }

        // bottom-half
        if (num < 12)
        {
            stemLength = halfNum - 1;
        }
        else
        {
            stemLength = halfNum - 2;
        }


        for (int row = 0; row < stemLength; row++)
        {
            // bottom-left
            for (int col = 0; col < num; col++)
            {
                if (col == halfNum - 1 || col == halfNum)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
            rowConter++;
        }

        for (int row = rowConter; row < num; row++)
        {
            for (int col = 0; col < num; col++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
    }
}
