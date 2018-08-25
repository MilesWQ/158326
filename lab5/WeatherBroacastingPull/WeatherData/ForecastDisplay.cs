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
    public partial class ForecastDisplay : Form, IObserver, IDisplayElement
    {
        private int _pressure;
        public ForecastDisplay()
        {
            InitializeComponent();
        }

        public void Display()
        {
            if (_pressure < 1000)
            {
                condition.Text = "Rain";
            }
            else
            {
                condition.Text = "Sunshine";
            }

        }

        public void Update(float temp, float humidity, int pressure)
        {
            this._pressure = pressure;
            Display();
        }

        public void UpdatePull()
        {
            Update(0, 0, WeatherDataStation.weatherData.Pressure);
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
