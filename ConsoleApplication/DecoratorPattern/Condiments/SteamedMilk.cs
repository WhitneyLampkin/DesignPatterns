using System;

namespace DecoratorPattern.Condiments
{
    /// <summary>
    /// SteamedMilk is a concreate class that inherits from CondimentDecorator and Beverage
    /// </summary>
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        /// <summary>
        /// Constructor that instantiates SteamedMilk with a reference to the Beverage we're wrapping
        /// </summary>
        /// <param name="beverage"></param>
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// Gets the current description and appends the steamed milk description
        /// </summary>
        /// <returns></returns>
        public override string Description
        {
            get { return beverage.Description + ", Steamed Milk"; }
        }

        /// <summary>
        /// Gets the current cost of the beverage and adds an additional cost for the steamed milk condiment
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
