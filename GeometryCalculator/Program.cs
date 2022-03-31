using System;

namespace GeometryCalculator
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double area = GetAreaByType(type);

            Console.WriteLine(area);
        }

        private static double GetAreaByType(string type)
        {
            double area = 0;
            switch (type)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = (triangleSide * triangleHeight) / 2;
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    area = squareSide * squareSide;
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    area = rectangleWidth * rectangleHeight;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    break;
            }
            return Math.Round(area, 2);
        }
    }
}
