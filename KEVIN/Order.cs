using System;
using System.Text;

namespace MilkTeaShop
{
    public static class Order
    {
        public static string Flavor { get; set; }
        public static bool IsLargeSize { get; set; }
        public static string Addon { get; set; }
        public static decimal Price { get; set; }

        public static void DisplaySummary()
        {
            string size = IsLargeSize ? "Large" : "Regular";

            StringBuilder summaryBuilder = new StringBuilder();
            summaryBuilder.AppendLine("\nOrder Summary:");
            summaryBuilder.AppendLine("---------------");
            summaryBuilder.AppendLine($"Flavor: {Flavor}");
            summaryBuilder.AppendLine($"Size: {size}");
            summaryBuilder.AppendLine($"Add-on: {Addon}");
            summaryBuilder.AppendLine($"Price: ₱{Price:F2}");

            Console.WriteLine(summaryBuilder.ToString());
        }
    }
}
