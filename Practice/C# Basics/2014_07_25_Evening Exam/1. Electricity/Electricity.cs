using System;

class Electricity
{
    struct ElConsumer
    {
        public int Lamps;
        public int Computers;
    }

    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        int totalFlats = floors * flats;
        string[] timeSplitted = Console.ReadLine().Split(':');
        int time = int.Parse(timeSplitted[0]);

        ElConsumer[] elConsumers = new ElConsumer[3]
        {
            new ElConsumer { Lamps = 2, Computers = 2 },
            new ElConsumer { Lamps = 7, Computers = 6 },
            new ElConsumer { Lamps = 1, Computers = 8 },
        };

        decimal lampsConsume = 0;
        decimal computersConsume = 0;

        if (time >= 14 && time < 19)
        {
            for (int lamps = 0; lamps < elConsumers[0].Lamps; lamps++)
            {
                lampsConsume += 100.53m;
            }
            for (int computers = 0; computers < elConsumers[0].Computers; computers++)
            {
                computersConsume += 125.90m;
            }
        }
        else if (time >= 19 && time <= 23)
        {
            for (int lamps = 0; lamps < elConsumers[1].Lamps; lamps++)
            {
                lampsConsume += 100.53m;
            }
            for (int computers = 0; computers < elConsumers[1].Computers; computers++)
            {
                computersConsume += 125.90m;
            }
        }
        if (time >= 0 && time < 9)
        {
            for (int lamps = 0; lamps < elConsumers[2].Lamps; lamps++)
            {
                lampsConsume += 100.53m;
            }
            for (int computers = 0; computers < elConsumers[2].Computers; computers++)
            {
                computersConsume += 125.90m;
            }
        }

        Console.WriteLine("{0} Watts", Math.Floor((lampsConsume + computersConsume) * totalFlats));
    }
}
