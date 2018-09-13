using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary
{
    public class CheesePizza:Pizza
    {
        private bool _isReady;

        public CheesePizza()
        {
            _isReady = false;
        }

        public override string Bake()
        {
            return "I am baking a Cheese Pizza";
        }

        public override string Box()
        {
            _isReady = true;
            return "I am boxing a Cheese Pizza";
        }

        public override string Prepare()
        {
            return "I am preparing a Cheese Pizza";
        }

        public override string ShowDetails()
        {
            if (_isReady)
            {
                return this.Prepare() + "\n" + this.Bake() + "\n" + this.Box();
            }
            else
            {
                return "Sorry. Not ready yet";
            }
        }
    }
}
