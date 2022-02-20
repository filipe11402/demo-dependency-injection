using System;

namespace API.Services.LifeCyles
{
    public class SingletonService : ISingletonService
    {
        public Guid Id { get; private set; }

        public SingletonService()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return this.Id;
        }
    }
}
