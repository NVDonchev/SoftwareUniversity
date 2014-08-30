using System;
using System.Collections.Generic;
using System.Text;

class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        StringBuilder builder = new StringBuilder();
        List<string> listOfSeq = new List<string>();

        for (int counter = 0; counter < 4; counter++)
        {
            sum += n % 10;
            n = n / 10;
        }

        for (int first = 0; first < 6; first++)
        {
            for (int second = 0; second < 6; second++)
            {
                for (int third = 0; third < 6; third++)
                {
                    for (int fourth = 0; fourth < 6; fourth++)
                    {
                        for (int fifth = 0; fifth < 6; fifth++)
                        {
                            for (int sixth = 0; sixth < 6; sixth++)
                            {
                                if ((first * second * third * fourth * fifth * sixth) == sum)
                                {
                                    builder.Append(first + "" + second + "" + third + "" + fourth + "" + fifth + "" + sixth);
                                    listOfSeq.Add(builder.ToString());
                                    builder.Clear();
                                }
                            }
                        }
                    }
                }
            }
        }

        if (listOfSeq.Count > 0)
        {
            for (int seqCount = 0; seqCount < listOfSeq.Count; seqCount++)
            {
                string surrentSeq = listOfSeq[seqCount];

                for (int ch = 0; ch < surrentSeq.Length; ch++)
                {
                    switch (surrentSeq[ch])
                    {
                        case '0':
                            Console.Write("-----");
                            break;
                        case '1':
                            Console.Write(".----");
                            break;
                        case '2':
                            Console.Write("..---");
                            break;
                        case '3':
                            Console.Write("...--");
                            break;
                        case '4':
                            Console.Write("....-");
                            break;
                        case '5':
                            Console.Write(".....");
                            break;
                        default:
                            break;
                    }

                    Console.Write("|");
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
