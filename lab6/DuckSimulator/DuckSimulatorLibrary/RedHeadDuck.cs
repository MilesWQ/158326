using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyBehaviourLibrary;
using QuackBehaviourLibrary;
namespace DuckSimulatorLibrary
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quacker();
        }
        public override string Display()
        {
            return "I am a red head duck.";
        }
    }
}
