using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    public abstract class Coffee
    {
        protected ICoffeeBeans _coffeeBeans;
        protected IMilk _milk;
        protected bool _isReady;

        internal abstract string Brew();

        internal string Pour()
        {
            _isReady = true;
            return "I am pouring the coffee";
        }

        public string ShowDetails()
        {
            if (_isReady)
            {
                return this.Brew() + "\n" + this.Pour();
            }
            return "Sorry, the coffee is not ready yet";
        }
    }
}
