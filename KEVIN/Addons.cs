using System;

namespace MilkTeaShop
{
    public static class Addons
    {
        public static string[] List = { "None", "Classic", "Taro", "Matcha", "Strawberry", "Red Velvet" };
        public static decimal[] Prices = { 0m, 20m, 10m, 15m, 30m, 25m };

        public static void Display()
        {
            Console.WriteLine("Available Add-ons:");
            Console.WriteLine($"0. None");
            for (int i = 0; i < List.Length - 1; i++)
            {
                Console.WriteLine($"{i + 1}. {List[i + 1]}: ₱{Prices[i + 1]}");
            }
        }
    }
}
