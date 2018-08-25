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
        public static WeatherData weatherData;
        public WeatherDataStation()
        {
            weatherData = new WeatherData();
            InitializeComponent();
            CurrentConditionsDisplay currentConditionDisplay = new CurrentConditionsDisplay();
            currentConditionDisplay.Show();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            forecastDisplay.Show();
            WeatherStatistics weatherStatistics = new WeatherStatistics();
            weatherStatistics.Show();
        }

        public void NotifyObservers()
        {
            weatherData.NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            weatherData.RegisterObserver(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            weatherData.RemoveObserver(observer);
        }

        private void MeasurementChanged()
        {
            float result = 0;
            float.TryParse(textBoxTemp.Text, out result);
             weatherData.Temp = result;
            float.TryParse(textBoxHumidity.Text, out result);
            weatherData.Humidity = result;
            int pressure = 0;
            Int32.TryParse(textBoxPressure.Text, out pressure);
            weatherData.Pressure = pressure;
            NotifyObservers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MeasurementChanged();
        }
    }
}
