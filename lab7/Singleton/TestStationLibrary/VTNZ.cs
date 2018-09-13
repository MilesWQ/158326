using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public sealed class VTNZ : TestStation
    {
        private static VTNZ _vtnz;
        private IServiceType _service;
        private static int _requestNumber = 0;
        private static decimal _totalPrice = 0M;

        private VTNZ() { }

        private VTNZ(string Name, string Address, string Tel, string OpenTime)
        {
            this.Name = Name;
            this.Address = Address;
            this.TelNumber = Tel;
            this.OpenTime = OpenTime;
            _requestNumber = 0;
        }

        public static VTNZ GetInstance(string Name, string Address, string Tel, string OpenTime)
        {
            if(_vtnz == null)
            {
                _vtnz = new VTNZ(Name, Address, Tel, OpenTime);
            }
            return _vtnz;
        }

        public IServiceType IServiceType
        {
            get
            {
                return _service;
            }
        }

        public static int TotalRequest
        {
            get
            {
                return _requestNumber;
            }
        }

        public static decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }

        public void RequestService(IServiceType service)
        {
            this._service = service;
            ++_requestNumber;
            _totalPrice += _service.Price;
        }

        public string ShowServiceDetail()
        {
            return IServiceType.ServiceName + " Price\n" + IServiceType.Price + "\n";
        }

        public override string ShowStationDetail()
        {
            return "Station name:" + z_registeredName + "\nAddress:" + z_address + "\nTel:" + z_telNumber + "\n" + z_businessTime;
        }
    }
}
