using System;

namespace MilkTeaShop
{
    public static class Sizes
    {
        public static decimal[] Prices = { 80m, 100m };

        public static void Display()
        {
            Console.WriteLine("Available Sizes:");
            Console.WriteLine($"1. Regular: ₱{Prices[0]}");
            Console.WriteLine($"2. Large: ₱{Prices[1]}");
        }
    }
}
