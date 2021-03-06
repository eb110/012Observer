using Observer_A.BuiltInObserver;
using System;

namespace Observer_A
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(1, 2, 3f);
            weatherData.setMeasurements(2, 3, 4f);
            weatherData.setMeasurements(30, 4, 5f);


            WeatherMonitor monitor = new WeatherMonitor();
            CurrentCondition condit = new CurrentCondition();
            condit.Subscribe(monitor);
            monitor.SetWeatherMonitor(23, 80, 1000);
        }
    }
}
