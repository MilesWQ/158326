using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherBroadcastLibrary
{
    public interface ISubject
    {
        void NotifyObservers();
        void RemoveObservers(IObserver observer);
        void RegisterObservers(IObserver observer);
    }
}
