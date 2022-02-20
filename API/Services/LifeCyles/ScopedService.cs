using System;

namespace API.Services.LifeCyles
{
    public class ScopedService : IScopedService
    {
        public Guid Id { get; private set; }

        public ScopedService()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return this.Id;
        }
    }
}
