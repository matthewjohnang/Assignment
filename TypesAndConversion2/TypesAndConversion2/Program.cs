using System;

namespace TypesAndConversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = GetFirstName();
            string secondName = GetSecondName();
            string result = GetFirst (firstName, secondName);
            Console.WriteLine("The name " + result + " is first.");
        }

        static string GetFirstName()
        {
            Console.WriteLine("Please enter first name:");
            String firstName = Console.ReadLine();
            return firstName;
        }
        static string GetSecondName()
        {
            Console.WriteLine("Please enter second name:");
            String secondName = Console.ReadLine();
            return secondName;
        }
        static string GetFirst(string firstName, string secondName)
        {
            int i = 0;
            while ((int)firstName[i] == (int)secondName[i])
            {
                i++;
            }

            if ((int)firstName[i] < (int)secondName[i])
            {
                return firstName;
            }
            else
            {
                return secondName;
            }

        }

    }
}


