using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    /// <summary>
    /// The interface that all subjects (publishers) must implement.
    /// </summary>
    public interface ISubject
    {
        // Both of these methods take an IObserver as an argument; 
        // that is, the IObserver to add or remove.
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);

        // This method is called to notify all IObservers 
        // when the ISubject's (publisher's) state has changed.
        void NotifyObservers();
    }
}
