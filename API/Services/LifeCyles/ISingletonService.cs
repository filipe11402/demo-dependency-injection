using System;

namespace API.Services.LifeCyles
{
    public interface ISingletonService
    {
        Guid Id { get; }

        Guid GetId();
    }
}
