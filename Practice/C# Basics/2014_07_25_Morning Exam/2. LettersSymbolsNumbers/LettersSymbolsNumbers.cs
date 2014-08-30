using System;

class LettersSymbolsNumbers
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        string[] inputArray = new string[numberOfLines];

        for (int index = 0; index < numberOfLines; index++)
        {
            inputArray[index] = Console.ReadLine();
        }

        int lettersPointsSum = 0;
        int digitsPointsSum = 0;
        int symbolsPointsSum = 0;

        for (int line = 0; line < numberOfLines; line++)
        {
            string currentLineText = inputArray[line];

            for (int ch = 0; ch < currentLineText.Length; ch++)
            {
                if (Char.IsLetter(currentLineText[ch]))
                {
                    if (Char.IsLower(currentLineText[ch]))
                    {
                        lettersPointsSum += (currentLineText[ch] - 96) * 10;
                    }
                    if (Char.IsUpper(currentLineText[ch]))
                    {
                        lettersPointsSum += (currentLineText[ch] - 64) * 10;
                    }
                }
                else if (Char.IsDigit(currentLineText[ch]))
                {
                    int digit = int.Parse(currentLineText[ch].ToString());
                    digitsPointsSum += digit * 20;
                }
                else if (!Char.IsWhiteSpace(currentLineText[ch]))
                {
                    symbolsPointsSum += 200;
                }
            }
        }

        Console.WriteLine(lettersPointsSum);
        Console.WriteLine(digitsPointsSum);
        Console.WriteLine(symbolsPointsSum);
    }
}