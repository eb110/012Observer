using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A.BuiltInObserver
{
    public class CurrentCondition : IObserver<WeatherDataStruct>
    {
        private IDisposable unsubscriber;
        private float tmp;
        private float hmd;
        private float prs;

        public virtual void Subscribe(IObservable<WeatherDataStruct> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Taki sobie on completed comments");
        }

        public virtual void OnError(Exception error)
        {
            //
        }

        public virtual void OnNext(WeatherDataStruct value)
        {
            tmp = value.temperature;
            hmd = value.humidity;
            prs = value.pressure;
            Console.WriteLine("temp = " + tmp);
            Console.WriteLine("humid = " + hmd);
            Console.WriteLine("pressure = " + prs);
        }
    }
}
