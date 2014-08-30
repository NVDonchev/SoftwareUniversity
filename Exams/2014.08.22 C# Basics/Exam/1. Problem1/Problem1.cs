using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem1
{
    static void Main()
    {
        long[] bundles = new long[4];

        long legs = 0;
        long counter = 1;
        for (long bundle = 0; bundle < bundles.Length; bundle++)
        {
            bundles[bundle] = long.Parse(Console.ReadLine());
            legs += bundles[bundle] * counter;
            counter++;
        }

        long tableTops = long.Parse(Console.ReadLine());
        long tablesNeeded = long.Parse(Console.ReadLine());

        long topsLeft = tablesNeeded - tableTops;
        long legsLeft = (tablesNeeded * 4) - legs;

        long tablesMade = 0;

        long tablesForTheLegs = legs / 4;
        long tablesForTheTops = tableTops;

        if (tablesForTheLegs > tablesForTheTops)
        {
            tablesMade = tablesForTheTops;
        }
        else
        {
            tablesMade = tablesForTheLegs;
        }

        if (tablesMade < tablesNeeded)
        {
            if (legsLeft < 0)
            {
                legsLeft = 0;
            }

            Console.WriteLine("less: {0}", tablesMade - tablesNeeded);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsLeft, legsLeft);
        }
        else if (tablesMade > tablesNeeded)
        {
            Console.WriteLine("more: {0}", tablesMade - tablesNeeded);
            Console.WriteLine("tops left: {0}, legs left: {1}", Math.Abs(topsLeft), Math.Abs(legsLeft));
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
    }
}