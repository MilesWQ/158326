using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public class CarInspection
    {
        private string _service;
        private decimal _price;

        public CarInspection() { }

        public CarInspection(string InspectionItem, decimal Price)
        {
            this._service = InspectionItem;
            this._price = Price;
        }

        public string Service
        {
            get
            {
                return _service;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
        }
        public string ShowCarInspectionItemDetail()
        {
            return _service + "\nPrice " + _price;
        }
    }
}
