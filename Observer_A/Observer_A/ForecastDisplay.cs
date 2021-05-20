using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            if (temperature > 19)
                Console.WriteLine("It is hoooot!!");
            else
                Console.WriteLine("Could be better as temperature not makes my day");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            display();
        }
    }
}
