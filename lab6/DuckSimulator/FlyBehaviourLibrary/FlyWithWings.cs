using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyBehaviourLibrary
{
    public class FlyWithWings : IFlyBehaviour
    {
        public string fly()
        {
            return "I can fly with my wings!";
        }
    }
}
