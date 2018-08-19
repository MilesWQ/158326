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
        private ISubject _subject;
        private int _pressure;
        public ForecastDisplay(ISubject subject)
        {
            InitializeComponent();
            this._subject = subject;
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

        private void register_Click(object sender, EventArgs e)
        {
            register.Enabled = false;
            _subject.RegisterObserver(this);
        }

        private void unsubscribe_Click(object sender, EventArgs e)
        {
            register.Enabled = true;
            _subject.RemoveObserver(this);
        }
    }
}
