using System;

namespace ConsoleApp2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);
            Console.WriteLine(number);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
