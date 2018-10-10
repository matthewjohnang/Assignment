using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i<16; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Please enter any key to exit");
            Console.ReadKey();
        }
    }
}
