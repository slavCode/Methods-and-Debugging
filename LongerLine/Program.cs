using System;

namespace LongerLine
{
    internal class Program
    {
        static void Main()
        {
            //First Point
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //Second Point
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetClosestPoint(x1, y1, x2, y2);
            double secondLineLength = GetClosestPoint(x3, y3, x4, y4);

            if (firstLineLength >= secondLineLength)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }

            else Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
        }
        public static double GetClosestPoint(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
