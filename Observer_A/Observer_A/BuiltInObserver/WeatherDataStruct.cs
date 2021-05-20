using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A.BuiltInObserver
{
    public struct WeatherDataStruct
    {
        public float temperature { get; }
        public float humidity { get; }
        public float pressure { get; }

        public WeatherDataStruct(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

    }
}
