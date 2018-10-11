using System;

namespace shoppingcart
{
    class ItemInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Item Name:");
            string itemName = Console.ReadLine();   

            Console.WriteLine("Please enter the Item Price:");
           	string iItemPrice = Console.ReadLine();
           	int itemPrice;
           	int.TryParse(iItemPrice, out itemPrice);
         
            Console.WriteLine("Please enter the Tax Rate (Whole Number):");
            string iTaxRate = Console.ReadLine();
            float taxRate;
            float.TryParse(iTaxRate, out taxRate);


            float amountOfTax = ((taxRate / 100) * itemPrice);
            float totalAmount = (itemPrice + amountOfTax);


            Console.Write("Item Name: ");
            Console.WriteLine(itemName);
            Console.Write("Item Price: ");
            Console.WriteLine(itemPrice);
            Console.Write("Item Amount of Tax: ");
            Console.WriteLine(amountOfTax);
            Console.Write("Item Total Price: ");
            Console.WriteLine(totalAmount);


            Console.WriteLine("Please enter the amount of money");
            string iPayment = Console.ReadLine();
           	float payment;
           	float.TryParse(iPayment, out payment);

           	if (payment >= totalAmount)
           	{
           		Console.WriteLine("Payment: " + payment);
           		float change = payment - totalAmount;
           		Console.WriteLine("Your change is {0}",change);
           		Console.WriteLine("Thank you for visiting the store!");
           	}
           	else
           	{
           		Console.WriteLine("Insufficient fund.");
           	}

        }
    }

}
