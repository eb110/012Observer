using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Temp = " + temperature + " ,Humidity = " + humidity);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
    }
}
