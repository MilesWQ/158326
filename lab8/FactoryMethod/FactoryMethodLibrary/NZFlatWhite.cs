using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class NZFlatWhite : Coffee
    {
        public NZFlatWhite()
        {
            _isReady = false;
        }

        public override string Brew()
        {
            return "I am brewing coffee for making a Flat white using NZ chocolate crema";
        }
    }
}
