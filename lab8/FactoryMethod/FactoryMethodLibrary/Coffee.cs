using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public abstract class Coffee
    {
        protected bool _isReady;

        public abstract string Brew();

        public string Pour()
        {
            _isReady = true;
            return "I am pouring the coffee";
        }

        public string ShowDetails()
        {
            if (_isReady)
            {
                return this.Brew()+ "\n" + this.Pour();
            }
            return "Sorry. Not ready yet";
        }
    }
}
