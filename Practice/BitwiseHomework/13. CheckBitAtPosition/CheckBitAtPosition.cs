using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int number = 5;
        int position = 2;
        int mask = 1 << position;

        int result = number & mask;

        int bit = result >> position;

        bool trueOrFalse;

        if (bit == 1)
        {
            trueOrFalse = true;
        }
        else
        {
            trueOrFalse = false;
        }


        Console.WriteLine(trueOrFalse);
    }
}