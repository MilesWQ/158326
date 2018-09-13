using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new CheesePizza();
            }
            if (type.Equals("funghi"))
            {
                return new FunghiPizza();
            }
            return new HamPizza();
        }
    }
}
