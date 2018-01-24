using System;

namespace DecoratorPattern.Beverages
{
    /// <summary>
    /// Decaf is a concrete beverage class
    /// </summary>
    public class Decaf : Beverage
    {
        /// <summary>
        /// Sets the beverage's description
        /// </summary>
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        /// <summary>
        /// Calculates the cost of a decaf coffee
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return 1.05;
        }
    }
}
