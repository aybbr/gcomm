using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDev_GCommunity_GUI.RavenCacheServices
{
    public interface IMemoryCache
    {
        T Get<T>(string key, DateTime expiry, Func<T> getFromRiotFunc);
    }
}
