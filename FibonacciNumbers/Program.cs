using System;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFibonacciNumber(n);
        }

        private static void PrintFibonacciNumber(int n)
        {

            int result = 1;
            int fibonacciBeforePrevious = 1;
            int fibonacciPrevious = 0;
            for (int i = 0; i <= n; i++)
            {
                result = fibonacciBeforePrevious + fibonacciPrevious;
                fibonacciBeforePrevious = fibonacciPrevious;
                fibonacciPrevious = result;
            }

            Console.WriteLine(result);
        }
    }
}
