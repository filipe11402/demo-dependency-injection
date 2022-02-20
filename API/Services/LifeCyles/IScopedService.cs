using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.LifeCyles
{
    public interface IScopedService
    {
        int instantiationCount { get; set; }

        int GetInstantiationCount();
    }
}
