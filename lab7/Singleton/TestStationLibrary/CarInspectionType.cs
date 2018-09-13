using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public class CarInspectionType: IServiceType
    {
        private CarInspection _carInspection;

        public CarInspectionType() { }

        public CarInspectionType(string inspectionType,decimal price)
        {
            _carInspection = new CarInspection(inspectionType,price);   
        }

        public string ServiceName {
            get
            {
                return _carInspection.Service;
            }
        }

        public decimal Price {
            get
            {
                return _carInspection.Price;
            }
        }

        public string ShowServiceDetail()
        {
            return _carInspection.ShowCarInspectionItemDetail();
        }
    }
}
