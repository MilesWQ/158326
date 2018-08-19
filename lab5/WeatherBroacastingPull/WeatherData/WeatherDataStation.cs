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
    public partial class WeatherDataStation : Form
    {
        private static WeatherData _weatherData;
        public WeatherDataStation()
        {
            _weatherData = new WeatherData();
            InitializeComponent();
            CurrentConditionsDisplay currentConditionDisplay = new CurrentConditionsDisplay(_weatherData);
            currentConditionDisplay.Show();
            ForecastDisplay forecastDisplay = new ForecastDisplay(_weatherData);
            forecastDisplay.Show();
            WeatherStatistics weatherStatistics = new WeatherStatistics(_weatherData);
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
            float result = 0;
            float.TryParse(textBoxTemp.Text, out result);
             _weatherData.Temp = result;
            float.TryParse(textBoxHumidity.Text, out result);
            _weatherData.Humidity = result;
            int pressure = 0;
            Int32.TryParse(textBoxPressure.Text, out pressure);
            _weatherData.Pressure = pressure;
            NotifyObservers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MeasurementChanged();
        }
    }
}
