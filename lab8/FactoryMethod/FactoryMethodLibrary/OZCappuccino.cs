using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class OZCappuccino : Coffee
    {
        public OZCappuccino()
        {
            _isReady = false;
        }

        public override string Brew()
        {
            return "I am brewing Aussie coffee for making a Cappuccino";
        }
    }
}
