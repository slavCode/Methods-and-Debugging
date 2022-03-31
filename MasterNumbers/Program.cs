using System;

namespace MasterNumbers
{
    internal class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < inputNumber; i++)
            {
                if (/*IsPalindrome(i) && */SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            int counter = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    if (i == j) counter++;
                    if (counter > 1) return true;
                }
            }
            return false;
        }

        private static bool SumOfDigits(int num)
        {
            string numAsString = num.ToString();
            int sum = 0;
            for (int i = 0; i < numAsString.Length; i++)
            {
                sum = sum + i % 10;
            }
            if (sum % 7 == 0) return true;
            return false;
        }

        private static bool IsPalindrome(int num)
        {
            string numAsString = num.ToString();
            char[] numAsStringArr = numAsString.ToCharArray();

            string reversedString = String.Empty;
            for (int i = numAsStringArr.Length - 1; i > -1; i--)
            {
                reversedString += numAsStringArr[i];
            }

            if (numAsString != reversedString)
            {
                return false;
            }
            return true;
        }
    }
}
