using System;

namespace API.Services.LifeCyles
{
    public interface ISingletonService
    {
        int GetInstantiationCount();
    }
}
