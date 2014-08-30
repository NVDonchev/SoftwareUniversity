using System;
using System.Text;

class ChangeEvenBits
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbersLength = new int[numbersCount];
        for (int num = 0; num < numbersCount; num++)
        {
            numbersLength[num] = Convert.ToString(int.Parse(Console.ReadLine()), 2).Length;
        }
        ulong l = ulong.Parse(Console.ReadLine());
        string lBin = Convert.ToString((long)l, 2).PadLeft(64, '0');
        lBin = Reverse(lBin);

        StringBuilder builder = new StringBuilder(lBin);

        int changeCounter = 0;
        for (int number = 0; number < numbersLength.Length; number++)
        {
            for (int evenPos = 0; evenPos < numbersLength[number] * 2; evenPos += 2)
            {
                if (lBin[evenPos] == '0')
                {
                    builder[evenPos] = '1';
                    changeCounter++;
                }
            }

            lBin = builder.ToString();
        }

        lBin = Reverse(lBin);

        Console.WriteLine(Convert.ToInt64(lBin, 2));
        Console.WriteLine(changeCounter);
    }

    static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }
}
