using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = GetNumberOfItems();
            decimal[] price = GetPrice(numberOfItems);
            GetPriceWithTax(price);

        }

        static int GetNumberOfItems()
        {
            Console.Write("Please enter the number of items in your cart: ");
            int numberOfItems;
            string iNumberOfItems = Console.ReadLine();
            Int32.TryParse(iNumberOfItems, out numberOfItems);
            return numberOfItems;
        }

        static decimal[] GetPrice(int numbersOfItems)
        {
            decimal[] price = new decimal[numbersOfItems];
            int i;
            for (i = 0; i < price.Length; i++)
            {
                Console.Write("Enter the price for item {0}: ", i + 1);
                string iPrice = Console.ReadLine();
                decimal.TryParse(iPrice, out price[i]);
            }
            return price;
        }
        static void GetPriceWithTax(decimal[] price)
        {
            decimal itemWithTax = 0;
            int i = 1;
            foreach (var item in price)
            {
                itemWithTax = (item * .13m) + item;
                Console.WriteLine($"The price with tax on item {i++}: " + itemWithTax);
            }

        }
    
    }
}
