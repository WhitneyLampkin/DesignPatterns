using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Decorator class that all condiment classes inherit from
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        /// <summary>
        /// All condiment classes must reimplement the GetDescription() method. 
        /// </summary>
        /// <returns></returns>
        public abstract override string Description { get; }
    }
}
