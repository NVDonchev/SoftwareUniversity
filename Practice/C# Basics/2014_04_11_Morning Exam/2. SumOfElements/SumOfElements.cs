using System;

class SumOfElements
{
    static void Main()
    {
        string inputNumbersAsString = Console.ReadLine();

        string[] inputNumbersAsStringArray = inputNumbersAsString.Split(' ');
        int[] numbersArray = new int[inputNumbersAsStringArray.Length];

        for (int index = 0; index < inputNumbersAsStringArray.Length; index++)
        {
            numbersArray[index] = int.Parse(inputNumbersAsStringArray[index]);
        }

        bool sumFound = false;
        int diff = 0;

        for (int sumNumber = 0; sumNumber < numbersArray.Length; sumNumber++)
        {
            int sum = 0;

            for (int number = 0; number < numbersArray.Length; number++)
            {
                if (number != sumNumber)
                {
                    sum += numbersArray[number];
                }
            }

            if (sum == numbersArray[sumNumber])
            {
                Console.WriteLine("Yes, sum={0}", sum);
                sumFound = true;
                break;
            }
            else
            {
                int currentDiff = numbersArray[sumNumber] - sum;

                if (diff < currentDiff)
                {
                    diff = currentDiff;
                }
            }
        }

        if (!sumFound)
        {
            if (diff > 0)
            {
                Console.WriteLine("No, diff={0}", diff);
            }
            else
            {
                Console.WriteLine("No, diff=1");
            }
        }
    }
}
