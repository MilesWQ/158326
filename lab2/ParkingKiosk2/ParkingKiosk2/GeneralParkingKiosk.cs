using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public class GeneralParkingKiosk
    {
        private const decimal FEE_RATE = 2;

        public GeneralParkingKiosk(decimal hours)
        {
            GeneralHoursParked = hours;
        }

        public Decimal GeneralHoursParked
        {
           
            get;
        }

        public decimal FindGeneralParkingAmount()
        {
            return Math.Ceiling(GeneralHoursParked) * FEE_RATE;
        }
    }
}