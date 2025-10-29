using System;
using System.Collections.Generic;

namespace NickiDonut
{
    class Program
    {
    static void Main(string[] args)
    {
        bool isExiting = false;
        double totalAmount = 0;

        while (!isExiting)
        {
            Console.WriteLine();
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Welcome to Nicki Donut!");

            Console.WriteLine();
            Console.WriteLine("   MENU");

            DisplayMenu();

            Console.WriteLine();
            Console.Write("Select your order (1-5): ");
            int donutOrder = Convert.ToInt32(Console.ReadLine());

            Donut selectedDonut = GetDonut(donutOrder);
            totalAmount += selectedDonut.Price;

            Console.WriteLine();
            Console.WriteLine("Do you want to put some add-ons? (yes/no)");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            List<Addon> selectedAddons = new List<Addon>();
            double addonsTotalPrice = 0;

            if (input == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("   ADD-ONS");

                DisplayAddons();

                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Select your add-on order (1-5): ");
                    int addonOrder = Convert.ToInt32(Console.ReadLine());

                    if (addonOrder == 0)
                        break;

                    Addon selectedAddon = GetAddon(addonOrder);
                    selectedAddons.Add(selectedAddon);

                    addonsTotalPrice += selectedAddon.Price;
                }

                Console.WriteLine();
                Console.WriteLine("Thank you for your order, " + name + "!");
                Console.WriteLine();
                Console.WriteLine("Your order:");
                Console.WriteLine();
                Console.WriteLine($"{selectedDonut.Name} - PHP {selectedDonut.Price}");
                Console.WriteLine("Add-ons:");

                foreach (var addon in selectedAddons)
                {
                    Console.WriteLine($"{addon.Name} - PHP {addon.Price}");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank you and come again, " + name + "!");
                Console.WriteLine();
                Console.WriteLine($"Your order: {selectedDonut.Name} - PHP {selectedDonut.Price}");
            }

            totalAmount += addonsTotalPrice;
            Console.WriteLine();
            Console.WriteLine($"Total amount for {name}'s order: PHP {totalAmount}");

            Console.WriteLine();
            Console.WriteLine("Do you want to order again? (yes/no)");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice != "yes")
            {
                isExiting = true;
                Console.WriteLine();
                Console.WriteLine("Happy to serve you!");
                break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Strawberry Sprinkle Donut - PHP 85");

        Console.WriteLine("2. Ube Cheese Donut          - PHP 60");

        Console.WriteLine("3. Rainbow Sprinkle Donut    - PHP 55");

        Console.WriteLine("4. Choco Frosted             - PHP 85");

        Console.WriteLine("5. Vanilla Kreme             - PHP 90");
    }

    static void DisplayAddons()
    {
        Console.WriteLine("1. Royal Float                - PHP 50");

        Console.WriteLine("2. Coffee Jelly               - PHP 25");

        Console.WriteLine("3. Four Seasons Juice         - PHP 25");

        Console.WriteLine("4. Cappuccino Iced Coffee     - PHP 100");

        Console.WriteLine("5. Mango Graham Shake          - PHP 75");
    }

    static Donut GetDonut(int donutVariation)
    {
        switch (donutVariation)
        {
            case 1:

                return new Donut("Strawberry Sprinkle Donut", 85);

            case 2:

                return new Donut("Ube Cheese Donut", 60);

            case 3:

                return new Donut("Rainbow Sprinkle Donut", 55);

            case 4:

                return new Donut("Choco Frosted", 85);

            case 5:

                return new Donut("Vanilla Kreme", 90);

            default:

                return null;
        }
    }

    static Addon GetAddon(int addonVariation)
    {
        switch (addonVariation)
        {
            case 1:

                return new Addon("Royal Float", 50);

            case 2:

                return new Addon("Coffee Jelly", 25);

            case 3:

                return new Addon("Four Seasons Juice", 25);

            case 4:

                return new Addon("Cappuccino Iced Coffee", 100);

            case 5:

                return new Addon("Mango Graham Shake", 75);

            default:

                return null;
        }
    }
}
}

    
