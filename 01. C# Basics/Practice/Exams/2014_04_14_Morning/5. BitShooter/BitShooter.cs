using System;
using System.Text;

class BitShooter
{
    struct Shot
    {
        public int Center;
        public int Size;
    }

    struct Impact
    {
        public int StartIndex;
        public int Size;
        public string Content;
    }

    static void Main()
    {
        // Getting and parsing input
        ulong field = ulong.Parse(Console.ReadLine());
        string fieldBits = Convert.ToString((long)field, 2).PadLeft(64, '0');

        fieldBits = Reverse(fieldBits);

        Shot[] shots = new Shot[3];
        Impact[] impacts = new Impact[3];

        for (int index = 0; index < shots.Length; index++)
        {
            string shotDataLine = Console.ReadLine();
            string[] splittedShotData = shotDataLine.Split(' ');

            shots[index].Center = int.Parse(splittedShotData[0]);
            shots[index].Size = int.Parse(splittedShotData[1]);

            impacts[index].StartIndex = shots[index].Center - (shots[index].Size / 2);
            impacts[index].Size = shots[index].Size;

            // Fix impact if it gets outside the boundaries of the field to the right
            if (impacts[index].StartIndex < 0)
            {
                impacts[index].Size = impacts[index].Size + impacts[index].StartIndex;
                impacts[index].StartIndex = 0;
            }
            // Fix impact if it gets outside the boundaries of the field to the left
            if (impacts[index].StartIndex + impacts[index].Size - 1 > 63)
            {
                impacts[index].Size = impacts[index].Size - (impacts[index].StartIndex + impacts[index].Size - 64);
            }
        }

        for (int impactCounter = 0; impactCounter < impacts.Length; impactCounter++)
        {
            for (int zeroesCounter = 0; zeroesCounter < impacts[impactCounter].Size; zeroesCounter++)
            {
                impacts[impactCounter].Content += "0";
            }
        }

        StringBuilder builder = new StringBuilder(fieldBits);

        foreach (Impact impact in impacts)
        {
            builder.Remove(impact.StartIndex, impact.Size);
            builder.Insert(impact.StartIndex, impact.Content);
        }

        fieldBits = builder.ToString();
        fieldBits = Reverse(fieldBits);

        string rightHalf = fieldBits.Substring(32, 32);
        string leftHalf = fieldBits.Substring(0, 32);

        int leftBitsCount = 0;
        int rightBitsCount = 0;
        for (int index = 0; index < leftHalf.Length; index++)
        {
            if (leftHalf[index] == '1')
            {
                leftBitsCount++;
            }
            if (rightHalf[index] == '1')
            {
                rightBitsCount++;
            }
        }

        Console.WriteLine("left: {0}", leftBitsCount);
        Console.WriteLine("right: {0}", rightBitsCount);
    }

    static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }
}