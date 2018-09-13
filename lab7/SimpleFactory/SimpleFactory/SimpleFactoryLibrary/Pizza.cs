using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary
{
    public abstract class Pizza
    {
        public abstract string Prepare();

        public abstract string Bake();

        public abstract string Box();

        public abstract string ShowDetails();
    }
}
