using System;

class BitsExchange
{
    private static int leftBitsStartingLocation = -1;
    private static byte rightBitsStartingLocation = 0;
    private static byte bitSequenceLength = 33;

    private static byte fullNumberLength = 32;

    static void Main()
    {
        uint number = 3333333333;

        Console.WriteLine("Initial Number:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        if (!IsOutOfRange() && !IsOverlapping())
        {
            uint halfDone = MoveBitsLeft(number);
            uint finalNumber = MoveBitsRight(number, halfDone);

            Console.WriteLine(Convert.ToString(finalNumber, 2).PadLeft(32, '0'));
            Console.WriteLine();
            Console.WriteLine(number);
            Console.WriteLine(finalNumber);
        }
        else
        {
            if (IsOverlapping())
            {
                Console.WriteLine("out of range");
            }
            else
            {
                Console.WriteLine("overlapping");
            }
        }
    }

    public static uint MoveBitsLeft(uint number)
    {
        uint mask;
        uint result = 0;

        // First half - move bits from right to left
        for (byte currentBit = 0; currentBit < bitSequenceLength; currentBit++)
        {
            uint newMask = 1;
            int currentBitPosition = rightBitsStartingLocation + currentBit;
            int currentPositionsToMove = leftBitsStartingLocation + currentBit;

            // Extract bit
            mask = (uint)1 << currentBitPosition;
            result = number & mask;
            uint bit = result >> currentBitPosition;

            // Move bit to position and apply
            if (bit == 0)
            {
                newMask = newMask << currentPositionsToMove;
                newMask = ~newMask;
                result = number & newMask;
            }
            else
            {
                newMask = newMask << currentPositionsToMove;
                result = number | newMask;
            }

            number = result;
        }

        return result;
    }

    public static uint MoveBitsRight(uint number, uint halfDoneNumber)
    {
        uint mask;
        uint result = 0;

        // First half - move bits from left to right
        for (byte currentBit = 0; currentBit < bitSequenceLength; currentBit++)
        {
            uint newMask = 1;
            int currentBitPosition = leftBitsStartingLocation + currentBit;
            int currentPositionsToMove = rightBitsStartingLocation + currentBit;

            // Extract bit
            mask = (uint)1 << currentBitPosition;
            result = number & mask;
            uint bit = result >> currentBitPosition;

            // Move bit to position and apply
            if (bit == 0)
            {
                newMask = newMask << currentPositionsToMove;
                newMask = ~newMask;
                result = halfDoneNumber & newMask;
            }
            else
            {
                newMask = newMask << currentPositionsToMove;
                result = halfDoneNumber | newMask;
            }

            halfDoneNumber = result;
        }

        return result;
    }

    public static bool IsOverlapping()
    {
        if (rightBitsStartingLocation > leftBitsStartingLocation)
        {
            if (leftBitsStartingLocation + bitSequenceLength >= rightBitsStartingLocation)
            {
                return true;
            }
        }
        else
        {
            if (rightBitsStartingLocation + bitSequenceLength >= leftBitsStartingLocation)
            {
                return true;
            }
        }

        return false;
    }

    public static bool IsOutOfRange()
    {
        int rightBitsEndingLocation = rightBitsStartingLocation + bitSequenceLength;
        int leftBitsEndingLocation = leftBitsStartingLocation + bitSequenceLength;

        if (rightBitsStartingLocation < 0 || leftBitsStartingLocation < 0)
        {
            return true;
        }
        else
        {
            if (rightBitsEndingLocation > fullNumberLength || leftBitsEndingLocation > fullNumberLength)
            {
                return true;
            }
        }

        return false;
    }
}