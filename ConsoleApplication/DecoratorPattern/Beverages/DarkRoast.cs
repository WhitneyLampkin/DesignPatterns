using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    /// <summary>
    /// DarkRoast is a concrete beverage class
    /// </summary>
    public class DarkRoast : Beverage
    {
        /// <summary>
        /// Sets the beverage's description
        /// </summary>
        public override string Description
        {
            get { return "Dark Roast Coffee"; }
        }

        /// <summary>
        /// Calculates the cost of a dark roast coffee
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return .99;
        }
    }
}
