using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherDataInterfaces;

namespace WeatherBroadcast
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public float Temp { get; set; }

        public float Humidity { get; set; }

        public int Pressure { get; set; }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.UpdatePull();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
