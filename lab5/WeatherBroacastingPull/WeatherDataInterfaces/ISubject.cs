using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataInterfaces
{
    public interface ISubject
    {
        void NotifyObservers();

        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);
    }
}
