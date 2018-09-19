using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    public class NZCafe : Cafe
    {
        protected override Coffee CreateCoffee(string flavour)
        {
            ICoffeeIngredientFactory ingredientFactory = new NZCoffeeIngredientFactory();
            if (flavour.Equals("Cappuccino"))
            {
                return new NZCappuccino(ingredientFactory);
            }
            return new NZFlatWhite(ingredientFactory);
        }
    }
}
