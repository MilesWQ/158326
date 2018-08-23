using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyBehaviourLibrary;
using QuackBehaviourLibrary;

namespace DuckSimulatorLibrary
{
    public abstract class Duck
    {
        IFlyBehaviour _flyBehaviour;
        IQuackBehaviour _quackBehaviour;

        public IFlyBehaviour FlyBehaviour
        {
            set
            {
                _flyBehaviour = value;
            }
        }

        public IQuackBehaviour QuackBehaviour
        {
            set
            {
                _quackBehaviour = value;
            }
        }

        public abstract string Display();


        public string PerformFly()
        {
            return _flyBehaviour.fly();
        }

        public string PerformQuack()
        {
            return _quackBehaviour.Quack();
        }
    }
}
