﻿using System;
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
        private float _mintemp;
        private float _maxtemp;
        private float _avgtemp;
        private float _sumtemp;
        private int _countUpdate;
        public WeatherStatistics()
        {
            InitializeComponent();
        }

        public void Display()
        {
            lblUpdateCount.Text = _countUpdate.ToString();
            avgTemp.Text = _avgtemp.ToString();
            maxTemp.Text = _maxtemp.ToString();
            minTemp.Text = _mintemp.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            if (_countUpdate == 0)
            {
                _maxtemp = _mintemp = temp;
            }
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
            Update(WeatherDataStation.weatherData.Temp, 0, 0);
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
