using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public class CarInspection
    {
        private string _strInspectionType;
        private decimal _decInspectionPrice;

        public CarInspection() { }
        public CarInspection(string inspectionType, decimal inpectionPrice)
        {
            this._strInspectionType = inspectionType;
            this._decInspectionPrice = inpectionPrice;
        }

        public string InspectionType
        {
            get
            {
                return _strInspectionType;
            }
        }

        public decimal InspectionPrice
        {
            get
            {
                return _decInspectionPrice;
            }
        }
    }
}
