using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public class StudKioskWrap : IKiosk
    {
        private StudentParkingKiosk _studentParkingKiosk;
        public StudKioskWrap(decimal _hour)
        {
            _studentParkingKiosk = new StudentParkingKiosk(_hour);
        }

        decimal IKiosk.HoursParked
        {
            get => _studentParkingKiosk.StudentHoursParked;
        }

        decimal IKiosk.FindParkingAmount()
        {
            return _studentParkingKiosk.FindStudentParkingAmout();
        }
    }
}