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
    public partial class WeatherStatistics : Form, IObserver, IDisplay
    {
        private ISubject _subject;
        private float _maxTemp;
        private float _minTemp;
        private float _averageTemp;
        private float _sumTemp;
        private int _times = 0;
        public WeatherStatistics(ISubject subject)
        {
            InitializeComponent();
            _subject = subject;
            _maxTemp = 0;
            _minTemp = 0;
            _averageTemp = 0;
            _sumTemp = 0;
        }

        public void Display()
        {
            lblAverageTemp.Text = _averageTemp.ToString();
            lblMaxTemp.Text = _maxTemp.ToString();
            lblMinTemp.Text = _minTemp.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            float _temperature = temp;
            _sumTemp += _temperature;
            _times++;
            if (_temperature > _maxTemp)
            {
                _maxTemp = _temperature;
            }
            if (_temperature < _minTemp)
            {
                _minTemp = _temperature;
            }
            _averageTemp = _sumTemp / _times;
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
