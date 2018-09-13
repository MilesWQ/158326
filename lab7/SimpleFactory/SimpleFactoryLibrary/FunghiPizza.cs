using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary
{
    public class FunghiPizza : Pizza
    {
        private bool _isReady;

        public FunghiPizza()
        {
            _isReady = false;
        }

        public override string Bake()
        {
            return "I am baking a Funghi Pizza";
        }

        public override string Box()
        {
            _isReady = true;
            return "I am boxing a Funghi Pizza";
        }

        public override string Prepare()
        {
            return "I am preparing a Funghi Pizza";
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
