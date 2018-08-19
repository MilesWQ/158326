using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataInterfaces
{
    public interface IObserver
    {
        void Update(float temp, float humidity, int pressure);

        void UpdatePull();
    }
}
