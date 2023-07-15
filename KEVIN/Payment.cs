using System;

namespace MilkTeaShop
{
    public static class Payment
    {
        public static void ProcessPayment(decimal totalPrice)
        {
            Console.WriteLine("\nPayment Options:");
            Console.WriteLine("Cash");

            decimal cashAmount;
            Console.Write("Enter the amount in cash: ");
            if (!decimal.TryParse(Console.ReadLine(), out cashAmount) || cashAmount < totalPrice)
            {
                Console.WriteLine("Invalid cash amount or insufficient funds. Exiting the program.");
                return;
            }

            decimal change = cashAmount - totalPrice;

            Console.WriteLine($"Payment successful! Change: ₱{change:F2}. Your order has been placed.");

            Console.WriteLine("\nThank you for shopping with us!");
        }
    }
}
