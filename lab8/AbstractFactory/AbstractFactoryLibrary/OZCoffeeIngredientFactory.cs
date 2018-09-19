using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class OZCoffeeIngredientFactory : ICoffeeIngredientFactory
    {
        public ICoffeeBeans CreateCoffeeBeans()
        {
            return new RegularCoffeeBeans();
        }

        public IMilk CreateMilk()
        {
            return new LowFatMilk();
        }
    }
}
