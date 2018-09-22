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
    public partial class CurrentConditionDisplay : Form, IObserver, IDisplay
    {
        private ISubject _subject;
        private float _temp;
        private float _humidity;
        private int _pressure;
        public CurrentConditionDisplay(ISubject subject)
        {
            InitializeComponent();
            _subject = subject;
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
            Display();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _subject.RegisterObservers(this);
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            _subject.RemoveObservers(this);
        }
    }
}
