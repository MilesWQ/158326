using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherDataInterfaces;

namespace WeatherBroadcast
{
    public partial class WeatherDataStation : Form, ISubject
    {
        private WeatherData _weatherData;
        public WeatherDataStation()
        {
            InitializeComponent();
            _weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionDisplay = new CurrentConditionsDisplay(this);
            currentConditionDisplay.Show();
            ForecastDisplay forecastDisplay = new ForecastDisplay(this);
            forecastDisplay.Show();
            WeatherStatistics weatherStatistics = new WeatherStatistics(this);
            weatherStatistics.Show();
        }

        public void NotifyObservers()
        {
            _weatherData.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _weatherData.RegisterObserver(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _weatherData.RemoveObserver(observer);
        }

        private void MeasurementChanged()
        {
            float temp = 0;
            float humidity = 0;
            int pressure = 0;
            float.TryParse(textBoxTemp.Text, out temp);
            float.TryParse(textBoxHumidity.Text, out humidity);
            int.TryParse(textBoxPressure.Text, out pressure);
            _weatherData.MeasurementChanged(temp, humidity, pressure);
            NotifyObservers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MeasurementChanged();
        }
    }
}
