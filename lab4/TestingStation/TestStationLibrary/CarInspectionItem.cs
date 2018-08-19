using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public class CarInspectionItem : IService
    {
        private CarInspection _carInspection;

        public CarInspectionItem() { }

        public CarInspectionItem(string inspectionType, decimal price)
        {
            _carInspection = new CarInspection(inspectionType, price);
        }
        public string ServiceType
        {
            get
            {
                return _carInspection.InspectionType;
            }
        }

        public decimal ServicePrice
        {
            get
            {
                return _carInspection.InspectionPrice;
            }
        }
    }
}
