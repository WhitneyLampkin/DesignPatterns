using DecoratorPattern;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;

namespace StarbuzzCoffee
{
    class Program
    {
        /// <summary>
        /// Main entry method for the Starbuzz Coffee console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creates an order for an Espresso coffee with no condiments
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.Description + " $" + espresso.Cost());

            // Creates an order for a DarkRoast coffee with 2 mocha and a whip condiment
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine(darkRoast.Description + " $" + darkRoast.Cost());

            // Creates an order for a houseblend coffee with a soy, mocha and whip condiment
            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine(houseBlend.Description + " $" + houseBlend.Cost());
            
            Console.ReadLine();
        }
    }
}