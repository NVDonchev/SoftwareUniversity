using System;

class MelonsAndWatermelons
{
    struct DayFood
    {
        public int WatermelonsCount;
        public int MelonsCount;
    }

    static void Main()
    {
        int startingDay = int.Parse(Console.ReadLine()) - 1;
        int daysCount = int.Parse(Console.ReadLine());

        DayFood[] daysFood = new DayFood[]
        {
            new DayFood { WatermelonsCount = 1, MelonsCount = 0 },
            new DayFood { WatermelonsCount = 0, MelonsCount = 2 },
            new DayFood { WatermelonsCount = 1, MelonsCount = 1 },
            new DayFood { WatermelonsCount = 2, MelonsCount = 0 },
            new DayFood { WatermelonsCount = 2, MelonsCount = 2 },
            new DayFood { WatermelonsCount = 1, MelonsCount = 2 },
            new DayFood { WatermelonsCount = 0, MelonsCount = 0 },
        };

        int watermelonsEaten = 0;
        int melonsEaten = 0;
        int dayOfWeek = startingDay - 1;

        for (int day = 0; day < daysCount; day++)
        {
            if (dayOfWeek < 6)
            {
                dayOfWeek++;
            }
            else
            {
                dayOfWeek = 0;
            }

            watermelonsEaten += daysFood[dayOfWeek].WatermelonsCount;
            melonsEaten += daysFood[dayOfWeek].MelonsCount;
        }

        if (watermelonsEaten > melonsEaten)
        {
            Console.WriteLine("{0} more watermelons", watermelonsEaten - melonsEaten);
        }
        else if (melonsEaten > watermelonsEaten)
        {
            Console.WriteLine("{0} more melons", melonsEaten - watermelonsEaten);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}" , melonsEaten);
        }
    }
}