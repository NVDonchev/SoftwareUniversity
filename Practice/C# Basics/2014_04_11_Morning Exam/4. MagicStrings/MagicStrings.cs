using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        const int numbersCount = 4;

        int diff = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[] { 1, 3, 4, 5 };
        List<string> matchingNumbers = new List<string>();

        for (int firstNum = 0; firstNum < numbersCount; firstNum++)
        {
            for (int secondNum = 0; secondNum < numbersCount; secondNum++)
            {
                for (int thirdNum = 0; thirdNum < numbersCount; thirdNum++)
                {
                    for (int fourthNum = 0; fourthNum < numbersCount; fourthNum++)
                    {
                        for (int fifthNum = 0; fifthNum < numbersCount; fifthNum++)
                        {
                            for (int sixthNum = 0; sixthNum < numbersCount; sixthNum++)
                            {
                                for (int seventhNum = 0; seventhNum < numbersCount; seventhNum++)
                                {
                                    for (int eightNum = 0; eightNum < numbersCount; eightNum++)
                                    {
                                        int firstHalfSum = numbersArray[firstNum] + numbersArray[secondNum] + numbersArray[thirdNum] + numbersArray[fourthNum];
                                        int secondHalfSum = numbersArray[fifthNum] + numbersArray[sixthNum] + numbersArray[seventhNum] + numbersArray[eightNum];

                                        int currentDiff = Math.Abs(firstHalfSum - secondHalfSum);

                                        if (currentDiff == diff)
                                        {
                                            string fullNumberSequence = numbersArray[firstNum].ToString() + numbersArray[secondNum].ToString() + numbersArray[thirdNum].ToString() + numbersArray[fourthNum].ToString() + numbersArray[fifthNum].ToString() + numbersArray[sixthNum].ToString() + numbersArray[seventhNum].ToString() + numbersArray[eightNum].ToString();

                                            matchingNumbers.Add(ConvertNumbersToLetters(fullNumberSequence));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (matchingNumbers.Count > 0)
        {
            matchingNumbers.Sort();

            foreach (var item in matchingNumbers)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    public static string ConvertNumbersToLetters(string sequenceOfNumbers)
    {
        StringBuilder builder = new StringBuilder();

        foreach (char ch in sequenceOfNumbers)
        {
            switch (ch)
            {
                case '1':
                    builder.Append("k");
                    break;
                case '3':
                    builder.Append("s");
                    break;
                case '4':
                    builder.Append("n");
                    break;
                case '5':
                    builder.Append("p");
                    break;
                default:
                    break;
            }
        }

        return builder.ToString();
    }
}