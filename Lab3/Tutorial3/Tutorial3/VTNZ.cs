using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public class VTNZ : TestStation
    {
        private IServiceType _service;
        private int _requestNumber;

        public VTNZ() { }

        public VTNZ(string Name, string Address,string Tel,string OpenTime)
        {
            this.Name = Name;
            this.Address = Address;
            this.TelNumber = Tel;
            this.OpenTime = OpenTime;
            _requestNumber = 0;
        }

        public IServiceType IServiceType
        {
            get
            {
                return _service;
            }
        }

        public int TotalRequest
        {
            get
            {
                return _requestNumber;
            }
        }

        public void RequestService(IServiceType service)
        {
            this._service = service;
            ++_requestNumber;
        }

        public string ShowServiceDetail()
        {
            return IServiceType.ServiceName + " Price\n" + IServiceType.Price + "\n";
        }

        public override string ShowStationDetail()
        {
            return "Station name:" + z_registeredName + "\nAddress:" + z_address + "\nTel:" + z_telNumber+"\n"+z_businessTime;
        }
    }
}