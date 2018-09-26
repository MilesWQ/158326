using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    public class CarRental
    {
        private const decimal HATCHBACK_FEE_RATE = 50;
        private const decimal SEDAN_FEE_RATE = 80;
        private const decimal CONVERTIBLE_FEE_RATE = 100;
        private const decimal SALOON_FEE_RATE = 120;
 
        public decimal GetPrice(int day, FeeRate feeRate)
        {
            if (day < 1)
            {
                return 0;
            }

            return day *(decimal)feeRate;
        }
    }
}
