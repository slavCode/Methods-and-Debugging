using System;

namespace NumbersInReversedOrder
{
    internal class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            PrintReversedNumber(number);
        }

        static void PrintReversedNumber(string number)
        {
            string reversedNumber = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                char currentChar = number[i];
                reversedNumber += currentChar;
            }

            Console.WriteLine(reversedNumber);
        }
    }
}
