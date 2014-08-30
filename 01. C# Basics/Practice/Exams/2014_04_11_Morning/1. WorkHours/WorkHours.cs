using System;

class WorkHours
{
    static void Main()
    {
        const decimal bikingTime = 0.10m;

        int hoursNeeded = int.Parse(Console.ReadLine());
        decimal daysAvailable = decimal.Parse(Console.ReadLine());
        int percentProductivity = int.Parse(Console.ReadLine());

        decimal efficiantDaysAvailable = daysAvailable - (daysAvailable * bikingTime);
        decimal hoursAvailable = efficiantDaysAvailable * 12;
        int efficiantHoursAvailable = (int)(hoursAvailable * (percentProductivity / 100m));

        int hourDifference = efficiantHoursAvailable - hoursNeeded;

        if (hourDifference >= 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine(hourDifference);
    }
}