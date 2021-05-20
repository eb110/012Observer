using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A.BuiltInObserver
{
    class WeatherMonitor : IObservable<WeatherDataStruct>
    {
        List<IObserver<WeatherDataStruct>> observers;

        public WeatherMonitor()
        {
            observers = new List<IObserver<WeatherDataStruct>>();
        }

        public IDisposable Subscribe(IObserver<WeatherDataStruct> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        public void SetWeatherMonitor(float temp, float humid, float pressure)
        {
            WeatherDataStruct pogodaTemp = new WeatherDataStruct(temp, humid, pressure);
            foreach(var ele in observers)
            {
                ele.OnNext(pogodaTemp);
            }
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherDataStruct>> _observers;
            private IObserver<WeatherDataStruct> _observer;

            public Unsubscriber(List<IObserver<WeatherDataStruct>> observers, IObserver<WeatherDataStruct> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }
    }
}
