using System;

public class HalfSum
{
    public static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine()) * 2;
        int firstSum = 0;
        int secondSum = 0;

        for (int i = 0; i < numbersCount / 2; i++)
        {
            firstSum += int.Parse(Console.ReadLine());
        }

        for (int i = numbersCount / 2; i < numbersCount; i++)
        {
            secondSum += int.Parse(Console.ReadLine());
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum=" + firstSum);
        }
        else
        {
            int diff = Math.Abs(firstSum - secondSum);

            Console.WriteLine("No, diff=" + diff);
        }
    }
}