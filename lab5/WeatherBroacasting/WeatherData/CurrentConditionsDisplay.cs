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
        private ISubject _subject;
        private float _temp;
        private float _humidity;
        private int _pressure;
        public CurrentConditionsDisplay(ISubject subject)
        {
            InitializeComponent();
            this._subject = subject;
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

        private void register_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;
            _subject.RegisterObserver(this);
        }

        private void unsubscribe_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = true;
            _subject.RemoveObserver(this);
        }
    }
}
