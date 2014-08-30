using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int num = 0; num < n; num++)
        {
            numbers[num] = int.Parse(Console.ReadLine());
        }

        string[] bitSeqences = new string[n];

        for (int num = 0; num < numbers.Length; num++)
        {
            bitSeqences[num] = Convert.ToString((int)numbers[num], 2).PadLeft(32, '0');
        }

        // Processing
        int leftDiagonals = 0;
        int verticals = 0;
        int rightDiagonals = 0;

        for (int seq = 0; seq < bitSeqences.Length - 1; seq++)
        {
            string currentSeq = bitSeqences[seq];
            string nextSeq = bitSeqences[seq + 1];

            for (int bit = 0; bit < currentSeq.Length; bit++)
            {
                // Counting verticals
                if (currentSeq[bit] == '1' && nextSeq[bit] == '1')
                {
                    verticals++;
                }
                // Counting left diagonals
                if (bit > 0 && currentSeq[bit] == '1' && nextSeq[bit - 1] == '1')
                {
                    leftDiagonals++;
                }
                if (bit < currentSeq.Length - 1 && currentSeq[bit] == '1' && nextSeq[bit + 1] == '1')
                {
                    rightDiagonals++;
                }
            }
        }

        Console.WriteLine(rightDiagonals);
        Console.WriteLine(leftDiagonals);
        Console.WriteLine(verticals);
    }
}