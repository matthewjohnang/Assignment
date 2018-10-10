using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i < 15001; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Please enter any key to exit..");
            Console.ReadKey();
        }
    }
}
