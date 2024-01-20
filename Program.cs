using System;
using PierresBakery.Models;

namespace PierresBakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("We offer the following items:");
            Console.WriteLine("Bread - $5 per loaf (Buy 2, get 1 free)");
            Console.WriteLine("Pastry - $2 each (Buy 3, get 1 free)");

            Console.Write("Enter the number of loaves of Bread you'd like: ");
            int breadCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of Pastries you'd like: ");
            int pastryCount = Convert.ToInt32(Console.ReadLine());

            int totalCost = Bread.BreadCost(breadCount) + Pastry.PastryCost(pastryCount);
            Console.WriteLine($"The total cost for your order is: ${totalCost}");

            Console.WriteLine("Thank you for visiting Pierre's Bakery!");
        }
    }
}