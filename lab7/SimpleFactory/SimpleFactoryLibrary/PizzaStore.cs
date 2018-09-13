using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary
{
    public sealed class PizzaStore
    {
        private SimplePizzaFactory _factory;
        private static PizzaStore _uniquePizzaStore;

        private PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public static PizzaStore GetInstance(SimplePizzaFactory factory)
        {
            if(_uniquePizzaStore == null)
            {
                _uniquePizzaStore = new PizzaStore(factory);
            }
            return _uniquePizzaStore;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza greatPizza = _factory.createPizza(type);
            greatPizza.Prepare();
            greatPizza.Bake();
            greatPizza.Box();
            return greatPizza;
        }
    }
}
