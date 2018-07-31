using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class ParkingType
    {
        private const decimal OVERDUE = 24M;
        protected const decimal FEE_RATE = 2M;

        public ParkingType(decimal hours)
        {
            if (hours > OVERDUE)
            {
                ParkingException ex = new ParkingException();
                throw ex;
            }
            Hours = Math.Ceiling(hours);
        }
        public decimal Hours
        {
            get;
        }

        public virtual decimal FindParkingChargeAmount()
        {
            return Hours * FEE_RATE;
        }
    }
}