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
    public partial class ForecastDisplay : Form, IObserver, IDisplay
    {
        private ISubject _subject;
        private int _pressure;
        public ForecastDisplay(ISubject subject)
        {
            InitializeComponent();
            _subject = subject;
            _pressure = 0;
        }

        public void Display()
        {
            if (_pressure > 1000)
            {
                lblForecast.Text = "Rain";
            }
            else
            {
                lblForecast.Text = "Sunshine";
            }
        }

        public void Update(float temp, float humidity, int pressure)
        {
            this._pressure = pressure;
            Display();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this._subject.RegisterObservers(this);
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            this._subject.RemoveObservers(this);
        }
    }
}
