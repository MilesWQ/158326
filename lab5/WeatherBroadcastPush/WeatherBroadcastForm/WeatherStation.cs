using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherBroadcastLibrary;

namespace WeatherBroadcastForm
{
    public partial class WeatherStation : Form
    {
        private WeatherData _weatherData;
        public WeatherStation()
        {
            InitializeComponent();
            _weatherData = WeatherData.GetInstance();
            CurrentConditionDisplay ccd = new CurrentConditionDisplay(_weatherData);
            ccd.Show();
            ForecastDisplay fd = new ForecastDisplay(_weatherData);
            fd.Show();
            WeatherStatistics ws = new WeatherStatistics(_weatherData);
            ws.Show();
        }

        private void btnSetMeasurement_Click(object sender, EventArgs e)
        {
            float temp = 0;
            float humidity = 0;
            int pressure = 0;
            float.TryParse(textTemp.Text, out temp);
            float.TryParse(textHumidity.Text, out humidity);
            Int32.TryParse(textPressure.Text, out pressure);
            _weatherData.SetMeasurement(temp, humidity, pressure);
        }
    }
}
