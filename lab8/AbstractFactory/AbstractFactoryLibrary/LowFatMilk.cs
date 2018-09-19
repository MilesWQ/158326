using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class LowFatMilk : IMilk
    {
        string IMilk.MilkType => "low cream milk";
    }
}
