using ObserverPattern.Interfaces;
using System.Collections;

namespace ObserverPattern
{
    /// <summary>
    /// The WeatherData objects that knows how to get information from the Weather Station.
    /// </summary>
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        /// <summary>
        /// Default constructor used to create a new WeatherData object.
        /// </summary>
        public WeatherData()
        {
            // The collection of observers subscribed to the WeatherData object.
            observers = new ArrayList();
        }

        /// <summary>
        /// Adds an observer to the collection of observers.
        /// </summary>
        /// <param name="o"></param>
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// Removes an observer from the collection of observers.
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        /// <summary>
        /// Notifies observers when measurements are updated from the Weather Station.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                IObserver observer = o;
                o.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        /// <summary>
        /// Used to test display elements. 
        /// Actual data can be grabbed from the web as well.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
