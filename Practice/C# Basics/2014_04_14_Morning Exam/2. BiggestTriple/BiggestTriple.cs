using System;
using System.Collections.Generic;
using System.Text;

class BiggestTriple
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        List<string> content = new List<string>();
        List<int> sum = new List<int>();
        content.Add(string.Empty);
        sum.Add(0);

        int sequenceCounter = 1;
        int sequencesIndex = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            content[sequencesIndex] += numbers[index] + " ";
            sum[sequencesIndex] += int.Parse(numbers[index]);

            if (sequenceCounter < 3)
            {
                sequenceCounter++;
            }
            else if (index < numbers.Length - 1)
            {
                sequenceCounter = 1;
                sequencesIndex++;

                content.Add(string.Empty);
                sum.Add(0);
            }
        }

        int bestSumIndex = 0;
        int bestSum = int.MinValue;

        for (int counter = 0; counter < sum.Count; counter++)
        {
            if (bestSum < sum[counter])
            {
                bestSum = sum[counter];
                bestSumIndex = counter;
            }
        }

        Console.WriteLine(content[bestSumIndex]);
    }
}
