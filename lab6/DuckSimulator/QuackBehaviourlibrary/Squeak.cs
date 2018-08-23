using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuackBehaviourLibrary
{
    public class Squeak : IQuackBehaviour
    {
        public string Quack()
        {
            return "Squeak squeaks";
        }
    }
}
