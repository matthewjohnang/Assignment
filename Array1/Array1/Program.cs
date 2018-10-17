using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal[] height = GetHeightOfStudents();

            decimal averageHeight = GetAverageHeight(height);
            Console.WriteLine("The average height is: " + averageHeight);

            decimal above = GetAboveAverage(height, averageHeight);
            Console.WriteLine("There are {0} students above the average height.", above);

            decimal below = GetBelowAverage(height, averageHeight);
            Console.WriteLine("There are {0} students below the average height.", below);

        }

        static decimal[] GetHeightOfStudents()
        {
            decimal[] height;
            height = new decimal[10];

            for (int i = 0; i < height.Length; i++)
            {
                Console.Write("Enter the height for student {0}: ", i + 1);
                String iStudentHeight = Console.ReadLine();
                decimal.TryParse(iStudentHeight, out height[i]);
            }
            
            return height;
        }

        static decimal GetAverageHeight(decimal[] height)
        {
            decimal sum = 0;
            foreach (var item in height)
            {
                sum += item;
            }
            decimal averageHeight = sum / 10;
            return averageHeight;
        }
        
        static decimal GetAboveAverage(decimal[] height, decimal averageHeight)
        {
            decimal above = 0;
            foreach (var item in height)
            {
                if (item > averageHeight)
                {
                    above += 1;
                }
            }
            return above;
        }

        static decimal GetBelowAverage(decimal[] height, decimal averageHeight)
        {
            decimal below = 0;
            foreach (var item in height)
            {
                if (item < averageHeight)
                {
                    below += 1;
                }
            }
            return below;
        }



    }
}
