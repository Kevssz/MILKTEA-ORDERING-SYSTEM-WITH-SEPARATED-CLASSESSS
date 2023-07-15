using System;

namespace MilkTeaShop
{
    class Program
    {
        static decimal[] sizePrices = Sizes.Prices;
        static string[] flavors = Flavors.List;

        static void Main(string[] args)
        {
            Console.Write("Enter the number of orders: ");
            int numberOfOrders;
            if (!int.TryParse(Console.ReadLine(), out numberOfOrders) || numberOfOrders < 1)
            {
                Console.WriteLine("Invalid number of orders. Exiting the program.");
                return;
            }

            decimal totalPrice = 0;

            for (int i = 0; i < numberOfOrders; i++)
            {
                Console.WriteLine($"\nOrder #{i + 1}");

                bool placeAnotherOrder = true;

                while (placeAnotherOrder)
                {
                    Console.WriteLine("\nWelcome to the Milk Tea Shop!");
                    Flavors.Display();
                    Sizes.Display();
                    Addons.Display();

                    int flavorIndex = GetSelection("flavor", flavors.Length);
                    Order.Flavor = flavors[flavorIndex - 1];

                    int sizeIndex = GetSelection("size", sizePrices.Length);
                    Order.IsLargeSize = (sizeIndex == 2);

                    int addonIndex = GetSelection("add-on (0 for none)", Addons.List.Length);
                    Order.Addon = (addonIndex == 0) ? "None" : Addons.List[addonIndex];

                    Order.Price = sizePrices[sizeIndex - 1] + Addons.Prices[addonIndex];

                    totalPrice += Order.Price;

                    Order.DisplaySummary();

                    Console.Write("\nPlace another order? (yes/no) ");
                    string userInput = Console.ReadLine();

                    if (userInput.ToLower() != "yes")
                    {
                        placeAnotherOrder = false;
                    }
                }
            }

            Console.WriteLine($"\nTotal price for all orders: ₱{totalPrice:F2}");

            Payment.ProcessPayment(totalPrice);
        }

        static int GetSelection(string selectionType, int arrayLength)
        {
            int selectedIndex;
            while (true)
            {
                Console.Write($"Enter the number corresponding to the {selectionType}: ");
                if (int.TryParse(Console.ReadLine(), out selectedIndex) && selectedIndex >= 0 && selectedIndex <= arrayLength)
                {
                    break;
                }
                Console.WriteLine("Invalid selection. Please try again.");
            }
            return selectedIndex;
        }
    }
}
