using System;

class ExtractBitThree
{
    static void Main()
    {
        int number = 5;
        int mask = 1 << 3;

        int result = number & mask;

        int bit = result >> 3;

        Console.WriteLine(bit);
    }
}