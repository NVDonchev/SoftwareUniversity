using System;

class BitsExchange
{
    static void Main()
    {
        uint number = 4294901775;
        byte leftBitsStartingLocation = 24;
        byte rightBitsStartingLocation = 3;

        uint halfDone = MoveBitsLeft(number, leftBitsStartingLocation, rightBitsStartingLocation);

        uint finalNumber = MoveBitsRight(number, halfDone, leftBitsStartingLocation, rightBitsStartingLocation);

        Console.WriteLine("Initial Number:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("\nFinal Number:");
        Console.WriteLine(Convert.ToString(finalNumber, 2).PadLeft(32, '0'));

    }

    public static uint MoveBitsLeft(uint number, byte leftBitsStartingLocation, byte rightBitsStartingLocation)
    {
        uint mask;
        uint result = 0;

        // First half - move bits from right to left
        for (byte currentBit = 0; currentBit < 3; currentBit++)
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

    public static uint MoveBitsRight(uint number, uint halfDoneNumber, byte leftBitsStartingLocation, byte rightBitsStartingLocation)
    {
        uint mask;
        uint result = 0;

        // First half - move bits from left to right
        for (byte currentBit = 0; currentBit < 3; currentBit++)
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
}