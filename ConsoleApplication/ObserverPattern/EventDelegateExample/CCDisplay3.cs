using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.EventDelegateExample
{
    public class CCDisplay3 : IDisplayElement 
    {
        private WeatherData _weatherData;
        private float _temperature;
        private float _humidity;

        public float Temperature
        {
            get
            {
                return _temperature;
            }
        }

        public float Humidity
        {
            get
            {
                return _humidity;
            }
        }

        public CCDisplay3(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.MeasurementsChanged += Update;
        }

        public void Update(object sender, WeatherDataEventArgs we)
        {
            this._temperature = we.Temperature;
            this._humidity = we.Humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + this._temperature + "F degrees and " + this._humidity + "% humidity");
        }
    }
}
