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
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            // Creates an order for a DarkRoast coffee with 2 mocha and a whip condiment
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            // Creates an order for a houseblend coffee with a soy, mocha and whip condiment
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Console.ReadLine();
        }
    }
}