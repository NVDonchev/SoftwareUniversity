//using System;
//using System.Collections.Generic;
//using System.Text;

//class BitsInverter
//{
//    const int numberLength = 8;

//    static void Main()
//    {
//        int arrayLength = int.Parse(Console.ReadLine());
//        int stepLength = int.Parse(Console.ReadLine());
//        int[] numbers = new int[arrayLength];

//        string fullNumberAsString = string.Empty;
//        StringBuilder strBuilder = new StringBuilder();

//        for (int index = 0; index < arrayLength; index++)
//        {
//            numbers[index] = int.Parse(Console.ReadLine());
//            fullNumberAsString += Convert.ToString(numbers[index], 2).PadLeft(numberLength, '0');
//        }

//        strBuilder.Append(fullNumberAsString);

//        for (int position = 0; position < fullNumberAsString.Length; position += stepLength)
//        {
//            if (strBuilder[position] == '0')
//            {
//                strBuilder[position] = '1';
//            }
//            else
//            {
//                strBuilder[position] = '0';
//            }
//        }

//        List<int> outputNumbers = new List<int>();

//        for (int number = 0; number < arrayLength; number++)
//        {
//            char[] charArray = new char[numberLength];
//            strBuilder.CopyTo(0, charArray, 0, numberLength);
//            strBuilder.Remove(0, numberLength);

//            string token = new string(charArray);
//            outputNumbers.Add(Convert.ToInt32(token, 2));
//        }

//        foreach (int num in outputNumbers)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}