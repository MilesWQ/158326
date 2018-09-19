using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class OZFlatWhite : Coffee
    {
        private ICoffeeIngredientFactory _ozCoffeeIngredientFactory;

        internal OZFlatWhite(ICoffeeIngredientFactory coffeeIngredient)
        {
            _ozCoffeeIngredientFactory = coffeeIngredient;
        }
        internal override string Brew()
        {
            _coffeeBeans = _ozCoffeeIngredientFactory.CreateCoffeeBeans();
            _milk = _ozCoffeeIngredientFactory.CreateMilk();
            return "Brewing coffee for making a Flat White using " + _coffeeBeans.CoffeeBeanType + " and " + _milk.MilkType;
        }
    }
}
