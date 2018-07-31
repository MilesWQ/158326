using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public class StaffKioskWrap : IKiosk
    {
        private StaffParkingKiosk _staffParkingKiosk;
        public StaffKioskWrap(decimal _hour)
        {
            _staffParkingKiosk = new StaffParkingKiosk(_hour);
        }

        decimal IKiosk.HoursParked
        {
            get => _staffParkingKiosk.StaffHoursParked;
        }

        decimal IKiosk.FindParkingAmount()
        {
            return _staffParkingKiosk.FindStaffParkingKiosk();
        }
    }
}