using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyBehaviourLibrary;
using QuackBehaviourLibrary;

namespace DuckSimulatorLibrary
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new MuteQuack();
        }
        public override string Display()
        {
            return "I am a rubber duck.";
        }
    }
}
