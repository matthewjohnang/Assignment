using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            string input = Console.ReadLine();
            int n;
            Int32.TryParse(input, out n);
            var sum = (n*(n+1))/2;
 			Console.WriteLine(sum);
           

           

        }
    }
}
