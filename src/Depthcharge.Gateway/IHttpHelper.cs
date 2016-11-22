using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Depthcharge.Gateway
{
    public interface IHttpHelper
    {
        Task<string> GetContentForUrlAsync(Uri url);
    }
}
