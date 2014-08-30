//using System;
//using System.Text;

//class BitSifting
//{
//    private const int charsCount = 64;
//    private static int numberOfSieves;
//    private static string[] sievesAsString;

//    static void Main()
//    {
//        long numberAsString = long.Parse(Console.ReadLine());
//        numberOfSieves = int.Parse(Console.ReadLine());
//        sievesAsString = new string[numberOfSieves];
//        StringBuilder builder = new StringBuilder();

//        string letters = Convert.ToString(numberAsString, 2).PadLeft(charsCount, '0');

//        for (int index = 0; index < numberOfSieves; index++)
//        {
//            long bits = long.Parse(Console.ReadLine());
//            sievesAsString[index] = Convert.ToString(bits, 2).PadLeft(charsCount, '0');
//        }

//        for (int sieveCount = 0; sieveCount < numberOfSieves; sieveCount++)
//        {
//            string currentSieve = sievesAsString[sieveCount];
            
//            for (int ch = 0; ch < charsCount; ch++)
//            {
//                if (letters[ch] == '1' && currentSieve[ch] == '0')
//                {
//                    builder.Append('1');
//                }
//                else
//                {
//                    builder.Append('0');
//                }
//            }

//            letters = builder.ToString(); 
//            builder.Clear();
//        }

//        int counter = 0;

//        foreach (char ch in letters)
//        {
//            if (ch == '1')
//            {
//                counter++;
//            }
//        }

//        Console.WriteLine(counter);
//    }
//}