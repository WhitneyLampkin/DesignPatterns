using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    /// <summary>
    /// HouseBlend is a concrete beverage class
    /// </summary>
    public class HouseBlend : Beverage
    {
        /// <summary>
        /// Sets the beverage's description
        /// </summary>
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        /// <summary>
        /// Calculate the cost of a HouseBlend
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return .89;
        }
    }
}
