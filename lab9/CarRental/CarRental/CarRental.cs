using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary
{
    public class CarRental
    {
        private const decimal DISCOUNT_10 = 0.1M;
        private const decimal DISCOUNT_15 = 0.15M;
        private const decimal DISCOUNT_20 = 0.2M;
        
        public decimal GetPrice(int day, FeeRate feeRate)
        {
            if (day < 1)
            {
                return 0;
            }
            decimal total = day * (decimal)feeRate;
            if (day >= 20)
            {
                return total * (1 - DISCOUNT_20);
            }
            else if (day >= 10 & day < 20)
            {
                return total * (1 - DISCOUNT_15);
            }
            else if (day >= 5 && day < 10)
            {
                return total * (1 - DISCOUNT_10);
            }
            return total;
        }
    }
}
