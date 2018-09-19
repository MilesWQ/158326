using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public abstract class Cafe
    {
        public Coffee orderCoffee(string flavour)
        {
            Coffee coffee = createCoffee(flavour);
            coffee.Brew();
            coffee.Pour();
            return coffee;
        }

        protected abstract Coffee createCoffee(string flavour);
    }
}
