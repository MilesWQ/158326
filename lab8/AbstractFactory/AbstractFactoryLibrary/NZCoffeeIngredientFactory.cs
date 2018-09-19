using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class NZCoffeeIngredientFactory : ICoffeeIngredientFactory
    {
        public ICoffeeBeans CreateCoffeeBeans()
        {
            return new DecaffeinatedCoffeeBeans();
        }

        public IMilk CreateMilk()
        {
            return new FullCreamMilk();
        }
    }
}
