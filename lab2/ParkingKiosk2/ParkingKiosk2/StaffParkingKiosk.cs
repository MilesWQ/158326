using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public class StaffParkingKiosk
    {
        private const decimal FEE_RATE = 2;

        private const decimal SPECIAL_HOURS = 10;

        public StaffParkingKiosk(decimal hours)
        {
            StaffHoursParked = hours;
        }
        public decimal StaffHoursParked
        {
            get;
        }

        public decimal FindStaffParkingKiosk()
        {
            if (StaffHoursParked <= SPECIAL_HOURS)
            {
                return FEE_RATE;
            }
            else
            {
                return FEE_RATE + (Math.Ceiling(StaffHoursParked) - SPECIAL_HOURS) * FEE_RATE;
            }
        }
    }
}