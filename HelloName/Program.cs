using System;

namespace HelloName
{
    internal class Program
    {
        static void Main()
        {
            var name = Console.ReadLine();
            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
