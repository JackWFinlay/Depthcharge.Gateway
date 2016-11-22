using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Depthcharge.Gateway
{
    public class ServiceSettings : IServiceSettings
    {
        public string QueueManagerUrl { get; set; }
    }
}
