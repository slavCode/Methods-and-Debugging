using System;

namespace MaxMethod
{
    internal class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int maximalOfFirstAndSecond = GetMax(firstNum, secondNum);
            int maximal = GetMax(maximalOfFirstAndSecond, thirdNum);

            Console.WriteLine(maximal);
        }
        private static int GetMax(int a, int b)
        {
            int bigger = Math.Max(a, b);
            return bigger;
        }
    }
}
