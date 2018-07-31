using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class StaffParking : ParkingType
    {
        private const decimal STAFF_SPECIAL_OFFER_HOURS = 10;
        public StaffParking(decimal _hours) : base(_hours) { }

        public override decimal FindParkingChargeAmount()
        {
            if (Hours <= STAFF_SPECIAL_OFFER_HOURS)
            {
                return FEE_RATE;
            }
            return FEE_RATE + (Hours - STAFF_SPECIAL_OFFER_HOURS) * FEE_RATE;
        }
    }
}