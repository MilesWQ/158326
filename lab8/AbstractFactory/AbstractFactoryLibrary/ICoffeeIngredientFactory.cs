using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    interface ICoffeeIngredientFactory
    {
        IMilk CreateMilk();
        ICoffeeBeans CreateCoffeeBeans();
    }
}
