using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStationLibrary
{
    public interface IService
    {
        string ServiceType { get; }
        decimal ServicePrice { get; }
    }
}
