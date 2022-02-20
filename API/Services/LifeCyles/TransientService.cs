using System;

namespace API.Services.LifeCyles
{
    public class TransientService : ITransientService
    {
        public Guid Id { get; private set; }

        public TransientService()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid GetId() => this.Id;
    }
}
