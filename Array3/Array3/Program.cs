using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat = new string[5, 3];

            mat[0, 0] = "204-555-555";
            mat[0, 1] = "204-123-456";
            mat[0, 2] = "204-999-9999";

            mat[1, 0] = "(919) 802-5452";
            mat[1, 1] = "(391) 925-1176";
            mat[1, 2] = "(806) 561-7242";

            mat[2, 0] = "(573) 409-1226";
            mat[2, 1] = "(480) 874-3736";
            mat[2, 2] = "(590) 315-4119";

            mat[3, 0] = "(633) 610-2275";
            mat[3, 1] = "(312) 515-5440";
            mat[3, 2] = "(860) 323-6077";

            mat[4, 0] = "(972) 876-7248";
            mat[4, 1] = "(785) 831-9711";
            mat[4, 2] = "(543) 484-2075";

            Console.Write("Please Enter the index of the contact: ");
            int index;
            string iIndex = Console.ReadLine();
            Int32.TryParse(iIndex, out index);

            int i = index;

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Contact {0}, phone number {1} values {2}", i, j + 1, mat[i, j]);
            }

        }
    }
}
