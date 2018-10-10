using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "hello";
            
            for (int i = 1; i <201; i++)
            {

                Console.WriteLine(message);
            }
            Console.WriteLine("Please enter any key to exit");
            Console.ReadKey();


        }
    }
}
