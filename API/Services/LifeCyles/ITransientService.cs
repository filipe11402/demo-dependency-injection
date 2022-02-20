using System;

namespace API.Services.LifeCyles
{
    public interface ITransientService
    {
        Guid Id { get; }

        Guid GetId();
    }
}
