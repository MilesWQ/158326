using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public class VTNZStation : TestingStation
    {
        private IService _service;
        private List<IService> _serviceList;
        private static decimal _totalPrice = 0M;
        private static int _totalCount = 0;

        public VTNZStation() { }

        public VTNZStation(string name, string address, string telNumber, string openHours)
        {
            this.Name = name;
            this.Address = address;
            this.TelNumber = telNumber;
            this.Hours = openHours;
        }

        public List<IService> ServiceList
        {
            get
            {
                return _serviceList;
            }
            set
            {
                _serviceList = value;
            }
        }

        public static decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }

        public static int TotalCount
        {
            get
            {
                return _totalCount;
            }
        }

        public void AddService(IService service)
        {
            _serviceList.Add(service);
        }

        public void RequestService(IService service)
        {
            this._service = service;
            ++_totalCount;
            _totalPrice += _service.ServicePrice;
        }

        public override string ShowStationDetails()
        {
            return Name + "\n" + Address + "\n" + Hours + "\n" + TelNumber + "\n";
        }

        public string ShowServiceDetails()
        {
            return "InspectionType: " + _service.ServiceType + "\n" + " InpectionPrice $" + _service.ServicePrice + "\n";
        }
    }
}
