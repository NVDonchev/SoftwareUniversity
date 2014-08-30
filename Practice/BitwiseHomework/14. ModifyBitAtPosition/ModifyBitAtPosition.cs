using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        int number = 5;
        int position = 2;
        int bitToWrite = 0;
        int result;
        int mask;

        if (bitToWrite == 0)
        {
            mask = ~(1 << position);
            result = number & mask;
        }
        else
        {
            mask = 1 << position;
            result = number | mask;
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
    }
}
