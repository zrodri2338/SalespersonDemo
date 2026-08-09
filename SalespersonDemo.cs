using System;

/*
Name: Zulisa Rodriguez
Date Completed: August 2026
Program: SalespersonDemo
Description: Demonstrates inheritance using a Salesperson base
class and RealEstateSalesperson and GirlScout child classes.
Resources Used: Course materials and class notes.
*/

namespace SalespersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Salesperson
            Salesperson salesperson =
                new Salesperson("John", "Smith");

            Console.WriteLine("SALESPERSON");
            Console.WriteLine("Name: " + salesperson.GetFullName());

            Console.WriteLine();

            // Test RealEstateSalesperson
            RealEstateSalesperson realEstateAgent =
                new RealEstateSalesperson(
                    "Maria",
                    "Lopez",
                    0.05);

            realEstateAgent.SellHouse(250000);
            realEstateAgent.SellHouse(300000);

            Console.WriteLine("REAL ESTATE SALESPERSON");
            Console.WriteLine(
                "Name: " + realEstateAgent.GetFullName());

            Console.WriteLine(
                $"Commission Rate: {realEstateAgent.CommissionRate:P}");

            Console.WriteLine(
                $"Total Value Sold: {realEstateAgent.TotalValueSold:C}");

            Console.WriteLine(
                $"Total Commission Earned: " +
                $"{realEstateAgent.TotalCommissionEarned:C}");

            Console.WriteLine();

            // Test GirlScout
            GirlScout scout =
                new GirlScout("Emily", "Johnson");

            scout.SellCookies(25);
            scout.SellCookies(15);

            Console.WriteLine("GIRL SCOUT");
            Console.WriteLine(
                "Name: " + scout.GetFullName());

            Console.WriteLine(
                $"Boxes of Cookies Sold: {scout.BoxesSold}");
        }
    }
}