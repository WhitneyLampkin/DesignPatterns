using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.DisplayElements
{
    /// <summary>
    /// Used to display current weather conditions
    /// Implements IObserver so it can get changes from the WeatherData object
    /// Implements IDisplayElement
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        /// <summary>
        /// This constructor is passed the weatherData object (ISubject),
        /// and is used to register the display as an observer.
        /// </summary>
        /// <param name="weatherData"></param>
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.AddObserver(this);
        }

        /// <summary>
        /// Saves the temp and humidity when update is called and calls Display().
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        /// <summary>
        /// This method prints out the most recent temp and humidity values.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity.");
        }
    }
}
