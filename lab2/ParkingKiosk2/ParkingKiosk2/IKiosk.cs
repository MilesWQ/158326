using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public interface IKiosk
    {
        decimal HoursParked { get; }
        decimal FindParkingAmount();
    }
}