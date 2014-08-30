using System;

class Sunglasses
{
    static void Main()
    {
        int rowCount = int.Parse(Console.ReadLine());
        int colCount = 0;
        int middleRow = (int)Math.Ceiling((decimal)rowCount / 2);

        // First glass
        for (int row = 1; row <= rowCount; row++)
        {
            colCount = rowCount * 2;

            for (int col = 1; col <= colCount; col++)
            {
                if (col != 1 && col != colCount && row != 1 && row != rowCount)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write("*");
                }
            }

            for (int col = 0; col < rowCount; col++)
            {
                if (row != middleRow)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("|");
                }
            }

            for (int col = 1; col <= colCount; col++)
            {
                if (col != 1 && col != colCount && row != 1 && row != rowCount)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}
