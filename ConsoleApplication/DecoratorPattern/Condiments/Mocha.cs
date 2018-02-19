using System;

namespace DecoratorPattern.Condiments
{
    /// <summary>
    /// Mocha is a concrete class that inherits from CondimentDecorator and Beverage
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        /// <summary>
        /// Constructor that instantiates Mocha with a reference to the Beverage we're wrapping
        /// </summary>
        /// <param name="beverage"></param>
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// Gets the current description and appends the mocha description
        /// </summary>
        /// <returns>description</returns>
        public override string Description
        {
            get { return beverage.Description + ", Mocha"; }
        }

        /// <summary>
        /// Gets the current cost of the beverage and adds an additional cost for the mocha condiment
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
