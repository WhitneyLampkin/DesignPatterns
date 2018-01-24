using System;

namespace DecoratorPattern.Condiments
{
    /// <summary>
    /// Soy is a concrete class that inherits from CondimentDecorator and Beverage
    /// </summary>
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        /// <summary>
        /// Constructor that instantiates Soy with a reference to the Beverage we're wrapping
        /// </summary>
        /// <param name="beverage"></param>
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// Gets the current description and appends the soy description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        /// <summary>
        /// Gets the current cost of the beverage and adds an additional cost for the soy condiment
        /// </summary>
        /// <returns></returns>
        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}
