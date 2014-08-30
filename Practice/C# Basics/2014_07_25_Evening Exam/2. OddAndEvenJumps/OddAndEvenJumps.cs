using System;

class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().Replace(" ", string.Empty);
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        string oddLetters = string.Empty;
        string evenLetters = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if ((i + 1) % 2 != 0)
            {
                oddLetters += char.ToLower(input[i]);
            }
            else
            {
                evenLetters += char.ToLower(input[i]);
            }
        }

        long oddResult = 0;

        for (int ch = 0; ch < oddLetters.Length; ch++)
        {
            if ((ch + 1) % oddJump == 0)
            {
                oddResult *= oddLetters[ch];
            }
            else
            {
                oddResult += oddLetters[ch];
            }
        }

        long evenResult = 0;

        for (int ch = 0; ch < evenLetters.Length; ch++)
        {
            if ((ch + 1) % evenJump == 0)
            {
                evenResult *= evenLetters[ch];
            }
            else
            {
                evenResult += evenLetters[ch];
            }
        }

        string oddResultHex = Convert.ToString(oddResult, 16).ToUpper();
        string evenResultHex = Convert.ToString(evenResult, 16).ToUpper();

        Console.WriteLine("Odd: {0}", oddResultHex);
        Console.WriteLine("Even: {0}", evenResultHex);
    }
}