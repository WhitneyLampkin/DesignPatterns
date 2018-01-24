﻿using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.EventDelegateExample
{
    class StatisticsDisplay : IDisplayElement
    {
        private WeatherData _weatherData;
        private List<float> _temperatures;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this._temperatures = new List<float>();
            this._weatherData = weatherData;
            weatherData.MeasurementsChanged += Update;
        }

        public void Update(object sender, WeatherDataEventArgs we)
        {
            this._temperatures.Add(we.Temperature);
            Display();
        }

        public void Display()
        {
            String output;

            output = String.Format("Avg/Max/Min temperature = {0}/{1}/{2}", _temperatures.Average(), _temperatures.Max(), _temperatures.Min());
            Console.WriteLine(output);
        }
    }
}