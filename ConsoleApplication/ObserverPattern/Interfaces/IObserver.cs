using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    /// <summary>
    /// The IObserver interface is implemented by all observers,
    /// so they all have to implement the update() method. 
    /// The measurements will be passed to the observers.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// The parameters are the state values the IObservers get
        /// from the ISubject when a weather measurement changes.
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update(float temp, float humidity, float pressure);
    }
}
