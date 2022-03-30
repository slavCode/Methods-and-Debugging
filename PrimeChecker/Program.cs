using System;

namespace PrimeChecker
{
    internal class Program
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            bool isPrime = IsPrimeNumber(num);

            Console.WriteLine(isPrime);
        }

        private static bool IsPrimeNumber(long num)
        {
            if (num == 0 || num == 1) return false;
            bool isPrime = true;
            for (long divider = 2; divider <= Math.Sqrt(num); divider++)
            {
                bool isDivided = num % divider == 0;

                if (isDivided)
                {
                    isPrime = false;
                    return isPrime;
                }
            }

            return isPrime;
        }
    }
}
