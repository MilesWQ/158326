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
    public partial class CurrentConditionsDisplay : Form, IObserver, IDisplayElement
    {
        private float _temp;
        private float _humidity;
        private int _pressure;
        public CurrentConditionsDisplay()
        {
            InitializeComponent();
        }

        public void Display()
        {
            temp.Text = _temp.ToString();
            humidity.Text = _humidity.ToString();
            pressure.Text = _pressure.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }

        public void UpdatePull()
        {
            Update(WeatherDataStation.weatherData.Temp, WeatherDataStation.weatherData.Humidity, WeatherDataStation.weatherData.Pressure);
        }

        private void register_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            WeatherDataStation.weatherData.RegisterObserver(this);
        }

        private void unsubscribe_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = true;
            WeatherDataStation.weatherData.RemoveObserver(this);
        }
    }
}
