using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void notifyObservers()
        {
            foreach(Observer ele in observers)
                ele.update(temperature, humidity, pressure);
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            if(observers.Contains(o))
                observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }
    }
}