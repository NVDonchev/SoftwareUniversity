using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int givenSum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool noNumber = true;
        int startingNumber = 111 + (diff * 2);

        int[] number = new int[3];

        for (int thirdPartOfNum = startingNumber; thirdPartOfNum < 777; thirdPartOfNum++)
        {
            number[2] = thirdPartOfNum;
            number[1] = number[2] - diff;
            number[0] = number[1] - diff;

            int sumOfDigits = 0;
            int digit = 0;

            string numAsString = string.Format("{0}{1}{2}", number[0], number[1], number[2]);
            int digitsToSum = int.Parse(numAsString);

            while (digitsToSum != 0)
            {
                digit = digitsToSum % 10;

                if (digit == 0 || digit > 7)
                {
                    break;
                }

                sumOfDigits += digit;
                digitsToSum /= 10;
            }

            if (sumOfDigits == givenSum && digit != 0 && digit <= 7)
            {
                string finalNum = string.Format("{0}{1}{2}", number[0], number[1], number[2]);
                noNumber = false;
                Console.WriteLine(finalNum);
            }
        }

        if (noNumber)
        {
            Console.WriteLine("No");
        }
    }
}
