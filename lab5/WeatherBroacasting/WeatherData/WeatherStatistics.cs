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
    public partial class WeatherStatistics : Form, IObserver, IDisplayElement
    {
        private ISubject _subject;
        private float _mintemp;
        private float _maxtemp;
        private float _avgtemp;
        private float _sumtemp;
        private int _countUpdate;
        public WeatherStatistics(ISubject subject)
        {
            InitializeComponent();
            this._subject = subject;
        }

        public void Display()
        {
            label5.Text = _countUpdate.ToString();
            avgTemp.Text = _avgtemp.ToString();
            maxTemp.Text = _maxtemp.ToString();
            minTemp.Text = _mintemp.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            ++_countUpdate;
            if (temp > _maxtemp)
            {
                this._maxtemp = temp;
            }
            if (temp < _mintemp)
            {
                this._mintemp = temp;
            }
            _avgtemp = (_sumtemp += temp) / _countUpdate;
            Display();
        }

        public void UpdatePull()
        {

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
