using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    public class OZCafe : Cafe
    {
        protected override Coffee CreateCoffee(string flavour)
        {
            ICoffeeIngredientFactory ingredientFactory = new OZCoffeeIngredientFactory();
            if (flavour.Equals("Cappuccino"))
            {
                return new OZCappuccino(ingredientFactory);
            }
            return new OZFlatWhite(ingredientFactory);
        }
    }
}
