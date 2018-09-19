using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class OZCafe : Cafe
    {
        protected override Coffee createCoffee(string flavour)
        {
            if (flavour.Equals("Cappuccino"))
            {
                return new OZCappuccino();
            }
            return new OZFlatWhite();
        }
    }
}
