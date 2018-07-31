using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public class GenKioskWrap : IKiosk
    {
        private GeneralParkingKiosk _generalParkingKiosk;

        public GenKioskWrap(decimal _hours)
        {
            _generalParkingKiosk = new GeneralParkingKiosk(_hours);
        }

        decimal IKiosk.HoursParked
        {
            get => _generalParkingKiosk.GeneralHoursParked;
        }

        decimal IKiosk.FindParkingAmount()
        {
            return _generalParkingKiosk.FindGeneralParkingAmount();
        }
    }
}