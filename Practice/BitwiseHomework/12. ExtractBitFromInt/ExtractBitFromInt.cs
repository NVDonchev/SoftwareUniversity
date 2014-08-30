using System;

class ExtractBitFromInt
{
    static void Main()
    {
        int number = 5;
        int position = 2;
        int mask = 1 << position;

        int result = number & mask;

        int bit = result >> position;

        Console.WriteLine(bit);
    }
}