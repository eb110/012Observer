using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_A
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
