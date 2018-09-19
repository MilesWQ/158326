using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class DecaffeinatedCoffeeBeans : ICoffeeBeans
    {
        string ICoffeeBeans.CoffeeBeanType => "decaffeinated coffee beans";
    }
}
