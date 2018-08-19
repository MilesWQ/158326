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
        private float _temp;
        private float _humidity;
        private int _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temp, _humidity, _pressure);
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

        public void MeasurementChanged(float temp, float humidity, int pressure)
        {
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;
        }
    }
}
