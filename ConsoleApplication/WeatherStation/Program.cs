using ObserverPattern;
using ObserverPattern.DisplayElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            // Uncomment when the code has been added
            // StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            // ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(85, 42, 29.2f);
            weatherData.SetMeasurements(70, 73, 40.4f);

            Console.ReadLine();
        }
    }
}
