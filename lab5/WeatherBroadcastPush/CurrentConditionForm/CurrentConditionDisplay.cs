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

namespace CurrentConditionForm
{
    public partial class CurrentConditionDisplay : Form, IObserver, IDisplay
    {
        private ISubject _subject;
        private float _temp;
        private float _humidity;
        private int _pressure;

        public CurrentConditionDisplay(ISubject subject)
        {
            this._subject = subject;
            InitializeComponent();
        }

        public void Display()
        {
            lblTemp.Text = _temp.ToString();
            lblHumidity.Text = _humidity.ToString();
            lblPressure.Text = _pressure.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;
        }
    }
}
