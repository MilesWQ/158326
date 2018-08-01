using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public class OtherInspection : IServiceType
    {
        public string ServiceName => throw new NotImplementedException();

        public decimal Price => throw new NotImplementedException();

        public string ShowServiceDetail()
        {
            throw new NotImplementedException();
        }
    }
}