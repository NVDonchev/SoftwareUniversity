using System;

class BitsInverter
{
    const int numberLength = 8;

    static void Main()
    {
        // Getting the input
        int arrayLength = int.Parse(Console.ReadLine());
        int stepLength = int.Parse(Console.ReadLine());
        int[] numbers = new int[arrayLength];

        for (int index = 0; index < arrayLength; index++)
        {
            numbers[index] = int.Parse(Console.ReadLine());
        }

        // Processing
        int stepCounter = 0;
        int[] outputNumbers = new int[arrayLength];
        bool isNumberSame;

        numbers[0] = InvertBit(numbers[0], 0);

        for (int number = 0; number < arrayLength; number++)
        {
            isNumberSame = false;

            for (int bit = 0; bit < numberLength; bit++)
            {
                stepCounter++;

                if (stepCounter == stepLength)
                {
                    int bitPosition;

                    if (stepLength > numberLength)
                    {
                        bitPosition = stepLength - (number * numberLength);
                    }
                    else
                    {
                        bitPosition = (number * numberLength) - stepLength;
                    }

                    numbers[number] = InvertBit(numbers[number], bitPosition);
                    stepCounter = 0;
                }

                isNumberSame = true;
            }
        }

        for (int number = 0; number < arrayLength; number++)
        {
            Console.Write(Convert.ToString(numbers[number], 2).PadLeft(8, '0') + " ");
        }
    }

    private static int InvertBit(int number, int bitPosition)
    {
        byte mask = 1 << numberLength - 1;
        mask = (byte)(mask >> bitPosition);

        int currentBit = number & mask;

        if (currentBit == 0)
        {
            return number | mask;
        }
        else
        {
            mask = (byte)~mask;
            return number & mask;
        }
    }
}
