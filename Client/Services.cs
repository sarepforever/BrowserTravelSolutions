using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserTravel.Client
{
    public class ServiceSingleton
    {
        public int Valor { get; set; }
    }

    public class ServiceTransient
    {
        public int Valor { get; set; }
    }
}
