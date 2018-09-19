using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary
{
    class FullCreamMilk : IMilk
    {
        string IMilk.MilkType => "full cream milk";
    }
}
