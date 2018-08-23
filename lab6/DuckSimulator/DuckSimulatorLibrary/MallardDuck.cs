using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyBehaviourLibrary;
using QuackBehaviourLibrary;

namespace DuckSimulatorLibrary
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Squeak();
        }

        public override string Display()
        {
            return "I am a Mallard duck";
        }
    }
}
