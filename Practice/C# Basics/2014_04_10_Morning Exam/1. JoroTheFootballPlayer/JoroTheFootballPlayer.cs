using System;

public class JoroTheFootballPlayer
{
    public static void Main()
    {
        const decimal totalWeekends = 52;

        string isLeapAsString = Console.ReadLine();
        decimal holidaysCount = decimal.Parse(Console.ReadLine());
        decimal weekendsInHometown = decimal.Parse(Console.ReadLine());
        bool isLeap;

        if (isLeapAsString == "t")
        {
            isLeap = true;
        }
        else
        {
            isLeap = false;
        }

        decimal mysticalNumber = weekendsInHometown;

        decimal weekendsMinusHometown = totalWeekends - weekendsInHometown;
        decimal numberOfNormalPlays = (weekendsMinusHometown * 2) / 3;

        decimal numberOfHolidayPlays = holidaysCount / 2;
        decimal leapPlays = 0;

        if (isLeap)
        {
            leapPlays = 3;
        }

        decimal totalPlays = Math.Floor(numberOfNormalPlays + numberOfHolidayPlays + leapPlays + mysticalNumber);

        Console.WriteLine(totalPlays);
    }
}