using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk
{
    public class CustomerParking : ParkingType
    {
        public CustomerParking(decimal hours):base(hours) { }
    }
}