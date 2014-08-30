using System;

class BitSifting
{
    private const int bitsCount = 64;
    private static int numberOfSieves;
    private static ulong[] sieves;

    static void Main()
    {
        ulong bits = ulong.Parse(Console.ReadLine());
        numberOfSieves = int.Parse(Console.ReadLine());
        sieves = new ulong[numberOfSieves];

        for (int index = 0; index < numberOfSieves; index++)
        {
            sieves[index] = ulong.Parse(Console.ReadLine());
        }

        ulong sievedBits = SieveBits(bits);
        int bitsCount = CountBits(sievedBits);

        Console.WriteLine(bitsCount);
    }

    public static ulong SieveBits(ulong bits)
    {
        for (int sieveNumber = 0; sieveNumber < numberOfSieves; sieveNumber++)
        {
            for (int bitPosition = 0; bitPosition < bitsCount; bitPosition++)
            {
                int sourceBit = ReadBit(bits, bitPosition);
                int destinationBit = ReadBit(sieves[sieveNumber], bitPosition);
                sieves[sieveNumber] = WriteBit(sieves[sieveNumber], sourceBit, destinationBit, bitPosition);
            }

            bits = sieves[sieveNumber];
        }

        return bits;
    }

    public static int ReadBit(ulong bits, int position)
    {
        ulong mask = 1UL << position;

        int bit = (int)((bits & mask) >> position);

        return bit;
    }

    public static ulong WriteBit(ulong writeTo, int sourceBit, int destinationBit, int position)
    {
        ulong mask = 1UL << position;
        ulong resultBits = 0;

        if (destinationBit == 0)
        {
            if (sourceBit == 0)
            {
                mask = ~mask;
                resultBits = writeTo & mask;
            }
            else
            {
                resultBits = writeTo | mask;
            }

            return resultBits;
        }
        else
        {
            mask = ~mask;
            resultBits = writeTo & mask;

            return resultBits;
        }

    }

    public static int CountBits(ulong bits)
    {
        ulong mask;
        int counter = 0;

        for (int position = 0; position < bitsCount; position++)
        {
            mask = 1UL << position;
            int bit = (int)((bits & mask) >> position);

            if (bit == 1)
            {
                counter++;
            }
        }

        return counter;
    }
}