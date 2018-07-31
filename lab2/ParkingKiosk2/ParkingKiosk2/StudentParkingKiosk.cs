using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingKiosk2
{
    public class StudentParkingKiosk
    {
        private const decimal FEE_RATE = 1;

        public StudentParkingKiosk(decimal hours)
        {
            StudentHoursParked = hours;
        }
        public decimal StudentHoursParked
        {
            get;
        }
        public decimal FindStudentParkingAmout()
        {
            return FEE_RATE* Math.Ceiling(StudentHoursParked);
        }
    }
}