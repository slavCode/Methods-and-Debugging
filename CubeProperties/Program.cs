using System;

namespace CubeProperties
{
    internal class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            GetFaceOfCube(side, parameter);
        }

        private static void GetFaceOfCube(double side, string parameter)
        {
            double result = 0;
            switch (parameter)
            {
                case "face":
                    result = Math.Sqrt((Math.Pow(side, 2)) * 2);
                    break;
                case "space":
                    result = Math.Sqrt((Math.Pow(side, 2)) * 3);
                    break;
                case "volume":
                    result = Math.Pow(side, 3);
                    break;
                case "area":
                    result = 6 * Math.Pow(side, 2);
                    break;
            }

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
