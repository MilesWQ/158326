using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class NZCappuccino : Coffee
    {
        public NZCappuccino()
        {
            _isReady = false;
        }

        public override string Brew()
        {
            return "I am brewing coffee for making a Cappuccino using NZ chocolate crema";
        }
    }
}
