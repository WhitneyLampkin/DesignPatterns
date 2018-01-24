using System;

namespace DecoratorPattern.Condiments
{
    /// <summary>
    /// Whip is a concrete class that inherits from CondimentDecorator and Beverage
    /// </summary>
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        /// <summary>
        /// Constructor that instantiates Whip with a reference to the Beverage we're wrapping
        /// </summary>
        /// <param name="beverage"></param>
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// Gets the current description and appends teh mocha description
        /// </summary>
        /// <returns>description</returns>
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        /// <summary>
        /// Gets the current cost of the beverage and adds an additional cost for the whip condiment
        /// </summary>
        /// <returns></returns>
        public override double Cost()
        {
            return .10;
        }
    }
}
