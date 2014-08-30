using System;
using System.Collections.Generic;
using System.Text;

class NakovsMatching
{
    static void Main()
    {
        string firstWordInput = Console.ReadLine();
        string secondWordInput = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());

        List<string> possibleMatchesFirst = new List<string>();
        List<string> possibleMatchesSecond = new List<string>();
        List<string> matches = new List<string>();

        for (int index = 1; index < firstWordInput.Length; index++)
        {
            possibleMatchesFirst.Add(firstWordInput.Insert(index, "|"));
        }

        for (int index = 1; index < secondWordInput.Length; index++)
        {
            possibleMatchesSecond.Add(secondWordInput.Insert(index, "|"));
        }

        string[,] possibleMatchesFirstSplitted = new string[possibleMatchesFirst.Count, 2];

        for (int index = 0; index < possibleMatchesFirst.Count; index++)
        {
            string[] parts = possibleMatchesFirst[index].Split('|');
            possibleMatchesFirstSplitted[index, 0] = parts[0];
            possibleMatchesFirstSplitted[index, 1] = parts[1];
        }

        string[,] possibleMatchesSecondSplitted = new string[possibleMatchesSecond.Count, 2];

        for (int index = 0; index < possibleMatchesSecond.Count; index++)
        {
            string[] parts = possibleMatchesSecond[index].Split('|');
            possibleMatchesSecondSplitted[index, 0] = parts[0];
            possibleMatchesSecondSplitted[index, 1] = parts[1];
        }

        for (int firstIndex = 0; firstIndex < possibleMatchesFirstSplitted.GetLength(0); firstIndex++)
        {
            for (int secondIndex = 0; secondIndex < possibleMatchesSecondSplitted.GetLength(0); secondIndex++)
            {
                string firstLeftSeq = possibleMatchesFirstSplitted[firstIndex, 0];
                string firstRightSeq = possibleMatchesFirstSplitted[firstIndex, 1];
                string secondLeftSeq = possibleMatchesSecondSplitted[secondIndex, 0];
                string secondRightSeq = possibleMatchesSecondSplitted[secondIndex, 1];

                int firstLeftSum = 0;
                int firstRightSum = 0;
                int secondLeftSum = 0;
                int secondRightSum = 0;

                for (int ch = 0; ch < firstLeftSeq.Length; ch++)
                {
                    firstLeftSum += firstLeftSeq[ch];
                }
                for (int ch = 0; ch < firstRightSeq.Length; ch++)
                {
                    firstRightSum += firstRightSeq[ch];
                }
                for (int ch = 0; ch < secondLeftSeq.Length; ch++)
                {
                    secondLeftSum += secondLeftSeq[ch];
                }
                for (int ch = 0; ch < secondRightSeq.Length; ch++)
                {
                    secondRightSum += secondRightSeq[ch];
                }

                int nakovs = Math.Abs(firstLeftSum * secondRightSum - firstRightSum * secondLeftSum);

                if (nakovs <= d)
                {
                    string firstWord = possibleMatchesFirstSplitted[firstIndex, 0] + "|" + possibleMatchesFirstSplitted[firstIndex, 1];
                    string secondWord = possibleMatchesSecondSplitted[secondIndex, 0] + "|" + possibleMatchesSecondSplitted[secondIndex, 1];

                    string secondWordLeft = possibleMatchesFirstSplitted[firstIndex, 0] + "|" + possibleMatchesFirstSplitted[firstIndex, 1];
                    string secondWordRight = possibleMatchesSecondSplitted[secondIndex, 0] + "|" + possibleMatchesSecondSplitted[secondIndex, 1];

                    string match = string.Format("({0}) matches ({1}) by {2} nakovs", firstWord, secondWord, nakovs);
                    Console.WriteLine(match);
                }
            }
        }
    }
}
