using System;

namespace MilkTeaShop
{
    public static class Flavors
    {
        public static string[] List = { "Classic", "Taro", "Matcha", "Strawberry", "Red Velvet" };

        public static void Display()
        {
            Console.WriteLine("Available Flavors:");
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {List[i]}");
            }
        }
    }
}
