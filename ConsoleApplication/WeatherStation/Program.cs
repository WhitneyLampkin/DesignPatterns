using ObserverPattern;
using ObserverPattern.DisplayElements;
using ObserverPattern.EventDelegateExample;
using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            // WeatherData weatherData = new WeatherData();
            // CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            ObserverPattern.EventDelegateExample.WeatherData weatherData2 = new ObserverPattern.EventDelegateExample.WeatherData();
            CCDisplay3 currentDisplay2 = new CCDisplay3(weatherData2);

            // Uncomment when the code has been added
            // StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            // ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData2.SetMeasurements(80, 65, 30.4f);
            weatherData2.SetMeasurements(85, 42, 29.2f);
            weatherData2.SetMeasurements(70, 73, 40.4f);

            Console.ReadLine();
        }
    }
}
