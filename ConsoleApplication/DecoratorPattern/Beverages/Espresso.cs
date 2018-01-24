using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    /// <summary>
    /// Espresso is a concrete beverage class
    /// </summary>
    public class Espresso : Beverage
    {
        /// <summary>
        /// Sets the beverage's description 
        /// </summary>
        public Espresso()
        {
            description = "Expresso";
        }

        /// <summary>
        /// Calculates the cost of an Espresso
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return 1.99;
        }
    }
}
