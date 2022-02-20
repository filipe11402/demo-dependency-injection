using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.LifeCyles
{
    public interface IScopedService
    {
        Guid Id { get; }

        Guid GetId();
    }
}
