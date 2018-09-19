using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class OZCappuccino : Coffee
    {
        private ICoffeeIngredientFactory _ozCoffeeIngredientFactory;

        internal OZCappuccino(ICoffeeIngredientFactory ingredientFactory)
        {
            _ozCoffeeIngredientFactory = ingredientFactory;
        }
        internal override string Brew()
        {
            _coffeeBeans = _ozCoffeeIngredientFactory.CreateCoffeeBeans();
            _milk = _ozCoffeeIngredientFactory.CreateMilk();
            return "Brewing coffee for making a Cappuccino using " + _coffeeBeans.CoffeeBeanType + " and " + _milk.MilkType;
        }
    }
}
