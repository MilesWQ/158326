using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public abstract class TestingStation
    {
        private string _strName;
        private string _strAddress;
        private string _strTelNumber;
        private string _strOpenHour;

        public string Name
        {
            get
            {
                return _strName;
            }
            set
            {
                _strName = value;
            }
        }

        public string Address
        {
            get
            {
                return _strAddress;
            }
            set
            {
                _strAddress = value;
            }
        }

        public string TelNumber
        {
            get
            {
                return _strTelNumber;
            }
            set
            {
                _strTelNumber = value;
            }
        }

        public string Hours
        {
            get
            {
                return _strOpenHour;
            }
            set
            {
                _strOpenHour = value;
            }
        }

        public abstract string ShowStationDetails();
    }
}
