using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherBroadcastLibrary
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private int _pressure;
        private static WeatherData _uniqueWeatherData;

        private WeatherData()
        {
            _observers = new List<IObserver>();
            _temperature = 0;
            _humidity = 0;
            _pressure = 0;
        }

        public static WeatherData GetInstance()
        {
            if (_uniqueWeatherData == null)
            {
                _uniqueWeatherData = new WeatherData();
            }
            return _uniqueWeatherData;
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RemoveObservers(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void RegisterObservers(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void SetMeasurement(float temp, float humidity, int pressure)
        {
            this._humidity = humidity;
            this._temperature = temp;
            this._pressure = pressure;
            this.NotifyObservers();
        }
    }
}
