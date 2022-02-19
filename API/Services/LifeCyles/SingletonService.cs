using System;

namespace API.Services.LifeCyles
{
    public class SingletonService : ISingletonService
    {
        private int _instantiatonCount;

        public SingletonService()
        {
            this._instantiatonCount++;
        }

        public int GetInstantiationCount()
        {
            return this._instantiatonCount;
        }
    }
}
