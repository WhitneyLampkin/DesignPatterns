using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    /// <summary>
    /// The interface all displays implement.
    /// </summary>
    public interface IDisplayElement
    {
        /// <summary>
        /// Method called when the display element needs to be updated.
        /// </summary>
        void Display();
    }
}
