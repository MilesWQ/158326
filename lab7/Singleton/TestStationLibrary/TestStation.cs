using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public abstract class TestStation
    {
        protected string z_registeredName;
        protected string z_address;
        protected string z_telNumber;
        protected string z_businessTime;

        public string Name
        {
            get
            {
                return z_registeredName;
            }
            set
            {
                z_registeredName = value;
            }
        }

        public string Address
        {
            get
            {
                return z_address;
            }
            set
            {
                z_address = value;
            }
        }

        public string TelNumber
        {
            get
            {
                return z_telNumber;
            }
            set
            {
                z_telNumber = value;
            }
        }

        public string OpenTime
        {
            get
            {
                return z_businessTime;
            }
            set
            {
                z_businessTime = value;
            }
        }

        public abstract string ShowStationDetail();
    }
}
