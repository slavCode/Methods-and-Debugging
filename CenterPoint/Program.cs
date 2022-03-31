using System;

namespace CenterPoint
{
    internal class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointToCenter = GetClosestPoint(x1, y1, 0, 0);
            double secondPointToCenter = GetClosestPoint(x2, y2, 0, 0);

            PrintClosestToTheCenter(x1, y1, x2, y2, firstPointToCenter, secondPointToCenter);
        }

        public static void PrintClosestToTheCenter(double x1, double y1, double x2, double y2, double firstPointToCenter, double secondPointToCenter)
        {
            if (firstPointToCenter <= secondPointToCenter)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else Console.WriteLine($"({x2}, {y2})");
        }

        public static double GetClosestPoint(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
