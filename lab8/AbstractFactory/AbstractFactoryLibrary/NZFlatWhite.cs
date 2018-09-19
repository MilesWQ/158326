using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class NZFlatWhite : Coffee
    {
        private ICoffeeIngredientFactory _nzCoffeeIngredientFactory;

        internal NZFlatWhite(ICoffeeIngredientFactory ingredientFactory)
        {
            this._nzCoffeeIngredientFactory = ingredientFactory;
        }
        internal override string Brew()
        {
            _coffeeBeans = _nzCoffeeIngredientFactory.CreateCoffeeBeans();
            _milk = _nzCoffeeIngredientFactory.CreateMilk();
            return "Brewing coffee for making a Flat White using " + _coffeeBeans.CoffeeBeanType + " and " + _milk.MilkType;
        }
    }
}
