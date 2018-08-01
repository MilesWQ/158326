using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public interface IServiceType
    {
        string ServiceName
        {
            get;
        }

        decimal Price
        {
            get;
        }

        string ShowServiceDetail();
    }
}