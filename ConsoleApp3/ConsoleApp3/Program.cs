using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            string input = Console.ReadLine();
            float number;
            float.TryParse(input, out number);
            Console.WriteLine(number);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
