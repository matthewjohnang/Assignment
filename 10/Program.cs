using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
          	int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i != 10001);
            Console.WriteLine("Please enter any key to exit..");
            Console.ReadKey();
        }
    }
}
