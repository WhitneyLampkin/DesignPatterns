using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.WeatherDataObjs
{
    /// <summary>
    /// Weather Data object that implements C#'s IObservable interface
    /// 
    /// WData doesn't need to keep track of observers or manage their 
    /// registration and removal like WeatherData does.
    /// </summary>
    //public class WData : System.IObservable
    //{
    //    private float temperature;
    //    private float humidity;
    //    private float pressure;

    //    /// <summary>
    //    /// WData's constructor no longer needs to create a data structure
    //    /// to hold observers.
    //    /// </summary>
    //    public WData() { }

    //    /// <summary>
    //    /// Indicates a change in the state
    //    /// </summary>
    //    public void MeasurementsChanged()
    //    {
    //        SetChanged();
    //        notifyObservers(); // Uses the pull model.
    //    }

    //    /// <summary>
    //    /// Sets Measurements
    //    /// </summary>
    //    /// <param name="temperature"></param>
    //    /// <param name="humidity"></param>
    //    /// <param name="pressure"></param>
    //    public void SetMeasurements(float temperature, float humidity, float pressure)
    //    {
    //        this.temperature = temperature;
    //        this.humidity = humidity;
    //        this.pressure = pressure;
    //        MeasurementsChanged();
    //    }

    //    /// <summary>
    //    /// Gets the current temperature
    //    /// </summary>
    //    /// <returns>temperature</returns>
    //    public float GetTemperature()
    //    {
    //        return temperature;
    //    }

    //    /// <summary>
    //    /// Gets the current humidity
    //    /// </summary>
    //    /// <returns>humidity</returns>
    //    public float GetHumidity()
    //    {
    //        return humidity;
    //    }

    //    /// <summary>
    //    /// Gets the current pressure
    //    /// </summary>
    //    /// <returns>pressure</returns>
    //    public float GetPressure()
    //    {
    //        return pressure;
    //    }
    // }
}
