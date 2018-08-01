using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public class CarInspectionType : IServiceType
    {
        private CarInspection _carInspection;

        public CarInspectionType() { }

        public CarInspectionType(string ServiceName,decimal Price)
        {
            _carInspection = new CarInspection(ServiceName, Price);
        }

        string IServiceType.ServiceName
        {
            get
            {
                return _carInspection.Service;
            }
        }

        decimal IServiceType.Price
        {
            get
            {
                return _carInspection.Price;
            }
        }

        string IServiceType.ShowServiceDetail()
        {
            return _carInspection.ShowCarInspectionItemDetail();
        }
    }
}