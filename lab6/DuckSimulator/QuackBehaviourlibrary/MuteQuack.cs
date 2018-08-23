using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuackBehaviourLibrary
{
    public class MuteQuack : IQuackBehaviour
    {
        public string Quack()
        {
            return "I can not quack";
        }
    }
}
