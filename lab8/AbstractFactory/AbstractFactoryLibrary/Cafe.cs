using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    public abstract class Cafe
    {
        public Coffee OrderCoffee(string flavour)
        {
            Coffee coffee = CreateCoffee(flavour);
            coffee.Brew();
            coffee.Pour();
            return coffee;
        }

        protected abstract Coffee CreateCoffee(string flavour);
    }
}
