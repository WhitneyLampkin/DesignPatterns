using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// Abstract class that all beverages inherit from
    /// </summary>
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string Description
        {
            get { return description; }
        }

        /// <summary>
        /// Implemented within the subclasses
        /// </summary>
        /// <returns></returns>
        public abstract double Cost();
    }
}
